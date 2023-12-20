using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class RecordAppointmentForm : Form
    {
        public RecordAppointmentForm()
        {
            InitializeComponent();

            dateTimePickerДата.Format = DateTimePickerFormat.Custom;
            dateTimePickerДата.CustomFormat = "dd/MM/yyyy HH:mm"; // Формат даты и времени
        }

        private void buttonЗаписать_Click(object sender, EventArgs e)
        {
            using (var db = new PoliklinikaEntities())
            {
                var patients = db.Patients.ToList();
                comboBoxПациент.ValueMember = "ID_пациента"; // Замените на свойство, которое содержит ID пациента

                var doctors = db.Doctors.ToList();
                comboBoxВрач.ValueMember = "ID_врача"; // Замените на свойство, которое содержит ID врача
            }

            int idПациента = (int)comboBoxПациент.SelectedValue;
            int idВрача = (int)comboBoxВрач.SelectedValue;
            DateTime датаВремя = dateTimePickerДата.Value;

            using (var db = new PoliklinikaEntities())
            {
                var maxAppointmentId = db.Appointments.Max(a => (int?)a.ID_записи) ?? 0;
                var appointment = new Appointments
                {
                    ID_записи = maxAppointmentId + 1,
                    ID_пациента = idПациента,
                    ID_врача = idВрача,
                    Дата_и_время_приема = датаВремя
                };

                db.Appointments.Add(appointment);
                db.SaveChanges();

                MessageBox.Show("Запись приема сохранена успешно!");
            }
        }

        private void RecordAppointmentForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet3.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter1.Fill(this.poliklinikaDataSet3.Doctors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet3.Patients". При необходимости она может быть перемещена или удалена.
            this.patientsTableAdapter1.Fill(this.poliklinikaDataSet3.Patients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet3.Appointments". При необходимости она может быть перемещена или удалена.
            this.appointmentsTableAdapter1.Fill(this.poliklinikaDataSet3.Appointments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet.Appointments". При необходимости она может быть перемещена или удалена.
            this.appointmentsTableAdapter.Fill(this.poliklinikaDataSet.Appointments);

        }
    }
}
