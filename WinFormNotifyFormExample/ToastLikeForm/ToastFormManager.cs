using System;
using System.Drawing;
using System.Windows.Forms;

namespace case_of_t.ToastLikeForm
{ 
    /// <summary>
    /// Class for Instanciate and show ToastLikeForm
    /// </summary>
    public class ToastFormManager : IDisposable
    {
        ToastLikeForm f;

        public void Dispose()
        {
            try
            {
                f.FormClosed -= OnToastFormClosed;
                f?.Dispose();
                f = null;
            }
            catch { }

            if (ToastFormClosed != null)
            {
                ToastFormClosed = null;
            }
        }

        public void Toast(string title, string message, bool asError)
        {
            f = new ToastLikeForm();
            f.FormBorderStyle = FormBorderStyle.None;
            f.ShowInTaskbar = false;

            var primeScrBounds = Screen.PrimaryScreen.WorkingArea;

            var x = primeScrBounds.X + primeScrBounds.Width - f.Width;
            var y = primeScrBounds.Y + primeScrBounds.Height - f.Height;

            f.Location = new Point(x, y);
            f.Title = title;
            f.Message = message;
            f.AsError = asError;


            f.Show();
            f.Refresh();

            f.FormClosed += OnToastFormClosed;
        }

        private void OnToastFormClosed(object sender, EventArgs e)
        {
            var tfc = ToastFormClosed;
            tfc?.Invoke(this, EventArgs.Empty);
        }

        public EventHandler<EventArgs> ToastFormClosed;
    }
}
