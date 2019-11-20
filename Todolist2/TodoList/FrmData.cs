using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoData1
{
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }

        private void FrmData_Load(object sender, EventArgs e)
        {
            //para mostrar el form data en el centro como el padre (main form)
            this.CenterToParent();
            
        }
    }
}
