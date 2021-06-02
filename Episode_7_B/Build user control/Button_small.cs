using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRO_QR.Controls
{
    public partial class Button_small : UserControl
    {
        public Button_small()
        {
            InitializeComponent();
        }

        private string _title;
        private string _message;
        private Image _icon;

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; _Pic.Image = value; }
        }

        [Category("Custom Props")]
        public string Message
        {
            get { return _message; }
            set { _message = value; lblMessage.Text = value; }
        }
        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        public event EventHandler Clicked;
        /// <summary>
        /// Called to signal to subscribers that UserControl Button Clicked
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler eh = Clicked;
            if (eh != null)
            {
                eh(this, e);
            }
        }
        private void Lastiteam_Load(object sender, EventArgs e)
        {
        }

        public void Items_Click(object sender, EventArgs e)
        {
            OnClicked(e);
        }
    }
}
