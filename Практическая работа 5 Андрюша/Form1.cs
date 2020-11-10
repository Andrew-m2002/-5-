//Практическая работа №5
//Монахов Андрей ИСП-31
//4. Создать класс Pair (пара чисел). Создать необходимые методы и свойства.  
//Определить метод сравнения пар: пара p1 больше пары р2, если (first.pl > first.р2) или (first.pl = first.р2) и (second.pl > second.р2). 
//Создать перегруженные методы SetParams, для установки параметров объекта.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace Практическая_работа_5_Андрюша
{//класс Форма1
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClassLibrary1.Pair pair1 = new Pair();//создаем две пары объектов
        ClassLibrary1.Pair pair2 = new Pair();
        //Задать значения первой пары чисел
        private void задать1ПаруToolStripMenuItem_Click(object sender, EventArgs e)
        {//если первое и второе поле заполнены верно записываем значения в переменные
            if (Int32.TryParse(first1.Text, out int first) && Int32.TryParse(second1.Text, out int second))
                pair1.SetParams(first, second);
            else MessageBox.Show("Ошибка!");//иначе выводим сообщение об ошибке
            Cur1.Text = pair1.First.ToString() + "; " + pair1.Second.ToString();//отображаем текущие значения
        }
        //Задать значения второй пары чисел
        private void задать2ПаруToolStripMenuItem_Click(object sender, EventArgs e)
        {//если первое и второе поле заполнены верно записываем значения в переменные
            if (Int32.TryParse(first2.Text, out int first) && Int32.TryParse(second2.Text, out int second))
                pair2.SetParams(first, second);
            else MessageBox.Show("Ошибка!");//иначе выводим сообщение об ошибке
            Cur2.Text = pair2.First.ToString() + "; " + pair2.Second.ToString();//отображаем текущие значения
        }
        //Сравнить
        private void сравнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {//если первая пара больше второй
            if (pair1.IsBigger(pair2))
            {//сообщение
                MessageBox.Show("Первая пара больше второй");
            }//иначе сообщение 
            else MessageBox.Show("Первая пара НЕ больше второй");
        }
        //Сброс
        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {//сбрасываем значения пересоздав объекты и очистив поля
            pair1 = new Pair();
            pair2 = new Pair();
            Cur1.Text = pair1.First.ToString() + "; " + pair1.Second.ToString();
            Cur2.Text = pair2.First.ToString() + "; " + pair2.Second.ToString();
            first1.Text = " ";
            first2.Text = " ";
            second1.Text = " ";
            second2.Text = " ";
        }
        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //При загрузке формы отображаем начальные значения
        private void Form1_Load(object sender, EventArgs e)
        {
                Cur1.Text = "10, - 10";
                Cur2.Text = "10, - 10";
            
        }
        //О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("//Практическая работа №5\n" +
                "Монахов Андрей ИСП-31\n" +
                "Создать класс Pair (пара чисел).\n" +
                "Создать необходимые методы и свойства. Определить метод сравнения пар: пара p1 больше пары р2, если (first.pl > first.р2) или (first.pl = first.р2) и (second.pl > second.р2)." +
                "Создать перегруженные методы SetParams, для установки параметров объекта.");
        }

    
    }
}
