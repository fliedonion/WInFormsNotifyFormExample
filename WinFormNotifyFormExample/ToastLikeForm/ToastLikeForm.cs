using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace case_of_t.ToastLikeForm
{
    public partial class ToastLikeForm : Form
    {
        protected override bool ShowWithoutActivation => true;

        [DllImport("User32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        private void BringToFrontWithoutActivation()
        {
            Process currentProcess = Process.GetCurrentProcess();
            IntPtr hWnd = currentProcess.MainWindowHandle;
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
            }
        }

        public ToastLikeForm()
        {
            InitializeComponent();
            offsetX = Width;
        }


        private int keepDisplayMilliSec = 2500;
        private int timerInterval = 50;

        private int offsetX = 0;
        private int slideStep = 50;


        public string Message { get => messageLabel.Text; set => messageLabel.Text = value ?? ""; }
        public string Title { get => titleLabel.Text; set => titleLabel.Text = value ?? ""; }

        private Color errorTextColor = Color.Red;
        public bool AsError { 
            get => messageLabel.ForeColor == errorTextColor; 
            set => messageLabel.ForeColor = value ? errorTextColor : SystemColors.WindowText; }


        private void ToastLikeForm_Load(object sender, EventArgs e)
        {
            Left += offsetX;

            animateTimer.Start();
            animateTimer.Interval = timerInterval;
        }

        private void closeFormButton_Click(object sender, EventArgs e)
        {
            animateTimer.Stop();
            Close();
        }



        private void animateTimer_Tick(object sender, EventArgs e)
        {
            BringToFrontWithoutActivation();

            if (offsetX > 0)
            {
                offsetX -= slideStep;
                Left -= slideStep;

                if (offsetX < 0)
                {
                    Left += -offsetX;
                    offsetX = 0;
                }
                return;
            }


            if (keepDisplayMilliSec > 0)
            {
                keepDisplayMilliSec -= animateTimer.Interval;
                return;
            }

            if (Opacity > 0)
            {
                Opacity -= 0.1;
            }
            else
            {
                animateTimer.Stop();
                Close();
            }
        }

        private void ToastLikeForm_Shown(object sender, EventArgs e)
        {
            animateTimer.Enabled = true;
            animateTimer.Start();
        }
    }
}
