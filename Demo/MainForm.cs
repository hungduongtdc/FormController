using DataEditor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var config = new DataEditorFormConfiguration();
            DataEditorForm dataEditorForm = new DataEditorForm(config);
            this.Hide();
            dataEditorForm.Show();
            this.Show();
        }
    }
}
