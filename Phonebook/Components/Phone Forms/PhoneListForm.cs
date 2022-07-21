using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class PhoneListForm : Form
    {
        private XmlSerializeMethods<Phone> xmlSerialize = new XmlSerializeMethods<Phone>("Phone.xml");
        private PhoneSenderDelegate _sender { get; set; }
        public BindingList<Phone> PhoneList { get; set; } = new BindingList<Phone>();
        public PhoneListForm(PhoneSenderDelegate sender)
        {
            InitializeComponent();
            _sender = sender;
        }

        private void PhoneListForm_Load(object sender, EventArgs e)
        {
            PhoneList = xmlSerialize.Desirialize();

            phoneListTable.DataSource = PhoneList;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhoneForm addPhoneForm = new AddPhoneForm(PhoneList);
            addPhoneForm.ShowDialog();
        }

        private void PhoneListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(PhoneList);
            if (phoneListTable.CurrentCell != null)
            {
                _sender(PhoneList[phoneListTable.CurrentCell.RowIndex]);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneList.RemoveAt(phoneListTable.CurrentCell.RowIndex);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhoneForm addPhoneForm = new AddPhoneForm(PhoneList, PhoneList[phoneListTable.CurrentCell.RowIndex], phoneListTable.CurrentCell.RowIndex);
            addPhoneForm.ShowDialog();
        }

    }

    public class Phone
    {
        public string Number { get; set; }
        
        /* 0 - мобильный        1 - домашний */
        public string Type { get; set; }
        public Phone() { }
        public Phone(string number, string type)
        {
            Number = number;
            Type = type;
        }
    }
}
