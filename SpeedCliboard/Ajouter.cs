using System;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace SpeedCliboard
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameFile.Text.Trim() != "" && pathName.Text.Trim() != "")
            {
                if (File.Exists(pathName.Text))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("data.xml");
                    XmlNode root = doc.DocumentElement;
                    XmlElement elem = doc.CreateElement("button");
                    XmlElement name = doc.CreateElement("name");
                    XmlElement path = doc.CreateElement("path");
                    name.InnerText = NameFile.Text;
                    path.InnerText = pathName.Text;
                    elem.AppendChild(name);
                    elem.AppendChild(path);
                    root.AppendChild(elem);
                    doc.Save("data.xml");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Fichier introuvable !!");
                }
            }
            else
            {
                MessageBox.Show("Veuillez renseigner les champ vide !!");
            }
        }

        private void Ajouter_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            SpeedCliboard parent = (SpeedCliboard)Owner;
            parent.Controls.Clear();
            parent.initRacc();
            parent.getData();
        }
    }
}
