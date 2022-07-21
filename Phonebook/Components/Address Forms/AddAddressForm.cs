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
    public partial class AddAddressForm : Form
    {
        public BindingList<Address> AddressList { get; set; }
        private Address _address { get; set; }
        private int _index { get; set; }

        public AddAddressForm(BindingList<Address> addressList) // Добавить
        {
            AddressList = addressList;
            InitializeComponent();
        }

        public AddAddressForm(BindingList<Address> addressList, Address address, int index) // Редактировать
        {
            AddressList = addressList;
            _address = address;
            _index = index;
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(_address != null) // Редактировать
            {
                AddressList[_index] = new Address(streetTB.Text, houseTB.Text, apartmentTB.Text);
                this.Close();
            }
            else // Добавить
            {
                AddressList.Add(new Address(streetTB.Text, houseTB.Text, apartmentTB.Text));
                this.Close();
            }
        }

        private void AddAddressForm_Load(object sender, EventArgs e)
        {
            if(_address != null)
            {
                streetTB.Text = _address.Street;
                houseTB.Text = _address.House;
                apartmentTB.Text = _address.Apartment;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
