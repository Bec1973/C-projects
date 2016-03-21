using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgAct28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Global variable to end loop
        bool endLoop = true;

        private void btnStart_Click(object sender, EventArgs e)
        {
            int counter = 0;
            listOutput.Items.Clear();

            while(endLoop)
            {
                counter++;
                listOutput.Items.Insert(0, "Loop number " + counter);
                Application.DoEvents();
                // requires System.Threading libraries
                System.Threading.Thread.Sleep(500);

            }
            endLoop = true;
        } // end of btnStart_Click
        private void btnStop_Click(object sender, EventArgs e)
        {
            endLoop = false;
            listOutput.Items.Insert(0, "Loop stopped");
        } // end of btnStop_Click
    }
}
