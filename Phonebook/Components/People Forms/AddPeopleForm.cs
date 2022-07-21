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
    public partial class AddPeopleForm : Form
    {
        public BindingList<People> PeopleList { get; set; } = new BindingList<People>();
        private People _people{ get; set; }
        private int _index { get; set; }
        public AddPeopleForm(BindingList<People> peopleList) // Добавить
        {
            InitializeComponent();
            PeopleList = peopleList;
        }

        public AddPeopleForm(BindingList<People> peopleList, People people, int index) // Редактировать
        {
            InitializeComponent();
            PeopleList = peopleList;
            _people = people;
            _index = index;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_people == null && GenderDetermine() != null) // Добавить
            {
                PeopleList.Add(new People(surnameTB.Text, nameTB.Text, patroTB.Text, yearbornTB.Text, GenderDetermine()));
                this.Close();
            }
            else if (_people != null && GenderDetermine() != null) // Редактировать
            {
                PeopleList[_index] = new People(surnameTB.Text, nameTB.Text, patroTB.Text, yearbornTB.Text, GenderDetermine());
                this.Close();
            }
        }

        private void AddPeopleForm_Load(object sender, EventArgs e)
        {
            if (_people != null)
            {
                surnameTB.Text = _people.Surname;
                nameTB.Text = _people.Name;
                patroTB.Text = _people.Patronymic;
                yearbornTB.Text = _people.Bornyear;
                if (_people.Gender == "Мужской")
                {
                    maleRB.Checked = true;
                }
                else if (_people.Gender == "Женский")
                {
                    femaleRB.Checked = true;
                }
            }
        }

        private string GenderDetermine() // Метод определения пола из соответствующе выбранного RadioButton
        {
            if (femaleRB.Checked)
            {
                return "Женский";
            }
            else if (maleRB.Checked)
            {
                return "Мужской";
            }

            return "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
