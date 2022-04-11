using System;
using System.Drawing;

namespace XboxKeyboardMouse.Forms.Controls
{
    public partial class FormRWE : RoundedForm
    {
        public FormRWE()
        {
            InitializeComponent();
        }

        // Called to change status color's
        public virtual void SetStatusColor(Color c) { }

        private void FormRWE_Load(object sender, EventArgs e)
        {

        }
    }
}
