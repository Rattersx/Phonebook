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
    public partial class AddPhoneForm : Form
    {
        public BindingList<Phone> phoneList = new BindingList<Phone>();
        private Phone _phone { get; set; }
        private int _index { get; set; }

        public AddPhoneForm(BindingList<Phone> phoneList) //  Добавить
        {
            InitializeComponent();
            this.phoneList = phoneList;
        }

        public AddPhoneForm(BindingList<Phone> phoneList, Phone phone, int index) //  Редактировать
        {
            InitializeComponent();
            this.phoneList = phoneList;
            _phone = phone;
            _index = index;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_phone == null && typeDetermine() != null) // Добавить
            {
                phoneList.Add(new Phone(phoneTB.Text, typeDetermine()));
                this.Close();
            }
            else if (_phone != null && typeDetermine() != null) // Редактировать
            {
                phoneList[_index] = new Phone(phoneTB.Text, typeDetermine());
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string typeDetermine() // Метод определения типа телефона
        {
            if (homePhoneRB.Checked)
            {
                return "Домашний";
            }
            else if (mobilePhoneRB.Checked)
            {
                return "Мобильный";
            }
            return "";
        }
    }
}
