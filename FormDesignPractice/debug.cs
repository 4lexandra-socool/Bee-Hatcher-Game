using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDesignPractice
{
    public partial class debug : Form
    {
        int robux = 0;

        public debug()
        {
            


            //This is the debug menu used for extensive stress testing of the applications. 
            //Can be accessed in game through modifying the save file's 5th row to 1
            //Save file at c:/bee-hatcher-save/savefile.txt
            //and then click the blue hq closed button.
            InitializeComponent();

            //these things really aren't that important so they aren't commented.
        }

        private void btntriplet_Click(object sender, EventArgs e)
        {
            for (int i = 6; i < 9; i++)
            {
                areaMain.instance.itemTypeAmount[i] += 1;
            }
            areaShop.instance.syncDataThree();
            if (robux == 0)
            {
                //felt like having a bit of fun during the debug creation, this is where you'll see me type things silly out because they don't matter and aren't important to the code or the average user.
                MessageBox.Show("triple t hacked your");
                MessageBox.Show("Sam undertale  stop him ");
                MessageBox.Show("tripe tee apctivates his super spworewer");
                MessageBox.Show("your ar e a blu now");
                MessageBox.Show("tung autobalanced to blu");
                MessageBox.Show("tung: im good god guy no i kill the eivl");
                MessageBox.Show("i am nubby i too am in this peak fiction");
                
                robux = 1;
            }
            else
            {
                MessageBox.Show("wow tung that was a good movie");
                MessageBox.Show("thanks sams");
            }
            
        }

        private void debug_Load(object sender, EventArgs e)
        {

        }

        private void infinitehoney_Click(object sender, EventArgs e)
        {
            areaMain.instance.totalHoneyInt += 1000000000;
            areaShop.instance.syncDataThree();
        }

        private void infinitepolen_Click(object sender, EventArgs e)
        {
            areaMain.instance.totalPollenInt += 1000000000;
            areaShop.instance.syncDataThree();
        }

        private void freeitemrobux_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                areaMain.instance.itemTypeAmount[i] += 1000000;
            }
            areaShop.instance.syncDataThree();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            areaMain.instance.pollenMult[0] += 50;
            areaShop.instance.syncDataThree();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            areaMain.instance.pollenMult[1] += 50;
            areaShop.instance.syncDataThree();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            areaMain.instance.pollenMult[2] += 50;
            areaShop.instance.syncDataThree();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            areaMain.instance.pollenMult[3] += 50;
            areaShop.instance.syncDataThree();
        }
    }
}
