using System;
using System.Windows.Forms;

namespace TodoAppCS
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            dataview.Rows.Add(nombre.Text, text.Text);
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (dataview.CurrentRow != null)
            {
                dataview.Rows.RemoveAt(dataview.CurrentRow.Index);
            }
        }
    }
}