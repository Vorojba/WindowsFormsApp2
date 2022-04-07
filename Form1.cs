using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Moduls;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    }      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public static Form1 FORMA { get; set; }
        public static User USER { get; set; }
        moduls db = new moduls();
        private void button1_Click(object sender, EventArgs e)
        {
            // проверяем, что в текстовые поля введены данные
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            // создаем объект, соответствующий базе данных
            // ищем запись пользователя с введенным логином
            User usr = db.Users.Find(textBox1.Text);
            // если такой пользователь есть и его пароль правильный
            if ((usr != null) && (usr.psw == textBox2.Text))
            {
                //  сохраняем данные пользователя в статической переменной
                //  для использования данных пользователя в других формах
                USER = usr;
                //  сохраняем ссылку на данную форму в статической переменной
                //  для возврата к этой форме      
                FORMA = this;
                // если роль = «Директор», то вызываем его форму
                if (usr.role == "Директор")
                {
                    // создаем форму директора
                    Form2 frm = new Form2();
                    // показываем форму директора
                    frm.Show();
                    //  форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                else if (usr.role == "Менеджер")
                {
                    // создаем форму директора
                    Form3 frm = new Form3();
                    // показываем форму менеджера
                    frm.Show();
                    //  форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
            }
            else
            {
                // если данные введены не правильно, то показываем сообщение
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                return;
            }
        }
        // метод показа формы Регистрации
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            // сохраняем ссылку на текущую форму
            FORMA = this;
            // текущую форму прячем 
            this.Hide();
            f.Show();
        }
        // метод показа формы Регистрации
        private void button1_Click(object sender, EventArgs e)
        {
            // закрываем первую форму
            this.Close();

            // или можно по другому
            // Application.Exit();
        }

    }
}
