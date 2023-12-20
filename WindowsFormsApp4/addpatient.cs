using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class addpatient : Form
    {
        public addpatient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addpatient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter.Fill(this.poliklinikaDataSet.Patients);

        }

        private int ПолучитьНовыйIDПациента()
        {
            using (var db = new PoliklinikaEntities())
            {
                // Получаем максимальное значение ID_пациента из базы данных и увеличиваем на 1
                var maxPatientId = db.Patients.Max(p => (int?)p.ID_пациента) ?? 0;
                return maxPatientId + 1;
            }
        }

        private void ДобавитьПациента(string имя, string фамилия, string адрес, string номерТелефона, DateTime датаРождения, int idУчастка, string паспортныеДанные, string пол)
        {
            using (var db = new PoliklinikaEntities())
            {
                // Получаем новый уникальный ID_пациента
                int новыйID = ПолучитьНовыйIDПациента();

                var newPatient = new Patients
                {
                    ID_пациента = новыйID, // Устанавливаем новый ID
                    Имя = имя,
                    Фамилия = фамилия,
                    Адрес = адрес,
                    Номер_телефона = номерТелефона,
                    Дата_рождения = датаРождения,
                    ID_участка = idУчастка,
                    Паспортные_данные = паспортныеДанные, // Добавляем информацию о паспортных данных
                    Пол = пол // Добавляем информацию о поле
                };

                db.Patients.Add(newPatient);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Пациент успешно добавлен! ID пациента: " + новыйID);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show("Ошибка при добавлении пациента: " + ex.Message);
                }
            }
        }


        private void buttonДобавитьПациента_Click(object sender, EventArgs e)
        {
            string имя = textBoxИмя.Text;
            string фамилия = textBoxФамилия.Text;
            string адрес = textBoxАдрес.Text;
            string номерТелефона = textBoxНомерТелефона.Text;
            string пол = textBoxПол.Text;
            string паспортныеДанные = textBoxПаспортныеДанные.Text;
            DateTime датаРождения = dateTimePickerДата.Value;

            // Получаем выбранный или введенный ID участка
            int idУчастка;
            if (!int.TryParse(comboBoxУчасток.Text, out idУчастка))
            {
                MessageBox.Show("Введите корректный ID участка!");
                return;
            }

            ДобавитьПациента(имя, фамилия, адрес, номерТелефона, датаРождения, idУчастка, пол, паспортныеДанные); // Передаем значение паспортных данных методу ДобавитьПациента
        }

        private int ПолучитьНовыйIDВрача()
        {
            using (var db = new PoliklinikaEntities())
            {
                var maxDoctorId = db.Doctors.Max(d => (int?)d.ID_врача) ?? 0;
                return maxDoctorId + 1;
            }
        }

        private void ДобавитьВрача(string имя, string фамилия, string специализация, string инн)
        {
            using (var db = new PoliklinikaEntities())
            {
                int новыйID = ПолучитьНовыйIDВрача();

                var newDoctor = new Doctors
                {
                    ID_врача = новыйID,
                    Имя = имя,
                    Фамилия = фамилия,
                    Специализация = специализация,
                    ИНН = инн
                };

                db.Doctors.Add(newDoctor);

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Врач успешно добавлен! ID врача: " + новыйID);
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
                {
                    MessageBox.Show("Ошибка при добавлении врача: " + ex.Message);
                }
            }
        }

        private void buttonДобавитьВрача_Click(object sender, EventArgs e)
        {
            string имя = textBoxИмяВрача.Text;
            string фамилия = textBoxФамилияВрача.Text;
            string специализация = textBoxСпециализацияВрача.Text;
            string инн = textBoxИННВрача.Text; // Получаем значение ИНН

            ДобавитьВрача(имя, фамилия, специализация, инн); // Передаем значение ИНН методу ДобавитьВрача
        }

    }
}
