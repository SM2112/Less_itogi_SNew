using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_itogi_SNew
{
    // итоговоей задание 1.1.
    // создаем свой класс ошибки

    internal class PersonException : Exception
    {
        /// <summary>
        ///  этот класс наследуется от класса Exception
        /// </summary>


        //создаем конструктор (в прринципе этот конструктор и не нужен здесь
        // но пусть будет
        public PersonException()
        {

        }

        // создаем конструктор с передачей сообщения об ошибке
        public PersonException(string messageEx) : base(messageEx)
        {
            /// пустой конструктор
            /// образец взял с метанита
            /// в наших модулях описание хуже чем в метаните 
        }
    }
}
