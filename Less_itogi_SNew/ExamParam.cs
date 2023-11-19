using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_itogi_SNew
{
    internal class ExamParam
    {
        // создаем делегат
        public delegate void paramSort(int numParam);

        // создаем событие под этот делегат
        public event paramSort EventParamSort;

        // создаем метод, который будет вызывать это событие
        public void CallEvent(int ValParam)
        {
            if (ValParam == 1 || ValParam == 2)
            {
                EventParamSort?.Invoke(ValParam);
            }
            else 
            {
                Console.WriteLine("События не произошло!");
            }       
        }
    }
}
