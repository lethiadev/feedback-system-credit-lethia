using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static welk.Http;

namespace welk
{
    public partial class feedback : UserControl
    {
        public feedback()
        {
            InitializeComponent();
        }

        private void username_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        public static void sendwebhook(string Url, string msg, string username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
            {
                    "username",
                    username
            },
            {
                "content",
                msg
            }
            });

        }

        private void feedback_Load(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = User.Username + " | Feedback System";
            welcome.Text = "Welcome back, " + User.Username + "!";
            username.Text = ""; //WEBHOOK URL HERE
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            sendwebhook(username.Text, bunifuMaterialTextbox2.Text, bunifuMaterialTextbox1.Text);
            bunifuMaterialTextbox2.Text = "";
        }
    }
}
