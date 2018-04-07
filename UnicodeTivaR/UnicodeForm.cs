using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 06-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Unicode
 * This program when start is clicked will display...
 * ... all of the letters corresponding to their numbers.
*/

namespace UnicodeTivaR
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Decalre variables
            string character;
            int counter;

            // Clearing items in list box
            this.lstDisplayLetters.Items.Clear();

            // Loop from A (65) to Z (90)
            for (counter = 65; counter <= 90; counter++)
            {
                character = Char.ConvertFromUtf32(counter);

                // Display the letter 
                this.lstDisplayLetters.Items.Add(character + " ->" + counter);
            }
        }
    }
}
