using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_PrototipoMenu
{
    public partial class Mantenimiento : Form
    {
        Controlador cn = new Controlador();
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1005";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txt_codpuesto, txt_nompuesto, txt_status };
            TextBox[] Idtextbox = { txt_codpuesto, txt_nompuesto };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "AyudaParciales/AyudasFinal.chm", "Mantenimientos.html");
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reportes form1 = new Reportes();
            form1.Show();
        }
    }
}
