using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using FestManager_Core.Data.FestManagerDataSetTableAdapters;
using FestManager_Core.Forms.SubForms;
using FestManager_Core.Properties;
using FestManager_Core.Utils;

namespace FestManager_Core.Forms
{
    public partial class FormMain : Form
    {
        private readonly NameFormCollection _childs = new NameFormCollection();
        
        private void InitializeTreeViewComponent(IList<TreeViewNode> nodes)
        {
            var treenodes = new TreeNode[nodes.Count];
            for (var i = 0; i < nodes.Count; i++)
            {
                var children = new TreeNode[nodes[i].Children.Count];
                for (var j = 0; j < nodes[i].Children.Count; j++)
                {
                    children[j] = new TreeNode(nodes[i].Children[j].Name, nodes[i].Children[j].ImageIndex, nodes[i].Children[j].SelectedImageIndex);
                }
                treenodes[i] = new TreeNode(nodes[i].Name, nodes[i].ImageIndex, nodes[i].SelectedImageIndex, children);
            }
            treeViewMain.Nodes.AddRange(treenodes);
        }


        public FormMain(string name, IList<TreeViewNode> nodes)
        {
            InitializeComponent();
            InitializeTreeViewComponent(nodes);

            if (!CheckDatabaseConnectivity() && MessageBox.Show(
                        Resources.Error_connection_to_DB_Msg,
                        Resources.Error_connection_to_DB_Title, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var formSettings = new FormSettings();
                formSettings.Show(this);
            }

            Text += " [" + name + "]";
        }

        private bool CheckDatabaseConnectivity()
        {
            try
            {
                var ausgabestelleTableAdapter = new AusgabestelleTableAdapter();

                ausgabestelleTableAdapter.Fill(festManagerDataSet.Ausgabestelle);

                var count = festManagerDataSet.Ausgabestelle.Count;

                if (count > 0)
                    return true;
            }
            catch (Exception)
            {
                // ignored
            }

            return false;
        }

        [Localizable(false)]
        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }


        private void treeViewMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ChildOpen(e.Node.Text);
        }

        private void ChildOpen(string name)
        {
            switch (name)
            {
                case "Bestellung":

                    if (!_childs.ContainsKey("Bestellung") || _childs.Get("Bestellung") == null)
                    {
                        var formBestellung = new FormBestellung
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formBestellung.Disposed += childForm_Disposed;
                        formBestellung.Show();
                        formBestellung.Focus();
                        formBestellung.personalIdComboBox.Focus();

                        _childs.Add("Bestellung", formBestellung);
                    }
                    else
                    {
                        _childs.Get("Bestellung").Focus();
                        var formBestellung = (FormBestellung)_childs.Get("Bestellung");
                        formBestellung.personalIdComboBox.Focus();
                    }

                    break;

                case "Bestellungen History":

                    if (!_childs.ContainsKey("BestellungenHistory") || _childs.Get("BestellungenHistory") == null)
                    {
                        var formBestellungsHistory = new FormBestellungenHistory
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formBestellungsHistory.Disposed += childForm_Disposed;
                        formBestellungsHistory.Show();
                        formBestellungsHistory.Focus();

                        _childs.Add("BestellungenHistory", formBestellungsHistory);
                    }
                    else
                    {
                        _childs.Get("BestellungenHistory").Focus();
                    }

                    break;
                
                case "Personal":

                    if (!_childs.ContainsKey("Personal") || _childs.Get("Personal") == null)
                    {
                        var formPersonal = new FormPersonal
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formPersonal.Disposed += childForm_Disposed;
                        formPersonal.Show();
                        formPersonal.Focus();

                        _childs.Add("Personal", formPersonal);
                    }
                    else
                    {
                        _childs.Get("Personal").Focus();
                    }

                    break;

                case "Artikel":

                    if (!_childs.ContainsKey("Artikel") || _childs.Get("Artikel") == null)
                    {
                        var formArtikel = new FormArtikel
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formArtikel.Disposed += childForm_Disposed;
                        formArtikel.Show();
                        formArtikel.Focus();

                        _childs.Add("Artikel", formArtikel);
                    }
                    else
                    {
                        _childs.Get("Artikel").Focus();
                    }

                    break;

                case "Ausgabestellen":

                    if (!_childs.ContainsKey("Ausgabestellen") || _childs.Get("Ausgabestellen") == null)
                    {
                        var formAusgabestelle = new FormAusgabestelle
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formAusgabestelle.Disposed += childForm_Disposed;
                        formAusgabestelle.Show();
                        formAusgabestelle.Focus();

                        _childs.Add("Ausgabestellen", formAusgabestelle);
                    }
                    else
                    {
                        _childs.Get("Ausgabestellen").Focus();
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
                    if (!_childs.ContainsKey("Kellnerabrechnung") || _childs.Get("Kellnerabrechnung") == null)
                    {
                        var formKellnerabrechnung = new FormKellnerabrechnung
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formKellnerabrechnung.Disposed += childForm_Disposed;
                        formKellnerabrechnung.Show();
                        formKellnerabrechnung.Focus();

                        _childs.Add("Kellnerabrechnung", formKellnerabrechnung);
                    }
                    else
                    {
                        _childs.Get("Kellnerabrechnung").Focus();
                    }

                    break;
                    
                case "Offene Abrechnungen":
                    if (!_childs.ContainsKey("Offene Abrechnungen") || _childs.Get("Offene Abrechnungen") == null)
                    {
                        var formKellnerabrechnungOffen = new FormKellnerabrechnungOffen
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formKellnerabrechnungOffen.Disposed += childForm_Disposed;
                        formKellnerabrechnungOffen.Show();
                        formKellnerabrechnungOffen.Focus();

                        _childs.Add("Offene Abrechnungen", formKellnerabrechnungOffen);
                    }
                    else
                    {
                        _childs.Get("Offene Abrechnungen").Focus();
                    }

                    break;
                    
                case "Bestellungen":
                    if (!_childs.ContainsKey("Bestellungen") || _childs.Get("Bestellungen") == null)
                    {
                        var formAuswertungen = new FormAuswertungen("Bestellungen")
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formAuswertungen.Disposed += childForm_Disposed;
                        formAuswertungen.Show();
                        formAuswertungen.Focus();

                        _childs.Add("Bestellungen", formAuswertungen);
                    }
                    else
                    {
                        _childs.Get("Bestellungen").Focus();
                    }

                    break;
                
                case "Druckeinstellungen":

                    if (!_childs.ContainsKey("Druckeinstellungen") || _childs.Get("Druckeinstellungen") == null)
                    {
                        var formPrinter = new FormPrinter
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formPrinter.Disposed += childForm_Disposed;
                        formPrinter.Show();
                        formPrinter.Focus();

                        _childs.Add("Druckeinstellungen", formPrinter);
                    }
                    else
                    {
                        _childs.Get("Druckeinstellungen").Focus();
                    }

                    break;

                case "Manuelles Stornieren":

                    if (!_childs.ContainsKey("ManualStorno") || _childs.Get("ManualStorno") == null)
                    {
                        var formManualStorno = new FormManualStorno
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formManualStorno.Disposed += childForm_Disposed;
                        formManualStorno.Show();
                        formManualStorno.Focus();

                        _childs.Add("ManualStorno", formManualStorno);
                    }
                    else
                    {
                        _childs.Get("ManualStorno").Focus();
                    }

                    break;

                case "Info":

                    if (!_childs.ContainsKey("Info") || _childs.Get("Info") == null)
                    {
                        var formInfo = new FormInfo
                        {
                            MdiParent = this,
                            WindowState = FormWindowState.Maximized
                        };
                        formInfo.Disposed += childForm_Disposed;
                        formInfo.Show();
                        formInfo.Focus();

                        _childs.Add("Info", formInfo);
                    }
                    else
                    {
                        _childs.Get("Info").Focus();
                    }

                    break;
            }
        }


        private void childForm_Disposed(object sender, EventArgs e)
        {
            try
            {
                var formSender = (Form)sender;
                foreach (var key in _childs.Keys.ToArray())
                {
                    var formTmp = _childs[key];
                    if (string.Compare(formTmp.Name, formSender.Name, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        _childs.Remove(key);
                    }
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show(Resources.Error);
            }

        }

        private void treeViewMain_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ChildOpen(e.Node.Text);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
