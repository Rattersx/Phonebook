using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class AddressListForm : Form
    {
        private XmlSerializeMethods<Address> xmlSerialize = new XmlSerializeMethods<Address>(Properties.Resources.AddressPath);
        public BindingList<Address> AddressList { get; set; } = new BindingList<Address>();
        private AddressSenderDelegate _sender { get; set; }
        public AddressListForm() => InitializeComponent();

        public void Init(AddressSenderDelegate sender) => _sender = sender;
        private void AddressListForm_Load(object sender, EventArgs e)
        {
            AddressList = xmlSerialize.Desirialize();

            addressTable.DataSource = AddressList;
        }
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddressForm = new AddAddressForm();
            addAddressForm.InitAdd(AddressList);
            addAddressForm.ShowDialog();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddressList.Count > 0)
            {
                AddressList.RemoveAt(addressTable.CurrentCell.RowIndex);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AddressList.Count > 0)
            {
                AddAddressForm addressForm = new AddAddressForm();
                addressForm.InitEdit(AddressList, AddressList[addressTable.CurrentCell.RowIndex], addressTable.CurrentCell.RowIndex);
                addressForm.ShowDialog();
            }
        }

        private void ChoiceButton_Click(object sender, EventArgs e)
        {
            if (addressTable.CurrentCell != null)
            {
                _sender(AddressList[addressTable.CurrentCell.RowIndex]);
            }
            this.Close();
        }

        private void AddressListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(AddressList);
        }
    }
}
