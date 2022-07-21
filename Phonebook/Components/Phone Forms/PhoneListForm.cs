using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class PhoneListForm : Form
    {
        private XmlSerializeMethods<Phone> xmlSerialize = new XmlSerializeMethods<Phone>(Properties.Resources.PhonePath);
        private PhoneSenderDelegate _sender { get; set; }
        public BindingList<Phone> PhoneList { get; set; } = new BindingList<Phone>();
        public PhoneListForm() => InitializeComponent();
        public void Init(PhoneSenderDelegate sender) => _sender = sender;

        private void PhoneListForm_Load(object sender, EventArgs e)
        {
            PhoneList = xmlSerialize.Desirialize();

            phoneListTable.DataSource = PhoneList;
        }

        private void PhoneListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(PhoneList);
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhoneForm addPhoneForm = new AddPhoneForm();
            addPhoneForm.InitAdd(PhoneList);
            addPhoneForm.ShowDialog();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneList.Count > 0)
            {
                PhoneList.RemoveAt(phoneListTable.CurrentCell.RowIndex);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhoneList.Count > 0)
            {
                AddPhoneForm addPhoneForm = new AddPhoneForm();
                addPhoneForm.InitEdit(PhoneList, PhoneList[phoneListTable.CurrentCell.RowIndex], phoneListTable.CurrentCell.RowIndex);
                addPhoneForm.ShowDialog();
            }
        }

        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            if (phoneListTable.CurrentCell != null)
            {
                _sender(PhoneList[phoneListTable.CurrentCell.RowIndex]);
            }
            this.Close();
        }
    }
}
