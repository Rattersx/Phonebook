using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Phonebook
{
    public partial class GeneralListForm : Form
    {
        private XmlSerializeMethods<PeopleGeneralInfo> xmlSerialize = new XmlSerializeMethods<PeopleGeneralInfo>("General.xml");
        public BindingList<PeopleGeneralInfo> GeneralList { get; set; } = new BindingList<PeopleGeneralInfo>();

        public GeneralListForm()
        {
            InitializeComponent();
        }

        private void GeneralListForm_Load(object sender, EventArgs e)
        {
            GeneralList = xmlSerialize.Desirialize();

            generalTable.DataSource = GeneralList;
        }
        private void GeneralListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(GeneralList);
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGeneralForm addGeneralForm = new AddGeneralForm(GeneralList);
            addGeneralForm.ShowDialog();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGeneralForm addGeneralForm = new AddGeneralForm(GeneralList, GeneralList[generalTable.CurrentCell.RowIndex], generalTable.CurrentCell.RowIndex);
            addGeneralForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralList.RemoveAt(generalTable.CurrentCell.RowIndex);
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
                MessageBox.Show("Произошла ошибка загрузки файла " + path + ".\nФайл обновлён!");
                File.Delete(path);
                return new BindingList<T>();
            }
        }
    }

    public class PeopleGeneralInfo
    {
        public People PeopleClass { get; set; }
        public Address AddressClass { get; set; }
        public Phone PhoneClass { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string Yearborn { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PhoneType { get; set; }
        public string Email { get; set; }
        PeopleGeneralInfo() { }

        public PeopleGeneralInfo(People people, Address address, Phone phone, string email)
        {
            this.PeopleClass = people;
            this.AddressClass = address;
            this.PhoneClass = phone;
            this.Name = this.PeopleClass.Name;
            this.Surname = this.PeopleClass.Surname;
            this.Patronymic = this.PeopleClass.Patronymic;
            this.Gender = this.PeopleClass.Gender;
            this.Yearborn = this.PeopleClass.Bornyear;
            this.Address = this.AddressClass.Street + ' ' + this.AddressClass.House + ' ' + this.AddressClass.Apartment;
            this.Phone = this.PhoneClass.Number;
            this.PhoneType = this.PhoneClass.Type;
            this.Email = email;
        }
    }
}
