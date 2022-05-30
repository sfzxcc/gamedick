﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_forest_Match3
//Суть игры
{
    public partial class Form5 : Form
    {

        public Form3 frm3; //объявляем Form3 и даем ей имя frm3

        Bitmap Pict; //переменная для рисунка
        Graphics g; //графическая поверхность для рисунка

        SolidBrush my_brush = new SolidBrush(Color.DeepPink); //цвет текста
        Font my_font = new Font("Arial", 14, FontStyle.Bold); //шрифт текста

        public Form5()
        {
            InitializeComponent();
            g = this.CreateGraphics(); //создаем поверхность
            this.Width = 1024;
            this.Height = 576;
        }

        
        public void file_to_form1() //функция для чтения текста из файла
        {
            string s;

            //string fname = "G:/Базовый проект/Игра/Тернистый путь Егора Крида/помощь и правила игры.txt"; //для колледжа
            string fname = "D:/text/sut.txt"; //для дома

            // string fileText = File.ReadAllText(fname);
            StreamReader f = new StreamReader(fname); //используется для чтения данных из файла

            int x = 10;
            int y = 15;
            while ((s = f.ReadLine()) != null) //читаем построчно, пока не встретим признак конца файла
            {
                g.DrawString(s, my_font, my_brush, x, y);
                y = y + 35;
            }
            f.Close();
        }

        //Отвечает за фон и указатели
        private void Form5_Load(object sender, EventArgs e)
        {
            Pict = new Bitmap("D:/pict/суть.jpg"); //для дома
            g.DrawImage(Pict, 0, 0, Pict.Width, Pict.Height);
            file_to_form1();
        }


        private void Form5_Paint(object sender, PaintEventArgs e)
        {

            Pict = new Bitmap("D:/pict/суть.jpg"); //для дома
            g.DrawImage(Pict, 0, 0, Pict.Width, Pict.Height);
            file_to_form1();
        }

        //Назад
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); //прячем форму 5
            frm3.Show(); //показывем форму 3
        }
    }
}
