package org.festmanager;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStream;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Properties;


public class FestDatabaseParser {
	
	public final static SimpleDateFormat formatter = new SimpleDateFormat("d.M.yyyy");

	public static void main(String[] args) throws IOException, ClassNotFoundException {
		
		Properties prop = new Properties();
		InputStream inputStream = FestDatabaseParser.class.getClassLoader().getResourceAsStream("config.properties");

        if (inputStream == null) {
            System.out.println("ERROR: cannot find properties file");
            return;
        }
        prop.load(inputStream);
				
        String dbFileName = prop.getProperty("dbFileName");
        String outputFileName = prop.getProperty("outputFileName");
        String grillhendlId = prop.getProperty("grillhendlId");
		
		if (args.length > 0) { 
			for (String parameter : args) {
				if (parameter.toLowerCase().equals("-h") || parameter.toLowerCase().equals("--help")) {
					System.out.println("Usage: java -jar FestDatabaseParser.jar");
					System.out.println("  [dbfilename=...]      Database filename");
					System.out.println("  [outputFileName=...]  Output filename");
		            return;
		        }
				
				String[] parameterParts = parameter.split("=");
				if (parameterParts.length > 1) {
					if (parameterParts[0].toLowerCase().equals("dbfilename")) {
						dbFileName = parameterParts[1];
					}
					else if (parameterParts[0].toLowerCase().equals("outputfilename")) {
						outputFileName = parameterParts[1];
					}
				}
			}
        } 
	
        _writeToFile(outputFileName, "Grillhendl: "+_fetchGrillhendlFromToday(dbFileName), false);
        
        System.out.println("SUCCESS");
	}
	
	
	private static Integer _fetchGrillhendlFromToday(String dbFileName) throws ClassNotFoundException {
		Integer alreadyOrderedGrillhendl = 0;
		
		try {
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver"); 
			Connection conn = DriverManager.getConnection("jdbc:ucanaccess://"+dbFileName);
			Statement s = conn.createStatement();
			ResultSet rs = s.executeQuery("SELECT * FROM [BestellungArtikel_GrillhendlProTag]");
						
			while (rs.next()) {
			    //System.out.println(rs.getString(1) + "_" + rs.getString(2));
				
				// Check if date is in the correct format:
				Date tmp = formatter.parse(rs.getString(1));
				if (rs.getString(1).equals(formatter.format(new Date()))) {
					alreadyOrderedGrillhendl = Integer.parseInt(rs.getString(2));
					break;
				}
			}
			
			conn.close();
			
		} catch (SQLException e) {
			System.out.println("ERROR: cannot connect to database");
			e.printStackTrace();
			
		} catch (ParseException e1) {
			System.out.println("ERROR: cannot parse date");
		}

		return alreadyOrderedGrillhendl;
	}
	
	
	private static void _writeToFile(String fileName, String text, boolean append) {
		File file = new File(fileName);
		try {
			file.createNewFile();
		} catch (IOException e) {
			System.out.println("ERROR: cannot create file");
		} 
		
		try {
			FileWriter fileWriter = new FileWriter(file, append);
			BufferedWriter bufWriter = new BufferedWriter(fileWriter);
			bufWriter.write(text);
			bufWriter.newLine();
			bufWriter.close();
			fileWriter.close();
		} catch (IOException e) {
			System.out.println("ERROR: cannot write to file");
		}
	}

}
