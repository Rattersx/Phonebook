using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Phonebook
{
    public partial class GeneralListForm : Form
    {
        private XmlSerializeMethods<PeopleGeneralInfo> xmlSerialize = new XmlSerializeMethods<PeopleGeneralInfo>(Properties.Resources.GeneralPath);
        public BindingList<PeopleGeneralInfo> GeneralList { get; set; } = new BindingList<PeopleGeneralInfo>();

        public GeneralListForm() => InitializeComponent();

        private void GeneralListForm_Load(object sender, EventArgs e)
        {
            GeneralList = xmlSerialize.Desirialize();

            generalTable.DataSource = GeneralList;
        }
        private void GeneralListForm_FormClosing(object sender, FormClosingEventArgs e) => xmlSerialize.Serialize(GeneralList);

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGeneralForm addGeneralForm = new AddGeneralForm();
            addGeneralForm.InitAdd(GeneralList);
            addGeneralForm.ShowDialog();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GeneralList.Count > 0)
            {
                AddGeneralForm addGeneralForm = new AddGeneralForm();
                addGeneralForm.InitEdit(GeneralList, GeneralList[generalTable.CurrentCell.RowIndex], generalTable.CurrentCell.RowIndex);
                addGeneralForm.ShowDialog();
            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(GeneralList.Count > 0)
            {
                GeneralList.RemoveAt(generalTable.CurrentCell.RowIndex);
            }
        }
    }

/* Класс общих методов сериализации/десериализации классов */
    public class XmlSerializeMethods<T>
    {
        private string path;

        public XmlSerializeMethods(string path)
        {
            this.path = path;
        }

        public void Serialize(BindingList<T> bindingList)
        {
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<T>));
            File.Delete(this.path);

            using (FileStream fs = new FileStream(this.path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, bindingList);
            }
        }

        public BindingList<T> Desirialize()
        {
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(BindingList<T>));

                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(this.path, FileMode.Open))
                    {
                        return (BindingList<T>)xml.Deserialize(fs);
                    }
                }
                return new BindingList<T>();
            }
            catch
            {
                MessageBox.Show(Properties.Resources.FileUploadError + path);
                File.Delete(path);
                return new BindingList<T>();
            }
        }
    }
}
