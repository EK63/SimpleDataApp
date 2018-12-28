using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleDataApp
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // Defining the splash screen parameters
            // Splash screen is dependent on the back ground image size

            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = this.BackgroundImage.Width;
            this.Height = this.BackgroundImage.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Time is defined under timer properties> interval
            // Under the Program namespace you define the sequence of the forms to be opened.
            // Since the NewCustomer and FillOrCancel forms are user driven you do not need to define them
            // 1. Application run is splash screen and after the time has expired the window will close and
            // 2. Applcation is opened.
            // Application.Run(new SplashScreen());
            // Application.Run(new Navigation());

            timer1.Start();
            this.Close();
        }
    }
}
