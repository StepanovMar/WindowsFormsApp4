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
    public partial class Formy4astok : Form
    {
        public Formy4astok()
        {
            InitializeComponent();
        }

        private void Formy4astok_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "poliklinikaDataSet3.ClinicDepartments". При необходимости она может быть перемещена или удалена.
            this.clinicDepartmentsTableAdapter.Fill(this.poliklinikaDataSet3.ClinicDepartments);

        }
    }
}
