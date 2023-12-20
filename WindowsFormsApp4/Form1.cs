using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string ПолучитьТипПользователя(string логин, string пароль)
        {
            using (var db = new PoliklinikaEntities())
            {
                var пользователь = db.Users.FirstOrDefault(u => u.Логин == логин && u.Пароль == пароль);
                if (пользователь != null)
                {
                    return пользователь.Тип;
                }
            }
            return null;
        }

        private void buttonReg_Click_1(object sender, EventArgs e)
        {
            FormRegistr formRegistr = new FormRegistr();
            this.Hide();
            formRegistr.Show();

            // После закрытия формы регистрации получаем результат регистрации
            string результатРегистрации = formRegistr.РезультатРегистрации;

            // Проверяем результат регистрации
            if (!string.IsNullOrEmpty(результатРегистрации))
            {
                MessageBox.Show(результатРегистрации);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string введенныйЛогин = textBoxлв.Text;
            string введенныйПароль = textBoxпв.Text;

            string типПользователя = ПолучитьТипПользователя(введенныйЛогин, введенныйПароль);

            if (типПользователя == "Врач")
            {
                MessageBox.Show("Вы вошли как врач!");
                FormDoctor formDoctor = new FormDoctor(); // Создаем экземпляр формы для врачей
                formDoctor.Show(); // Показываем форму для врачей
                this.Hide(); // Скрываем текущую форму
            }
            else
            {
                MessageBox.Show("Ошибка аутентификации врача!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string введенныйЛогин = textBoxлп.Text;
            string введенныйПароль = textBoxпп.Text;

            string типПользователя = ПолучитьТипПользователя(введенныйЛогин, введенныйПароль);

            if (типПользователя == "Пациент")
            {
                MessageBox.Show("Вы вошли как пациент!");
                FormPatient formPatient = new FormPatient(); // Создаем экземпляр формы для пациентов
                formPatient.Show(); // Показываем форму для пациентов
                this.Hide(); // Скрываем текущую форму
            }
            else
            {
                MessageBox.Show("Ошибка аутентификации пациента!");
            }
        }

        private void textBoxлв_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

