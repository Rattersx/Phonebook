using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Phonebook
{
    public partial class AddressListForm : Form
    {
        private XmlSerializeMethods<Address> xmlSerialize = new XmlSerializeMethods<Address>("Address.xml");
        public BindingList<Address> AddressList { get; set; } = new BindingList<Address>();
        private AddressSenderDelegate _sender { get; set; }
        public AddressListForm(AddressSenderDelegate sender)
        {
            InitializeComponent();
            _sender = sender;
        }
        private void AddressListForm_Load(object sender, EventArgs e)
        {
            AddressList = xmlSerialize.Desirialize();

            addressTable.DataSource = AddressList;
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddressForm = new AddAddressForm(AddressList);
            addAddressForm.ShowDialog();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressList.RemoveAt(addressTable.CurrentCell.RowIndex);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAddressForm addressForm = new AddAddressForm(AddressList, AddressList[addressTable.CurrentCell.RowIndex], addressTable.CurrentCell.RowIndex);
            addressForm.ShowDialog();
        }

        private void AddressListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlSerialize.Serialize(AddressList);
            if (addressTable.CurrentCell != null)
            {
                _sender(AddressList[addressTable.CurrentCell.RowIndex]);
            }
        }
    }

    [Serializable]
    public class Address
    {
        public Address() { }
        public Address(string street, string house, string apartment)
        {
            Street = street;
            House = house;
            Apartment = apartment;
        }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }
}
