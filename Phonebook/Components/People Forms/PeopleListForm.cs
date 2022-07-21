using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class PeopleListForm : Form
    {
        public BindingList<People> PeopleList { get; set; } = new BindingList<People>();
        private XmlSerializeMethods<People> xmlSerialize = new XmlSerializeMethods<People>("People.xml");
        private PeopleSenderDelegate _sender;
        public PeopleListForm(PeopleSenderDelegate sender)
        {
            InitializeComponent();
            _sender = sender;
        }
        private void PeopleListForm_Load(object sender, EventArgs e)
        {
            PeopleList = xmlSerialize.Desirialize();

            peopleListTable.DataSource = PeopleList;
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPeopleForm addPeopleForm = new AddPeopleForm(PeopleList);
            addPeopleForm.ShowDialog();
        }

        private void PeopleListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(PeopleList);
            if (peopleListTable.CurrentCell != null)
            {
                _sender(PeopleList[peopleListTable.CurrentCell.RowIndex]);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleList.RemoveAt(peopleListTable.CurrentCell.RowIndex);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPeopleForm addPeopleForm = new AddPeopleForm(PeopleList, PeopleList[peopleListTable.CurrentCell.RowIndex], peopleListTable.CurrentCell.RowIndex);
            addPeopleForm.ShowDialog();
        }
    }

    public class People
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Bornyear { get; set; }
        public string Gender { get; set; }
        public People() { }
        public People(string surname, string name, string patronymic, string bornyear, string gender)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Bornyear = bornyear;
            Gender = gender;
        }
    }
}
