using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Security.Cryptography.Pkcs;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDesignPractice
{
    public partial class areaHive : Form
    {
        int[] beeID = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        public int[] itemID = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        //1 = closed, 0 is open

        int isclosed;
        public static areaHive instance;
        public Label totalHoneyHive;
        public Label totalPollenHive;
        int ItemUseAmount = 1;
        //Hive Image Array
        PictureBox[] boxes;
        PictureBox[] items;
        Label[] itemAmt;
        bool[] infoshown = {false,false,false,false,false};
        public areaHive()
        {

            InitializeComponent();

            instance = this;
            //Fills the boxes array with the bee pictureboxes.
            boxes = new PictureBox[] { b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12 };
            //fills the items array
            items = new PictureBox[] { i1, i2, i3, i4, i5, i6, i7, i8, i9 };
            //handles the label text
            itemAmt = new Label[] { lb1, lb2, lb3, lb4, lb5, lb6, lb7, lb8, lb9 };
            
            this.FormClosed += Form2_FormClosed;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            isclosed = 0;
            Conversion();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            syncDataTwo();
            isclosed = 0;
            hiveUpdate();
            lblItemUseAmt.Text = ItemUseAmount.ToString();
            lbItemUse.Text = "How many items do you \n want to use at once?";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void itemUse_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private async Task Conversion()
        {
            //Create local integer and load it into memory
            int rate = new int();

            //If the total pollen and the bees owned amount are higher than zero, run the code inside the If Statement.
            //Also stops the conversion from running after the window is closed 
            if (areaMain.instance.totalPollenInt >= 1 && areaMain.instance.totalBeeAmount >= 1 && isclosed == 0)
            {
                //Conditional loop, this keeps the code inside going while there's still pollen in your bag until there's zero left.
                while (areaMain.instance.totalPollenInt >= 1 && isclosed == 0)
                {
                    //Creates a new variable that acts as the randomizer
                    Random rnd = new Random();
                    // Creates the integer "num" which takes a random value from 1 to 3
                    // 0000.
                    // This value is later used in the formula for calculating the pollen converted to honey.
                    int num = rnd.Next(1, 300);

                    //Debug feature which will be commented out after i'm finished. Shows the random number generated.
                    //MessageBox.Show("" + num);

                    //Uses the staticConvert variable (Found in form1, right now set at 1) and times it by random number.
                    //This generates the number which will be taken away for converting pollen into honey
                    rate = (areaMain.instance.staticConvert*areaMain.instance.totalBeeAmount)* num * areaMain.instance.totalBeeAmount;

                    //If statement to check if the conversion number generated is less than the total pollen to avoid negative pollen.
                    if (rate <= areaMain.instance.totalPollenInt)
                    {

                        //adds the amount of pollen converted into the total honey variable
                        areaMain.instance.totalHoneyInt += rate;

                        //removes the amount of pollen converted from the total pollen variable
                        areaMain.instance.totalPollenInt -= rate;

                        //calls the data sync function which updates the values between converting 
                        syncDataTwo();
                        await CustomWaitAsync(65);
                    }
                    //Else statement if the conversion number is higher than pollen available
                    else
                    {
                        //honestly i don't care about commenting on these individually, but they convert all the remaining pollen into honey.
                        areaMain.instance.totalHoneyInt += areaMain.instance.totalPollenInt;
                        areaMain.instance.totalPollenInt = 0;
                        syncDataTwo();

                    }




                }
            }

            else
            {
                syncDataTwo();
            }
        }
        //
        public void syncDataTwo()
        {
            if (areaMain.instance.totalHoneyInt < 0)
            {
                areaMain.instance.totalHoneyInt = 2147483647;
            }
            if (areaMain.instance.totalPollenInt < 0)
            {
                areaMain.instance.totalPollenInt = 2147483647;
            }
            totalHoney.Text = Convert.ToString(areaMain.instance.totalHoneyInt);
            totalPollen.Text = Convert.ToString(areaMain.instance.totalPollenInt);
            hiveUpdate();
            areaMain.instance.syncData();

        }
        //Stops hive conversion if hive window is closed during it.
        private void Form2_FormClosed(Object sender, FormClosedEventArgs e)
        {
            isclosed = 1;
        }
        //Creates a timer that later makes conversion take more than 1 second.
        private static async Task CustomWaitAsync(int milliseconds)
        {
            await Task.Run(() => Thread.Sleep(milliseconds));
        }
        
        public void itemAmount()
        {
            int[] itemid = new int[8];

        }
        //All of these are bee slots which change their local id to the ID of the bee.
        private void b1_Click(object sender, EventArgs e)
        {

            int localID = beeID[0];
            beeTransform(ref localID);


        }

        private void b2_Click(object sender, EventArgs e)
        {
            int localID = beeID[1];
            beeTransform(ref localID);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int localID = beeID[2];
            beeTransform(ref localID);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            int localID = beeID[3];
            beeTransform(ref localID);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            int localID = beeID[4];
            beeTransform(ref localID);
        }

        private void b6_Click(object sender, EventArgs e)
        {

            int localID = beeID[5];
            beeTransform(ref localID);
        }

        private void b7_Click(object sender, EventArgs e)
        {

            int localID = beeID[6];
            beeTransform(ref localID);
        }

        private void b8_Click(object sender, EventArgs e)
        {

            int localID = beeID[7];
            beeTransform(ref localID);
        }

        private void b9_Click(object sender, EventArgs e)
        {

            int localID = beeID[8];
            beeTransform(ref localID);
        }

        private void b10_Click(object sender, EventArgs e)
        {
            //Change the localID to the ID of the 9th bee to make it simpler to work with the value in later code.
            int localID = beeID[9];
            //Call the beeTransform subprogram and reference localID into it
            beeTransform(ref localID);
        }

        private void b11_Click(object sender, EventArgs e)
        {
            int localID = beeID[10];
            beeTransform(ref localID);
        }

        private void b12_Click(object sender, EventArgs e)
        {

            int localID = beeID[11];
            beeTransform(ref localID);
        }
        //This generates a random value and calls for the subprogram responsible for choosing a random bee.
        public void randomBee(ref int localID)
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 1000000);
            weLoveGambling(ref chance, ref localID);
        }
        //Subprogram responsible for choosing a random bee.
        private void weLoveGambling(ref int chance, ref int localID)
        {
            if (chance == 0)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/0.png");
                areaMain.instance.beeType[localID] = 0;
                areaMain.instance.beeColour[localID] = "EMPTY";
            }

            //1
            if (chance > 0 && chance < 325000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/1.png");
                areaMain.instance.beeType[localID] = 1;
                areaMain.instance.beeColour[localID] = "None";


            }
            //2
            else if (chance >= 325000 && chance < 350000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/2.png");
                areaMain.instance.beeType[localID] = 2;
                areaMain.instance.beeColour[localID] = "None";
            }
            //3
            else if (chance >= 350000 && chance < 550000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/3.png");
                areaMain.instance.beeType[localID] = 3;
                areaMain.instance.beeColour[localID] = "Blue";

            }
            //4
            else if (chance >= 550000 && chance < 575000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/4.png");
                areaMain.instance.beeType[localID] = 4;
                areaMain.instance.beeColour[localID] = "Blue";
            }
            //5
            else if (chance >= 575000 && chance < 775000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/5.png");
                areaMain.instance.beeType[localID] = 5;
                areaMain.instance.beeColour[localID] = "Red";
            }
            //6
            else if (chance >= 775000 && chance < 800000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/6.png");
                areaMain.instance.beeType[localID] = 6;
                areaMain.instance.beeColour[localID] = "Red";
            }
            //7
            else if (chance >= 800000 && chance < 825000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/7.png");
                areaMain.instance.beeType[localID] = 7;
                areaMain.instance.beeColour[localID] = "Blue";
            }
            //8
            else if (chance >= 825000 && chance < 1000000)
            {
                boxes[localID].Image = Image.FromFile("Images/bees/8.png");
                areaMain.instance.beeType[localID] = 8;
                areaMain.instance.beeColour[localID] = "Red";
            }

        }
        //Called by b1-b12, this is what is responsible for all the hive slots. 
        //Fun fact: this could've been 96 "if" statements if i didnt find a better way to do this.
        private void beeTransform(ref int localID)
        {
            
            //Check if the bee slot is unlocked and there's enough royal jelly to transform a bee.
            if (areaMain.instance.itemTypeAmount[1] >= 1 && areaMain.instance.totalBeeAmount > localID)
            {
                //Remove a royal jelly from the inventory
                areaMain.instance.itemTypeAmount[1] -= 1;
                
                //Call the randomBee subprogram to generate a random bee for the clicked slot.
                randomBee(ref localID);
                
            }
            //responsible for playing the sound when a bee slot is clicked.
            SoundPlayer ss = new SoundPlayer(@"Images/audio/snd_jellyUse.wav");
            ss.Play();
            hiveUpdate();


        }
        //Updates the images of the bees and items in the hive.
        private void hiveUpdate()
        {
            
            for (int i = 0; i < boxes.Length; i++)
            {

                if (areaMain.instance.totalBeeAmount <= i)
                {
                    boxes[i].Image = Image.FromFile("Images/bees/0.png");

                }
                else
                {
                    boxes[i].Image = Image.FromFile("Images/bees/" + (areaMain.instance.beeType[i]) + ".png");
                    

                }

            }
            ItemUpdate();
        }
        // Changes the items images to their item and shows how many of those items you have in your inventory.
        private void ItemUpdate()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i].Image = Image.FromFile("Images/" + i + ".png");
            }
            for (int i = 0; i < itemAmt.Length; i++)
            {
                itemAmt[i].Text = areaMain.instance.itemTypeAmount[i].ToString();
            }
        }

        //All of these correspon to different items (i1-i9)
        private void i1_Click(object sender, EventArgs e)
        {
            //Ticket.
            MessageBox.Show("This has no use on the hive :)");
            ItemUpdate();
        }

        private void i2_Click(object sender, EventArgs e)
        {
            //Check if an informational message box is shown.
            
            
            //Royal Jelly. 
            MessageBox.Show("Click on a bee to use :D");

            if (infoshown[0] == false )
            {
                MessageBox.Show("Did you know that royal jelly is a real substance that bees feed a larvae for its entire life to make another queen?");
                infoshown[0] = true;
            }

            ItemUpdate();
        }

        private void i3_Click(object sender, EventArgs e)
        {
            
            //Use a blueberry. 



            if (areaMain.instance.itemTypeAmount[2] >= ItemUseAmount)
            {
                areaMain.instance.itemTypeAmount[2] -= ItemUseAmount;
                    areaMain.instance.pollenMult[0] += (0.01*ItemUseAmount);
                
            }

            if (infoshown[1] == false)
            {
                MessageBox.Show("Did you know that blueberries are rich in vitamin C, vitamin K and fiber? Also, They're not even really blue!");
                infoshown[1] = true;
            }
            ItemUpdate();
        }

        private void i4_Click(object sender, EventArgs e)
        {
            
            //Use a Sunflower Seed. 
            if (areaMain.instance.itemTypeAmount[3] >= ItemUseAmount)

            {
                areaMain.instance.itemTypeAmount[3] -= ItemUseAmount;
                areaMain.instance.pollenMult[2] += (0.01 * ItemUseAmount);
                
            }

            if (infoshown[2] == false)
            {
                MessageBox.Show("Did you know that sunflower seeds are rich in Vitamin E and protein? They even have copper! ");
                infoshown[2] = true;
            }
            ItemUpdate();
        }

        private void i5_Click(object sender, EventArgs e)
        {
            
            //Use a Strawberry. 
            if (areaMain.instance.itemTypeAmount[4] >= ItemUseAmount)
            {
                areaMain.instance.itemTypeAmount[4] -= ItemUseAmount;
                areaMain.instance.pollenMult[1] += (0.01+ItemUseAmount);
            }

            if (infoshown[3] == false)
            {
                MessageBox.Show("Did you know that strawberries are highly nutritious and have a ton of vitamin C? Also, they aren't even berries!!");
                infoshown[3] = true;
            }
            ItemUpdate();
        }

        private void i6_Click(object sender, EventArgs e)
        {
            
            //Use a croissant. 
            if (areaMain.instance.itemTypeAmount[5] >= ItemUseAmount)
            {
                areaMain.instance.itemTypeAmount[5] -= ItemUseAmount;
                areaMain.instance.pollenMult[3] += (0.01 * ItemUseAmount);
            }

            if (infoshown[4] == false)
            {
                MessageBox.Show("Croissants are a yummy treat, but having too many probably isn't healthy. ");
                infoshown[4] = true;
            }
            ItemUpdate();
        }

        private void i7_Click(object sender, EventArgs e)
        {
            //Switch the tool to the shovel
            if (areaMain.instance.itemTypeAmount[6] > 0)
            {
                areaMain.instance.toolEquipped = 1;
            }
            ItemUpdate();
        }

        private void i8_Click(object sender, EventArgs e)
        {
            //Switch tool to trash picker
            if (areaMain.instance.itemTypeAmount[7] > 0)
            {
                areaMain.instance.toolEquipped = 2;
            }
            ItemUpdate();
        }

        private void i9_Click(object sender, EventArgs e)
        {
            //switch tool to vacuum
            if (areaMain.instance.itemTypeAmount[8] > 0)
            {
                areaMain.instance.toolEquipped = 3;
            }
            ItemUpdate();
        }
        //Lowers the amount of items used upon consuming them
        private void btnLess_Click(object sender, EventArgs e)
        {
            if (ItemUseAmount >1) 
            {
                ItemUseAmount -= 1;
                lblItemUseAmt.Text= ItemUseAmount.ToString();
            }
        }
        //Heightens the number of items used upon consuming them.
        private void btnMore_Click(object sender, EventArgs e)
        {
            if (ItemUseAmount < 21473836447) 
            {
                ItemUseAmount += 1;
                lblItemUseAmt.Text = ItemUseAmount.ToString();
            }
        }
        //Resets the item used value to 1 in case you go too high.
        private void btnReset_Click(object sender, EventArgs e)
        {
            ItemUseAmount = 1;
            lblItemUseAmt.Text = ItemUseAmount.ToString();
        }
    }


}












