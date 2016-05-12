using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FestManager.Forms;
using FestManager.Utils;
using System.Data.OleDb;

namespace FestManager
{
    public partial class FormMain : Form
    {
        private int childFormNumber = 0;
        private NameFormCollection childs = new NameFormCollection();
        private NameValueCollection childNames = new NameValueCollection();
        private FormWindowState oldState;

        public FormMain()
        {
            /*//Console.WriteLine();
            OleDbConnection con = new OleDbConnection(Properties.Settings.Default.connectionString);

            //OleDbConnection con = new OleDbConnection(AccessDbConnect.Properties.Settings.Default.ConnectionString);
            //Console.WriteLine(AccessDbConnect.Properties.Settings.Default.ConnectionString);

            //return;
            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\fest08.MDB");

            //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\\test.mdb");
            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\abc.mdb;Jet OLEDB:Database Password=password
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Artikel", con);
            OleDbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MessageBox.Show("Resultset: " + rd[0].ToString());
                break;
            }
            rd.Close();
            con.Close();
            */

            InitializeComponent();

            childNames.Add("FormPersonal",      "Personal");
            childNames.Add("FormBestellung", "Bestellungen");
            childNames.Add("FormBestellungenHistory", "BestellungenHistory");
            childNames.Add("FormArtikel",       "Artikel");
            childNames.Add("FormEinheit",       "Einheiten");
            childNames.Add("FormAusgabestelle", "Ausgabestellen");
            childNames.Add("FormAuswertungen",  "Auswertungen");
            childNames.Add("FormPrinter", "Druckeinstellungen");
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            Form childForm = new Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                // TODO: Add code here to open the file.
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        /*private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }*/

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }



        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            childOpen(e.Node.Text);
        }

        private void childOpen(String name)
        {
            switch (name)
            {
                
                case "Bestellung":

                    if (!childs.ContainsKey("Bestellung") || childs.Get("Bestellung") == null)
                    {
                        FormBestellung formBestellung = new FormBestellung();
                        formBestellung.MdiParent = this;
                        formBestellung.WindowState = FormWindowState.Maximized;
                        formBestellung.Disposed += new EventHandler(childForm_Disposed);
                        formBestellung.Show();
                        formBestellung.Focus();
                        formBestellung.personalIdComboBox.Focus();

                        childs.Add("Bestellung", formBestellung);
                    }
                    else
                    {
                        childs.Get("Bestellung").Focus();
                        FormBestellung formBestellung = (FormBestellung)childs.Get("Bestellung");
                        formBestellung.personalIdComboBox.Focus();
                    }

                    break;

                case "Bestellungen History":

                    if (!childs.ContainsKey("BestellungenHistory") || childs.Get("BestellungenHistory") == null)
                    {
                        FormBestellungenHistory formBestellungsHistory = new FormBestellungenHistory();
                        formBestellungsHistory.MdiParent = this;
                        formBestellungsHistory.WindowState = FormWindowState.Maximized;
                        formBestellungsHistory.Disposed += new EventHandler(childForm_Disposed);
                        formBestellungsHistory.Show();
                        formBestellungsHistory.Focus();

                        childs.Add("BestellungenHistory", formBestellungsHistory);
                    }
                    else
                    {
                        childs.Get("BestellungenHistory").Focus();
                    }

                    break;
                
                case "Personal":

                    if (!childs.ContainsKey("Personal") || childs.Get("Personal") == null)
                    {
                        FormPersonal formPersonal = new FormPersonal();
                        formPersonal.MdiParent = this;
                        formPersonal.WindowState = FormWindowState.Maximized;
                        formPersonal.Disposed += new EventHandler(childForm_Disposed);
                        formPersonal.Show();
                        formPersonal.Focus();

                        childs.Add("Personal", formPersonal);
                    }
                    else
                    {
                        childs.Get("Personal").Focus();
                    }

                    break;

                case "Artikel":

                    if (!childs.ContainsKey("Artikel") || childs.Get("Artikel") == null)
                    {
                        FormArtikel formArtikel = new FormArtikel();
                        formArtikel.MdiParent = this;
                        formArtikel.WindowState = FormWindowState.Maximized;
                        formArtikel.Disposed += new EventHandler(childForm_Disposed);
                        formArtikel.Show();
                        formArtikel.Focus();

                        childs.Add("Artikel", formArtikel);
                    }
                    else
                    {
                        childs.Get("Artikel").Focus();
                    }

                    break;

                case "Ausgabestellen":

                    if (!childs.ContainsKey("Ausgabestellen") || childs.Get("Ausgabestellen") == null)
                    {
                        FormAusgabestelle formAusgabestelle = new FormAusgabestelle();
                        formAusgabestelle.MdiParent = this;
                        formAusgabestelle.WindowState = FormWindowState.Maximized;
                        formAusgabestelle.Disposed += new EventHandler(childForm_Disposed);
                        formAusgabestelle.Show();
                        formAusgabestelle.Focus();

                        childs.Add("Ausgabestellen", formAusgabestelle);
                    }
                    else
                    {
                        childs.Get("Ausgabestellen").Focus();
                    }

                    break;

                case "Verkaufssummen":

                    if (!childs.ContainsKey("Verkaufssummen") || childs.Get("Verkaufssummen") == null)
                    {
                        FormAuswertungen formAuswertungen = new FormAuswertungen("Verkaufssummen");
                        formAuswertungen.MdiParent = this;
                        formAuswertungen.WindowState = FormWindowState.Maximized;
                        formAuswertungen.Disposed += new EventHandler(childForm_Disposed);
                        formAuswertungen.Show();
                        formAuswertungen.Focus();

                        childs.Add("Verkaufssummen", formAuswertungen);
                    }
                    else
                    {
                        childs.Get("Verkaufssummen").Focus();
                    }

                    break;
                case "Kellnerabrechnung":

                    if (!childs.ContainsKey("Kellnerabrechnung") || childs.Get("Kellnerabrechnung") == null)
                    {
                        FormAuswertungen formAuswertungen = new FormAuswertungen("Kellnerabrechnung");
                        formAuswertungen.MdiParent = this;
                        formAuswertungen.WindowState = FormWindowState.Maximized;
                        formAuswertungen.Disposed += new EventHandler(childForm_Disposed);
                        formAuswertungen.Show();
                        formAuswertungen.Focus();

                        childs.Add("Kellnerabrechnung", formAuswertungen);
                    }
                    else
                    {
                        childs.Get("Kellnerabrechnung").Focus();
                    }

                    break;

                case "Bestellungen":
                    if (!childs.ContainsKey("Bestellungen") || childs.Get("Bestellungen") == null)
                    {
                        FormAuswertungen formAuswertungen = new FormAuswertungen("Bestellungen");
                        formAuswertungen.MdiParent = this;
                        formAuswertungen.WindowState = FormWindowState.Maximized;
                        formAuswertungen.Disposed += new EventHandler(childForm_Disposed);
                        formAuswertungen.Show();
                        formAuswertungen.Focus();

                        childs.Add("Bestellungen", formAuswertungen);
                    }
                    else
                    {
                        childs.Get("Bestellungen").Focus();
                    }

                    break;
                
                case "Druckeinstellungen":

                    if (!childs.ContainsKey("Druckeinstellungen") || childs.Get("Druckeinstellungen") == null)
                    {
                        FormPrinter formPrinter = new FormPrinter();
                        formPrinter.MdiParent = this;
                        formPrinter.WindowState = FormWindowState.Maximized;
                        formPrinter.Disposed += new EventHandler(childForm_Disposed);
                        formPrinter.Show();
                        formPrinter.Focus();

                        childs.Add("Druckeinstellungen", formPrinter);
                    }
                    else
                    {
                        childs.Get("Druckeinstellungen").Focus();
                    }

                    break;

                default:
                    break;


            }
        }


        void childForm_Disposed(object sender, EventArgs e)
        {
            
            try
            {
                Form formSender = (Form)sender;
                childs.Remove(childNames[formSender.Name]);
            }
            catch(ArgumentNullException)
            {

            }

        }

        private void treeViewMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            childOpen(e.Node.Text);
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childOpen("Personal");
        }

        private void artikelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childOpen("Artikel");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutFestmanager about = new AboutFestmanager();
            about.Show();
        }

        private void einheitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childOpen("Einheiten");
        }

        private void ausgabestellenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childOpen("Ausgabestellen");
        }

        /*private void vollbildToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!vollbildToolStripMenuItem.Checked)
            {
                vollbildToolStripMenuItem.Checked = true;
                oldState = this.WindowState;
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                vollbildToolStripMenuItem.Checked = false;
                this.WindowState = oldState;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }

        }*/

        /*private void taskleisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!taskleisteToolStripMenuItem.Checked)
            {
                taskleisteToolStripMenuItem.Checked = true;
                treeViewMain.Visible = true;
            }
            else
            {
                taskleisteToolStripMenuItem.Checked = false;
                treeViewMain.Visible = false;
            }
        }*/

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
