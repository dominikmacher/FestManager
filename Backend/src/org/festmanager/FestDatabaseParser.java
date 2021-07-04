package org.festmanager;
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
		
		
		if (args.length > 0) { 
			for (String parameter : args) {
				/*if (parameter.toLowerCase().equals("-h") || parameter.toLowerCase().equals("--help")) {
					System.out.println("Usage: java -jar firetelegram.jar");
					System.out.println("  [-d|--debug]    print all log messages to console");
					System.out.println("  [-i|--history]  take history alarms instead");
					System.out.println("  [-t|--test]     test mode: fetch alarm + send to test telegram channel \n");
		            return;
		        }
				/*else if (parameter.toLowerCase().equals("--debug") || parameter.toLowerCase().equals("-d")) {
					DEBUG = true;
				}
				*/
			}
        } 
		
		Properties prop = new Properties();
		InputStream inputStream = FestDatabaseParser.class.getClassLoader().getResourceAsStream("config.properties");

        if (inputStream == null) {
            System.out.println("ERROR: cannot find properties file");
            return;
        }
        prop.load(inputStream);
				
        final String dbFileName = prop.getProperty("dbFileName");
        final String grillhendlId = prop.getProperty("grillhendlId");
	
        System.out.println("Heute bereits bestellte Grillhendl: " + _fetchGrillhendlFromToday(dbFileName));
		
		
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

}
