using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr9v7
{
    /// <summary>
    /// Структура для работы с данными пользователя
    /// </summary>
    public struct PersonData
    {
        /// <summary>
        /// Поля структуры PersonData
        /// </summary>
        public string _firstName { get; set; }
        public string _patronomic { get; set; }
        public string _lastName { get; set; }
        public int _phoneNumber { get; set; }
        public string _address { get; set; }

        /// <summary>
        /// Конструктор структуры PersonData
        /// </summary>
        /// <param name="firsName"></param>
        /// <param name="patronomic"></param>
        /// <param name="lastName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        public PersonData (string firsName, string patronomic, string lastName, int phoneNumber, string address)
        {
            _firstName = firsName;
            _patronomic = patronomic;
            _lastName = lastName;
            _phoneNumber = phoneNumber;
            _address = address;
        }        
    }
}
