using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormRegistr : Form
    {
        public string РезультатРегистрации { get; private set; } // Объявление переменной для результата регистрации

        public FormRegistr()
        {
            InitializeComponent();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            string новыйЛогин = textBoxЛогин.Text;
            string новыйПароль = textBoxПароль.Text;
            string типПользователя = "Пациент"; // Устанавливаем тип пользователя на "пациент"

            using (var db = new PoliklinikaEntities())
            {
                // Проверка на существование пользователя с таким логином
                var existingUser = db.Users.FirstOrDefault(u => u.Логин == новыйЛогин);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }

                // Создаем нового пользователя и добавляем его в базу данных
                var newUser = new Users
                {
                    Логин = новыйЛогин,
                    Пароль = новыйПароль,
                    Тип = типПользователя
                };

                db.Users.Add(newUser);
                db.SaveChanges();
                РезультатРегистрации = "Регистрация прошла успешно!";

                MessageBox.Show(РезультатРегистрации); // Выводим сообщение об успешной регистрации

                Form1 form1 = new Form1();
                this.Visible = false; // Скрываем текущую форму
                form1.Show();
            }

            this.Close(); // Закрываем форму регистрации после регистрации пользователя
        }

        private void FormRegistr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.poliklinikaDataSet.Users);

        }
    }
}



