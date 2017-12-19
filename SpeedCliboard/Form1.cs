using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace SpeedCliboard
{
    public partial class SpeedCliboard : Form
    {
        public SpeedCliboard()
        {
            InitializeComponent();
        }

        private void SpeedCliboard_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void initRacc()
        {
            InitializeComponent();
        }

        public void getData()
        {
            if (File.Exists("data.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("data.xml");

                // Get a reference to the root node
                XmlElement elmRoot = xmlDoc.DocumentElement;

                // Create a list of nodes whose name is Title
                XmlNodeList lstButton = xmlDoc.GetElementsByTagName("button");

                int x = button1.Location.X;
                int y = button1.Location.Y;

                // Now you can check each node of the list
                foreach (XmlNode node in lstButton)
                {
                    x += 77;
                    Button racc = new Button();
                    racc.Name = node.FirstChild.InnerText;
                    racc.Text = node.FirstChild.InnerText;
                    racc.Height = 23;
                    racc.Width = 75;
                    racc.Location = new Point(x, y);
                    racc.Click += delegate
                    {
                        copyFlie(node.LastChild.InnerText);
                    };
                    Controls.Add(racc);
                }
            }
            else
            {
                XmlTextWriter writer = new XmlTextWriter("data.xml", System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("Data");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private void copyFlie(String path)
        {
            using (StreamReader fs = new StreamReader(path))
            {
                String line = fs.ReadToEnd();
                Clipboard.SetData(DataFormats.Text, line);
                MessageBox.Show("Contenu du document copier dans le Clipboard !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter aj = new Ajouter();
            aj.Show(this);
        }
    }
}
