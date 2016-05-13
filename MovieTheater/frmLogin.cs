using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTheater
{
    public partial class frmLogin : Form
    {
        private const int EM_SETCUEBANNER = 0x1501;
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);

        public frmLogin()
        {
            InitializeComponent();
            SendMessage(txtUserName.Handle, EM_SETCUEBANNER, 0, "UserName");
            SendMessage(txtPassword.Handle, EM_SETCUEBANNER, 0, "PassWord");
        }
    }
}
