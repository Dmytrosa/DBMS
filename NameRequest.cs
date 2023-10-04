using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyDBSM
{
    public partial class NameRequest : Form
    {
        public string NewName { get; private set; }
        public NameRequest()
        {
            InitializeComponent();
        }

        private void NameRequest_Load(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            NewName = nameTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
