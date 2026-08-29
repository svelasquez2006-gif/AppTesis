using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class FormEmpresasSubcontratadas : Form
    {
        public FormEmpresasSubcontratadas()
        {
            InitializeComponent();
        }

        private void FormEmpresasSubcontratadas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.EmpresasSubcontratada' Puede moverla o quitarla según sea necesario.
            this.empresasSubcontratadaTableAdapter.Fill(this.dataBaseDataSet.EmpresasSubcontratada);

        }
    }
}
