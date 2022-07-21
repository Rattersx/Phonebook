using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Phonebook
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GeneralListForm());
        }
    }

/* Делегаты для отправки классов из дочерних форм в родительскую */
    public delegate void PeopleSenderDelegate(People people);
    public delegate void AddressSenderDelegate(Address address);
    public delegate void PhoneSenderDelegate(Phone phone);
}
