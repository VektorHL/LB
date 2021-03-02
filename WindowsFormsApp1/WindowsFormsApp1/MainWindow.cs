using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            names_comboBox.Text = "ФИО";
            names_comboBox.ForeColor = Color.Gray;

            rooms_comboBox.Text = "Помещение";
            rooms_comboBox.ForeColor = Color.Gray;
   
        }
       
        //protected override bool ScaleChildren => false;


        //таблица для удобства вёрстки
        private void MainWindow_tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void moves_label_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
