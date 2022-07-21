using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class AddPhoneForm : Form
    {
        public BindingList<Phone> phoneList = new BindingList<Phone>();
        private Phone _phone { get; set; }
        private int _index { get; set; }
        public AddPhoneForm() => InitializeComponent();

        public void InitAdd(BindingList<Phone> phoneList) => this.phoneList = phoneList;

        public void InitEdit(BindingList<Phone> phoneList, Phone phone, int index) 
        {
            InitializeComponent();
            this.phoneList = phoneList;
            _phone = phone;
            _index = index;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (phoneTB.Text == "" && !homePhoneRB.Checked && !mobilePhoneRB.Checked)
            {
                MessageBox.Show(Properties.Resources.NoneInfoError, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (_phone == null) // Добавить
            {
                phoneList.Add(new Phone(phoneTB.Text, typeDetermine()));
            }
            else if (_phone != null) // Редактировать
            {
                phoneList[_index] = new Phone(phoneTB.Text, typeDetermine());
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e) => this.Close();

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
