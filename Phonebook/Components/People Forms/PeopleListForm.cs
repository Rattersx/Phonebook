using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class PeopleListForm : Form
    {
        public BindingList<People> PeopleList { get; set; } = new BindingList<People>();
        private XmlSerializeMethods<People> xmlSerialize = new XmlSerializeMethods<People>(Properties.Resources.PeoplePath);
        private PeopleSenderDelegate _sender;

        public PeopleListForm() => InitializeComponent();

        public void Init(PeopleSenderDelegate sender)
        {
            _sender = sender;
        }
        private void PeopleListForm_Load(object sender, EventArgs e)
        {
            PeopleList = xmlSerialize.Desirialize();

            peopleListTable.DataSource = PeopleList;
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPeopleForm addPeopleForm = new AddPeopleForm();
            addPeopleForm.InitAdd(PeopleList);
            addPeopleForm.ShowDialog();
        }

        private void PeopleListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(PeopleList);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PeopleList.Count > 0)
            {
                PeopleList.RemoveAt(peopleListTable.CurrentCell.RowIndex);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PeopleList.Count > 0)
            {
                AddPeopleForm addPeopleForm = new AddPeopleForm();
                addPeopleForm.InitEdit(PeopleList, PeopleList[peopleListTable.CurrentCell.RowIndex], peopleListTable.CurrentCell.RowIndex);
                addPeopleForm.ShowDialog();
            }
        }

        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            if (peopleListTable.CurrentCell != null)
            {
                _sender(PeopleList[peopleListTable.CurrentCell.RowIndex]);
            }
            this.Close();
        }
    }
}
