using System;
using System.Windows.Forms;

namespace MainApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShowNofication_Click(object sender, EventArgs e)
        {
            notifyIcon1.Text = "SolveEverything.exe";
            //just set the icon, what?
            notifyIcon1.Icon = new System.Drawing.Icon(Application.StartupPath + @"\..\..\..\..\banner - small.ico");
            notifyIcon1.ShowBalloonTip(5000, "Notification", "Thanks! for watching SolveEverything.exe videos", ToolTipIcon.Info);
        }
        //It works
    }
}
