using System;
using System.Windows;
using System.Windows.Controls;
using Pr9v7;


namespace Pr9v7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public PersonData Person { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItAboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вариант 7. " +
                "\r\nЗаполнить таблицу со списком телефонных абонентов " +
                "\r\nна 7 человек с полями: ФИО, номер телефона, адрес. " +
                "\r\nВывести результат на экран. " +
                "\r\nВывести список абонентов живущих на заданной улице",
                "Разработчик: Десятов",
                MessageBoxButton.OK,
                MessageBoxImage.Asterisk);
        }

        private void mItExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        int count = 0;

        /// <summary>
        /// Заполнение таблицы данными 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFill_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string firstName = txtBoxFirstName.Text;
                string patronomic = txtBoxPatronymic.Text;
                string lastName = txtBoxLastName.Text;
                int phoneNumber = Convert.ToInt32(txtBoxPhoneNumber.Text);
                string address = txtBoxAddress.Text;
                Person = new PersonData(firstName, patronomic, lastName, phoneNumber, address);
                dGFillData.Items.Add(Person);
                count++;
            }
            catch (Exception)
            {

                MessageBox.Show("Неверные данные",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }


        /// <summary>
        /// Вывод списка абонентов по указанному адресу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResult_Click(object sender, RoutedEventArgs e)
        {


            if (dGFillData.Items.Count == 0)
            {
                MessageBox.Show("Таблица пустая, заполните значениями",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            string result = " ";

            PersonData[] personData = new PersonData[count];

            for (int i = 0; i < dGFillData.Items.Count; i++)
            {
                personData[i] = (PersonData)dGFillData.Items[i];
            }


            for (int i = 0; i < personData.Length; i++) 
            {
                if (personData[i]._address == txtBoxSelectedAddress.Text)
                {
                    result += $"{personData[i]._firstName}\r\n";
                }
            }

            txtBoxResult.Text = result;
        }
    }
}
