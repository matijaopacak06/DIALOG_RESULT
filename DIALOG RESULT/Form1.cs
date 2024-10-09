using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIALOG_RESULT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOtvori_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("DA/ NE / CANCEL", "upit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            switch (DialogResult)
            {
                case DialogResult.Yes:
                    textBoxRezultat.AppendText("kliknuli ste DA.\n");
                    break;
                case DialogResult.No:
                    textBoxRezultat.AppendText("Kliknuli ste NE.\n");
                    break;
                case DialogResult.Cancel:
                    textBoxRezultat.AppendText("Kliknuli ste Cancel.\n");
                    break;
            }
        }

    }
}
