using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class AddGeneralForm : Form
    {
        BindingList<PeopleGeneralInfo> _peopleGeneralInfo { get; set; } = new BindingList<PeopleGeneralInfo>();
        public People _people { get; set; }
        public Address _address { get; set; }
        public Phone _phone { get; set; }
        int _index { get; set; } // Индекс выбранного человека из списка при редактировании
        public PeopleGeneralInfo _info { get; set; } // Выбранный из списка человек при редактировании

/* Конструктор добавления в список человека */
        public AddGeneralForm(BindingList<PeopleGeneralInfo> peopleGeneralInfo)
        {
            InitializeComponent();
            _peopleGeneralInfo = peopleGeneralInfo;
        }

/* Конструктор редактирования человека из списка */
        public AddGeneralForm(BindingList<PeopleGeneralInfo> peopleGeneralInfo, PeopleGeneralInfo info, int index)
        {
            InitializeComponent();
            _peopleGeneralInfo = peopleGeneralInfo;
            _info = info;
            _index = index;
        }

        private void AddGeneralForm_Load(object sender, EventArgs e)
        {
            if (_info != null) // Редактирование
            {
                _people = _info.PeopleClass;
                _address = _info.AddressClass;
                _phone = _info.PhoneClass;

                fioTB.Text = _info.Surname + ' ' + _info.Name + ' ' + _info.Patronymic + ' ';
                addressTB.Text = _info.Address;
                phoneTB.Text = _info.Phone;
                emailTB.Text = _info.Email;
            }
            else // Добавление
            {
                _people = new People();
                _address = new Address();
                _phone = new Phone();
            }
        }

        private void fioButton_Click(object sender, EventArgs e)
        {
            PeopleListForm peopleListForm = new PeopleListForm(new PeopleSenderDelegate(PeopleSender));
            peopleListForm.ShowDialog();
            
            if (_people != null)
            {
                fioTB.Text = _people.Surname + ' ' + _people.Name + ' ' + _people.Patronymic;
            }
            else
            {
                fioTB.Text = "";
            }
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            AddressListForm addressListForm = new AddressListForm(new AddressSenderDelegate(AddressSender));
            addressListForm.ShowDialog();

            if (_address != null)
            {
                addressTB.Text = _address.Street + ' ' + _address.House + ' ' + _address.Apartment;
            }
            else
            {
                addressTB.Text = "";
            }
        }

        private void phoneButton_Click(object sender, EventArgs e)
        {
            PhoneListForm phoneListForm = new PhoneListForm(new PhoneSenderDelegate(PhoneSender));
            phoneListForm.ShowDialog();

            if (_phone != null)
            {
                phoneTB.Text = _phone.Number;
            }
            else
            {
                phoneTB.Text = "";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_info == null)
            {
                _peopleGeneralInfo.Add(new PeopleGeneralInfo(_people, _address, _phone, emailTB.Text));
            }
            else if (_info != null)
            {
                _peopleGeneralInfo[_index] = new PeopleGeneralInfo(_people, _address, _phone, emailTB.Text);
            }
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void peopleDeleteButton_Click(object sender, EventArgs e)
        {
            fioTB.Text = "";
            _people = new People();
        }

        private void addressDeleteButton_Click(object sender, EventArgs e)
        {
            addressTB.Text = "";
            _address = new Address();
        }

        private void phoneDeleteButton_Click(object sender, EventArgs e)
        {
            phoneTB.Text = "";
            _phone = new Phone();
        }

/* Методы для делегатов (забрать классы из соответствующих дочерних форм через ссылку на метод)  */
        public void PeopleSender(People people)
        {
            if (people != null)
            {
                _people = people;
            }
        }

        public void AddressSender(Address address)
        {
            if (address != null)
            {
                _address = address;
            }
        }

        public void PhoneSender(Phone phone)
        {
            if (phone != null)
            {
                _phone = phone;
            }
        }
    }
}
