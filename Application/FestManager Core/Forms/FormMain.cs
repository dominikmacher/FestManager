using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FestManager_Core.Forms;
using FestManager_Core.Forms.SubForms;
using FestManager_Core.Utils;
using System.Data.OleDb;

namespace FestManager_Core.Forms
{
    public partial class FormMain : Form
    {
        private int childFormNumber = 0;
        private NameFormCollection childs = new NameFormCollection();


        private void InitializeTreeViewComponent(Collection<TreeViewNode> nodes)
        {
            System.Windows.Forms.TreeNode[] treenodes = new System.Windows.Forms.TreeNode[nodes.Count];
            for (int i = 0; i < nodes.Count; i++)
            {
                System.Windows.Forms.TreeNode[] children = new System.Windows.Forms.TreeNode[nodes[i].children.Count];
                for (int j = 0; j < nodes[i].children.Count; j++)
                {
                    children[j] = new System.Windows.Forms.TreeNode(nodes[i].children[j].name, nodes[i].children[j].imageIndex, nodes[i].children[j].selectedImageIndex);
                }
                treenodes[i] = new System.Windows.Forms.TreeNode(nodes[i].name, nodes[i].imageIndex, nodes[i].selectedImageIndex, children);
            }
            this.treeViewMain.Nodes.AddRange(treenodes);
        }


        public FormMain(string name, Collection<TreeViewNode> nodes)
        {
            InitializeComponent();
            InitializeTreeViewComponent(nodes);

            this.Text += " [" + name + "]";
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

                /*case "Verkaufssummen":

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

                    break;*/
                case "Kellnerabrechnung":
                    if (!childs.ContainsKey("Kellnerabrechnung") || childs.Get("Kellnerabrechnung") == null)
                    {
                        FormKellnerabrechnung formKellnerabrechnung = new FormKellnerabrechnung();
                        formKellnerabrechnung.MdiParent = this;
                        formKellnerabrechnung.WindowState = FormWindowState.Maximized;
                        formKellnerabrechnung.Disposed += new EventHandler(childForm_Disposed);
                        formKellnerabrechnung.Show();
                        formKellnerabrechnung.Focus();

                        childs.Add("Kellnerabrechnung", formKellnerabrechnung);
                    }
                    else
                    {
                        childs.Get("Kellnerabrechnung").Focus();
                    }

                    break;
                    
                case "Offene Abrechnungen":
                    if (!childs.ContainsKey("Offene Abrechnungen") || childs.Get("Offene Abrechnungen") == null)
                    {
                        FormKellnerabrechnungOffen formKellnerabrechnungOffen = new FormKellnerabrechnungOffen();
                        formKellnerabrechnungOffen.MdiParent = this;
                        formKellnerabrechnungOffen.WindowState = FormWindowState.Maximized;
                        formKellnerabrechnungOffen.Disposed += new EventHandler(childForm_Disposed);
                        formKellnerabrechnungOffen.Show();
                        formKellnerabrechnungOffen.Focus();

                        childs.Add("Offene Abrechnungen", formKellnerabrechnungOffen);
                    }
                    else
                    {
                        childs.Get("Offene Abrechnungen").Focus();
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

                case "Manuelles Stornieren":

                    if (!childs.ContainsKey("ManualStorno") || childs.Get("ManualStorno") == null)
                    {
                        FormManualStorno formManualStorno = new FormManualStorno();
                        formManualStorno.MdiParent = this;
                        formManualStorno.WindowState = FormWindowState.Maximized;
                        formManualStorno.Disposed += new EventHandler(childForm_Disposed);
                        formManualStorno.Show();
                        formManualStorno.Focus();

                        childs.Add("ManualStorno", formManualStorno);
                    }
                    else
                    {
                        childs.Get("ManualStorno").Focus();
                    }

                    break;

                case "Info":

                    if (!childs.ContainsKey("Info") || childs.Get("Info") == null)
                    {
                        FormInfo formInfo = new FormInfo();
                        formInfo.MdiParent = this;
                        formInfo.WindowState = FormWindowState.Maximized;
                        formInfo.Disposed += new EventHandler(childForm_Disposed);
                        formInfo.Show();
                        formInfo.Focus();

                        childs.Add("Info", formInfo);
                    }
                    else
                    {
                        childs.Get("Info").Focus();
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
                foreach (var key in childs.Keys)
                {
                    Form formTmp = (Form)childs[key.ToString()];
                    if (String.Compare(formTmp.Name, formSender.Name, true) == 0)
                    {
                        childs.Remove(key.ToString());
                    }
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Error...");
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
        
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
