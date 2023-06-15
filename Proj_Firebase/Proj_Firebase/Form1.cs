using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Proj_Firebase
{
    
    public partial class Form1 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "QTNP2hStdWbbdDWnW6AcFJbldHVQ8wWkKWA9eb6G",
            BasePath = "https://projectfirebasewforms-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config); 
                if(client != null)
            {
                lblConnStatus.Text = "Connected";
            }

        }
    }
}
