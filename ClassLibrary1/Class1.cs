using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//библиотека
namespace ClassLibrary1
{//класс Пара
    public class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }
        
        public Pair()
        {
            First = 10;
            Second = -10;
        }
        /// <summary>
        /// Функция присваивает значения соответствующим переменным
        /// </summary>
        /// <param name="first">int first</param>
        /// <param name="second">int second</param>
        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }
        /// <summary>
        /// сравнение первой пары чисел со второй
        /// </summary>
        /// <param name="pair">Pair pair</param>
        /// <returns></returns>
        public bool IsBigger(Pair pair)
        {//если значения текущей пары больше второй
            if (this.First >= pair.First && this.Second > pair.Second) return true;
            return false;
        }
        /// <summary>
        /// Функция присваивает новые значения соответствующим переменным
        /// </summary>
        /// <param name="first">int first</param>
        /// <param name="second">int second</param>
        public void SetParams(int first, int second)
        {
            First = first;
            Second = second;
        }
    }
}
