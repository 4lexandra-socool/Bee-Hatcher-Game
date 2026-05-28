using System.ComponentModel;
using System.Data;
using System.Media;
using System.Security.Cryptography.Pkcs;
using System.Text;
namespace FormDesignPractice
{
    public partial class areaMain : Form
    {
        string savePath = @"C:\Bee-Hatcher-Save\SaveData.txt";
        public static areaMain instance;
        //All the variables are public because they need to be accessed by every area of the code.
        //True value of honey
        public int totalHoneyInt;
        //True egg cost
        public int EggCost;
        //True total pollen
        public int totalPollenInt;
        //True total amount of bees
        public int totalBeeAmount;
        //Base conversion rate
        public int staticConvert = 1;
        //Bee Type
        public int[] beeType = new int[12];
        //Bee Conversion Amounts
        public int[] beeGather = { 1, 20, 70, 30, 72, 30, 70, 30, 45 };
        //Bee Colour
        public string[] beeColour = new string[12];
        //Items - Read below for information
        //0 - Ticket ||| 1 - Royal Jelly ||| 2 - Blueberry ||| 3 - Sunflower Seed ||| 4 - Strawberry ||| 5 - Croissant
        //6 - Shovel ||| 7 - Trash Picker ||| 8 - Vacuum
        public int[] itemTypeAmount = new int[9];
        //Multiplier - Read below for info
        //0 - Blueberry ||| 1 - Strawberry ||| 2 - Sunflower Seed ||| 3 - Croissant
        public double[] pollenMult = { 1.1, 1.1, 1.1, 1.01 };
        public int toolEquipped;
    





        public Label honey;
        public Label pollen;
        int debugMode = 0;
        public areaMain()
        {





            InitializeComponent();

            instance = this;

            var hiveWindow = new areaHive();
            var shopWindow = new areaShop();
            honey = totalHoney;
            pollen = totalPollen;



            this.FormClosed += Form1_FormClosed;

        }

        private void loadSave()
        {

            //Use the text, which is the file path found in the save path parameter and check if it exists
            if (File.Exists(savePath))
            {

                //Read the textfile within this path.
                TextReader tr = new StreamReader(@"c:\Bee-Hatcher-Save\SaveData.txt");
                //Read the lines in order of the code, placing them into variables.
                string honeyString = tr.ReadLine();
                string pollenString = tr.ReadLine();
                string beeAmountString = tr.ReadLine();
                string eggCostString = tr.ReadLine();
                string debugon = tr.ReadLine();
                //These create their respective amounts of lines, works just fine and immediately
                //converts these strings into the various parts of the array.
                for (int i = 0; i < 12; i++)
                {
                    string beeTypeString = tr.ReadLine();
                    beeType[i] = Convert.ToInt32(beeTypeString);
                }
                for (int i = 0; i < 9; i++)
                {
                    string ItemTypeString = tr.ReadLine();
                    itemTypeAmount[i] = Convert.ToInt32(ItemTypeString);
                }
                for (int i = 0; i < 4; i++)
                {
                    string pollenMultString = tr.ReadLine() ;
                    pollenMult[i] = Convert.ToDouble(pollenMultString);

                }
                
                totalHoneyInt = Convert.ToInt32(honeyString);
                totalPollenInt = Convert.ToInt32(pollenString);
                totalBeeAmount = Convert.ToInt32(beeAmountString);
                EggCost = Convert.ToInt32(eggCostString);
                debugMode = Convert.ToInt32(debugon);
                //Stop the textreader.
                tr.Close();
                //turn the total honey, pollen and bees into the values in the strings.
                

            }
            else
            {

                TextWriter tw = new StreamWriter(@"c:\Bee-Hatcher-Save\SaveData.txt");
                tw.Close();

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadSave();
            totalHoney.Text = totalHoneyInt.ToString();
            totalPollen.Text = totalPollenInt.ToString();
            ttEggShop.AutoPopDelay = 0;
            ttEggShop.InitialDelay = 0;
            ttEggShop.InitialDelay = 0;
            ttEggShop.ShowAlways = true;
            ttEggShop.SetToolTip(this.eggBuyer, "Cost:" + EggCost);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            var hiveWindow = new areaHive();
            hiveWindow.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            //Checks if you have enough honey to buy an egg
            if (totalHoneyInt >= EggCost)
            {
                if (totalBeeAmount < 12)
                {
                    totalBeeAmount += 1;
                    totalHoneyInt -= EggCost;
                    int localID = totalBeeAmount - 1;
                    EggCost += 10 + Convert.ToInt32(EggCost * 2.4);
                    if (localID != 12)
                    {
                        areaHive.instance.randomBee(ref localID);
                    }
                    areaShop.instance.syncDataThree();
                }
            }
            ttEggShop.SetToolTip(this.eggBuyer, "Cost:" + EggCost);

        }
        //sunflower field
        private void button3_Click(object sender, EventArgs e)
        {

            int fieldID = 1;
            pollenCollection(ref fieldID);



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pollenBar_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
        //strawberry field
        private void button1_Click_1(object sender, EventArgs e)
        {
            int fieldID = 2;
            pollenCollection(ref fieldID);


        }

        //Checks if the form is closed, and creates the save file.
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            TextWriter tw = new StreamWriter(@"c:/Bee-Hatcher-Save/SaveData.txt");
            tw.WriteLine(areaMain.instance.totalHoneyInt);
            tw.WriteLine(areaMain.instance.totalPollenInt);
            tw.WriteLine(areaMain.instance.totalBeeAmount);
            tw.WriteLine(EggCost);
            tw.WriteLine(debugMode);
            for (int i = 0; i < 12; i++)
            {
                tw.WriteLine(beeType[i]);
            }
            for (int i = 0; i < 9; i++)
            {
                tw.WriteLine(itemTypeAmount[i]);
            }
            for (int i = 0; i < 4; i++) 
            {
                tw.WriteLine(pollenMult[i]);
            }
                tw.Close();
            //Closes the main menu which closes the entire program in its entirety.
            mainMenu.instance.Close();
        }
        //make sure data is synced.
        public void syncData()
        {
            pollen.Text = totalPollenInt.ToString();
            honey.Text = totalHoneyInt.ToString();

        }

        private void ttEggShop_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnShop_Click(object sender, EventArgs e)
        {

            var shopWindow = new areaShop();
            shopWindow.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        //Responsible for the random items upon clicking a field and calls for the subprogram responsible for the field pollen calculations
        private void pollenCollection(ref int fieldID)
        {
            if (totalBeeAmount != 0)
            {

                    SoundPlayer itemGainSnd = new SoundPlayer("Images/audio/snd_itemFound.wav");
                    Random rnd = new Random();
                    int rareChance = rnd.Next(1, 10000);
                    if (rareChance == 2)
                    {
                        itemTypeAmount[0] += 1;
                        MessageBox.Show("Rare item Found! A ticket :)");
                        itemGainSnd.Play();
                    }
                    else if (rareChance >= 2 && rareChance <= 50)
                    {
                        itemTypeAmount[1] += 1;
                        itemGainSnd.Play();
                    }
                    else if (rareChance == 3)
                    {
                        itemTypeAmount[5] += 1;
                        MessageBox.Show("Rare item found! A Croissant.");
                        itemGainSnd.Play();
                    }
                    int notRare = rnd.Next(0,200);
                    if (fieldID == 1)
                    {
                        beeGatherAmount(ref fieldID);
                        if (notRare >=0 && notRare <=10) 
                        {
                            itemTypeAmount[3] += 1;
                            itemGainSnd.Play();
                        }
                       

                    }
                    else if (fieldID == 2)
                    {
                        beeGatherAmount(ref fieldID);
                        if (notRare >= 0 && notRare <= 10)
                        {
                            itemTypeAmount[4] += 1;
                            itemGainSnd.Play();
                        }
                        
                    }
                    else if (fieldID == 3)
                    {
                        beeGatherAmount(ref fieldID);
                        if (notRare >= 0 && notRare <= 7)
                        {
                            itemTypeAmount[2] += 1;
                            itemGainSnd.Play();
                        }
                        if (notRare >= 8 && notRare <= 15)
                        {
                            itemTypeAmount[3] += 1;
                            itemGainSnd.Play();
                        }
                        if (notRare >= 16 && notRare <= 23)
                        {
                            itemTypeAmount[4] += 1;
                            itemGainSnd.Play();
                        }


                        
                    }
                    else if (fieldID == 4)
                    {
                        
                        beeGatherAmount(ref fieldID);
                        if (notRare >= 0 && notRare <= 10)
                        {
                            itemTypeAmount[2] += 1;
                            itemGainSnd.Play();
                        }
                    }
                
                else { MessageBox.Show("Currency limit reached! Please buy something from the shop..."); }
                ;

                areaShop.instance.syncDataThree();
            } else { MessageBox.Show("Can't collect pollen without bees! Buy a bee egg just under the hive and above the shop."); }
            areaShop.instance.syncDataThree();


        }


        private void fldBlueBerry_Click(object sender, EventArgs e)
        {
            int fieldID = 4;
            pollenCollection(ref fieldID);

        }
        //This checks for various variables within bees and similar, making some fields better depending on the colour of bee and the amount of items of a certain kind used.

        private void beeGatherAmount(ref int fieldID)
        {

            if (totalBeeAmount > 0)
            {
                //handles gather amount per bee in hive calculation.
                double[] totalGather = new double[totalBeeAmount];
                for (int i = 0; i < totalBeeAmount; i++)
                {

                    totalGather[i] = 1 + (beeGather[beeType[i]]);
                    if (fieldID == 1 || fieldID == 3)
                    {
                        if (beeColour[i] == "None")
                        {
                            totalGather[i] += pollenMult[2] * pollenMult[3];
                        }
                        else { totalGather[i] *= pollenMult[3]; }

                    }
                    else if (fieldID == 2 )
                    {

                        if (beeColour[i] == "Red")
                        {
                            totalGather[i] += pollenMult[1] * pollenMult[3];
                        }
                        else { totalGather[i] *= pollenMult[3]; }
                    
                    }
                    else if (fieldID == 4)
                    {
                        
                        if (beeColour[i] == "Blue")
                        {
                            totalGather[i] += pollenMult[0] * pollenMult[3];
                        }
                        else { totalGather[i] *= pollenMult[3]; }

                    }
                    //Handles the tool multipliers and adds them to pollen count
                
                    if (toolEquipped == 1)
                    {
                        totalPollenInt += Convert.ToInt32(totalGather[i] * 2);
                    }
                    else if (toolEquipped == 2)
                    {
                        totalPollenInt += Convert.ToInt32(totalGather[i] * 5);
                    }
                    else if (toolEquipped == 3)
                    {
                        totalPollenInt += Convert.ToInt32(totalGather[i] * 12);
                    }
                    else
                    {
                        totalPollenInt += Convert.ToInt32(totalGather[i]);
                    }


                }

            }
            else
            {
                MessageBox.Show("Can't gather pollen without a bee... Your first egg is free! \n Fun Fact: Bees gather nectar from flowers with their tongue which is like a straw to suck the nectar from flowers.  ");
            }


        }
        //For the usual user, this just shows that the area is not available, but acts as a way to access debug mode which will be used for testing.
        //Debug mode access instructions found in debug.cs
        private void btnBlueHQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Area unavailable.");
            if (debugMode == 1)
            {
                debug newdebug = new debug();
                newdebug.Show();
            }
        }

        private void fldClover_Click(object sender, EventArgs e)
        {
            int fieldID = 3;
            pollenCollection(ref fieldID);
        }
    }
}