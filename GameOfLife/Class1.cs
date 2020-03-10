using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace Life
{

    public partial class Form1 : Form
    {
        private bool stopflag = false; //переключатель конца игрового процесса
        private bool[,] mass = new bool[50, 50]; //массив значений мертвый-живой для ячеек игрового поля
        private bool[,] tempmass = new bool[50, 50]; // Массив временных значений
        private Button[,] massbut = new Button[50, 50]; // Массив кнопок-ячеек игрового поля
        private int generation = 0; //Счетчик поколений
        public Form1()
        {
            InitializeComponent();
            //создаем игровое поле
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    massbut[i, j] = new Button();
                    massbut[i, j].Size = new Size(10, 10);
                    massbut[i, j].Location = new Point(i * 10 + i * 3 + 30, j * 10 + j * 3 + 30);
                    massbut[i, j].Click += new System.EventHandler(this.massbutClick);
                    massbut[i, j].Tag = new Coords(i, j); // .Tag для привязки кнопок-ячеек к массиву значений мертвый-живой  
                    massbut[i, j].FlatStyle = FlatStyle.Flat;
                    this.Controls.Add(massbut[i, j]);
                }
            }

            NewLife();
        }

        //Нажатием на кнопки-ячейки задаем первоначальное расположение особей
        private void massbutClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Coords co = (Coords)btn.Tag;
            btn.BackColor = Color.White;
            mass[co.i, co.j] = true;
        }

        //Нажатие кнопки GO запускаем игровой процесс в отдельном потоке
        private void butnGoClick(object sender, EventArgs e)
        {
            Thread LifeThread = new Thread(GoLife);
            LifeThread.Start();
        }
        //нажатием кнопки Clear устанавливаем переключатель конца игрового процесса
        private void butnClearClick(object sender, EventArgs e)
        {
            stopflag = true;
        }
        //Начало новой игры
        private void NewLife()
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    mass[i, j] = false;
                    tempmass[i, j] = false;
                    massbut[i, j].BackColor = Color.Black;
                }
            }
            generation = 0;
            label1.Text = string.Empty;
            this.Refresh();
        }
        //метод выполняется в отдельном потоке, вызываем метод генерации нового поколения 
        //и проверяем состояние переключателя конца процесса
        private void GoLife()
        {
            for (int i = 0; i < 100; i++)
            {
                NextGeneration();
                generation++;
                label1.Text = generation.ToString();
                this.Refresh();
                if (stopflag) { i = 100; }
            }
            if (stopflag) { stopflag = false; NewLife(); }
        }
        //Генерирует новое поколение
        public void NextGeneration()
        {
            this.SuspendLayout();

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    if ((sosediCount(i, j) == 3) && (!mass[i, j])) { tempmass[i, j] = true; }
                    if (((sosediCount(i, j) == 3) || (sosediCount(i, j) == 2)) && (mass[i, j])) { tempmass[i, j] = true; }
                    if ((sosediCount(i, j) < 2) && (mass[i, j])) { tempmass[i, j] = false; }
                    if ((sosediCount(i, j) > 3) && (mass[i, j])) { tempmass[i, j] = false; }
                }
            }
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    mass[i, j] = tempmass[i, j];
                    if (mass[i, j]) { massbut[i, j].BackColor = Color.White; } else { massbut[i, j].BackColor = Color.Black; }
                }
            }
            this.ResumeLayout();

        }
        //функция расчета количества соседей у особи
        private int sosediCount(int a, int b)
        {
            int sosedi = 0;
            if (a > 0 && mass[a - 1, b]) { sosedi++; }
            if (a > 0 && b < 49 && mass[a - 1, b + 1]) { sosedi++; }
            if (b < 49 && mass[a, b + 1]) { sosedi++; };
            if (a < 49 && b < 49 && mass[a + 1, b + 1]) { sosedi++; }
            if (a < 49 && mass[a + 1, b]) { sosedi++; }
            if (a < 49 && b > 0 && mass[a + 1, b - 1]) { sosedi++; }
            if (b > 0 && mass[a, b - 1]) { sosedi++; }
            if (a > 0 && b > 0 && mass[a - 1, b - 1]) { sosedi++; }
            return sosedi;
        }
    }
    //класс объектов, хранящих индексы массива для Button.Tag
    public class Coords
    {
        private int _i;
        private int _j;
        public int i
        {
            get { return _i; }
            set { _i = i; }
        }
        public int j
        {
            get { return _j; }
            set { _j = j; }
        }
        public Coords(int a, int b)
        {
            _i = a; _j = b;
        }

    }
}

