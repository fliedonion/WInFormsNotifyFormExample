using case_of_t.ToastLikeForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace case_of_t.WinFormNotifyFormExample
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tm = new ToastFormManager();

            tm.Toast(titleText.Text, messageText.Text, asErrCheck.Checked);

            tm.ToastFormClosed += (s, ev) => Text = $"Toast Finished {DateTime.Now}";
        }
    }
}
