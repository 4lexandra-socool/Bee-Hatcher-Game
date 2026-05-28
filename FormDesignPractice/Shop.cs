using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDesignPractice
{
    public partial class areaShop : Form
    {
        //Puts all the labels into an array
        Label[] ItemInfo;
        //These arrays act as a database of the details of each item.
        string[] itemName = { "Ticket", "Royal Jelly", "Blueberry", "Sunflower Seed", "Strawberry", "Croissant", "Shovel", "Trash Picker", "Vacuum" };
        int[] itemHoneyCost = { 1000000, 35000, 5000, 5000, 5000,50000,750000, 1500000,10000000 };
        int[] itemBlueberryCost = { 25, 3, 0, 1, 1, 5, 250, 1000, 5000 };
        int[] itemSeedCost = { 25, 3, 1, 0, 1, 5, 250, 1000, 5000 };
        int[] itemStrawberryCost = { 25, 3, 1, 1, 0, 5, 250, 1000, 5000 };
        int[] itemTicketCost = { 0, 0, 0, 0, 0, 0, 10, 50, 150 };
        int itemDisplay = 0;
        string imagePath = Path.Combine(Application.StartupPath);

        public static areaShop instance;

        public areaShop()
        {
            InitializeComponent();
            instance = this;
            //puts all the labels into the iteminfo array for easy display
            ItemInfo = new Label[] {lblItemName, lblHoneyCost,lblBlueBerryCost,lblStrawberryCost,lblSeedCost, lblTicketCost};
            
            


        }

        private void lbHoney_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayItem()
        {


        }

        private void areaShop_Load(object sender, EventArgs e)
        {
            displayShopItem();
            syncDataThree();
        }
        //displays the shop item when the shop is opened
        private void displayShopItem()
        {
            itemDisplay = 0;

            //changes the image to the item of the itemdisplay value 
            imgItem.Image = Image.FromFile("Images/" + areaHive.instance.itemID[itemDisplay] + ".png");
            if (areaMain.instance.itemTypeAmount[0] != null)
            {

                shopItemInfo();
            }



        }
        //Forward button to go forward in the shop
        private void btnForward_Click(object sender, EventArgs e)
        {
            if (itemDisplay <= 7)
            {
                itemDisplay++;
                imgItem.Image = Image.FromFile("Images/" + areaHive.instance.itemID[itemDisplay] + ".png");
                shopItemInfo();
            }
            else
            {

                itemDisplay = 0;
                imgItem.Image = Image.FromFile("Images/" + areaHive.instance.itemID[itemDisplay] + ".png");
                shopItemInfo();
            }
        }
        //Back button to go back in the shop
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (itemDisplay > 0)
            {
                itemDisplay--;
                imgItem.Image = Image.FromFile("Images/" + areaHive.instance.itemID[itemDisplay] + ".png");
                shopItemInfo();
            }

            else
            {
                itemDisplay = 8;
                imgItem.Image = Image.FromFile("Images/" + areaHive.instance.itemID[itemDisplay] + ".png");
                shopItemInfo();
            }
        }
        //When you click buy, calls the subprogram responsible for checking if you're rich enough for something.
        private void btnBuy_Click(object sender, EventArgs e)
        {
            shopItemBuy();
            syncDataThree();
        }
        //Makes sure that data is synced across forms. Likely the most commonly called subprogram.
        public void syncDataThree()
        {
            lblTotalHoney.Text = Convert.ToString(areaMain.instance.totalHoneyInt);
            areaHive.instance.syncDataTwo();
        }

        private void imgItem_Click(object sender, EventArgs e)
        {

        }
        //Shows all the item information available and puts it into the various labels.
        private void shopItemInfo()
        {
            ItemInfo[0].Text = Convert.ToString(itemName[itemDisplay]);
            ItemInfo[1].Text= "Honey:"+itemHoneyCost[itemDisplay].ToString();
            ItemInfo[2].Text= "Blueberries:" + itemBlueberryCost[itemDisplay].ToString();
            ItemInfo[3].Text = "Seeds:" + itemSeedCost[itemDisplay].ToString();
            ItemInfo[4].Text = "Strawberries:" + itemStrawberryCost[itemDisplay].ToString();
            ItemInfo[5].Text = "Tickets:" + itemTicketCost[itemDisplay].ToString() ;

        }
        //Code responsible for buying items.
        private void shopItemBuy()
        {
            //Check if 
            if (areaMain.instance.totalHoneyInt >= itemHoneyCost[itemDisplay] && areaMain.instance.itemTypeAmount[2] >= itemBlueberryCost[itemDisplay] && areaMain.instance.itemTypeAmount[3] >= itemSeedCost[itemDisplay] && areaMain.instance.itemTypeAmount[4] >= itemStrawberryCost[itemDisplay] && areaMain.instance.itemTypeAmount[0] >= itemTicketCost[itemDisplay])
            {
                //Checks if the item is NOT a tool
                if (itemDisplay >= 0 && itemDisplay < 6)
                {
                    areaMain.instance.itemTypeAmount[itemDisplay] += 1;
                    
                    areaMain.instance.totalHoneyInt -= itemHoneyCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[2] -= itemBlueberryCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[3] -= itemSeedCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[4] -= itemStrawberryCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[0] -= itemTicketCost[itemDisplay];
                    MessageBox.Show("Successfully Bought.");
                } 
                //Checks if the item is a tool and restricts buying more than one.
                else if (itemDisplay >6 && itemDisplay < 9 && areaMain.instance.itemTypeAmount[itemDisplay] < 1)
                {
                    areaMain.instance.itemTypeAmount[itemDisplay] += 1;
                    areaMain.instance.totalHoneyInt -= itemHoneyCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[2] -= itemBlueberryCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[3] -= itemSeedCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[4] -= itemStrawberryCost[itemDisplay];
                    areaMain.instance.itemTypeAmount[0] -= itemTicketCost[itemDisplay];
                    MessageBox.Show("Successfully Bought.");
                }//Fallback for having a tool already
                else
                {
                    MessageBox.Show("You already own this!");
                }




            }else 
            { //Tells you you're not rich enough lol
            MessageBox.Show("You are too poor. Please get more currency and items :)");
            }
        }
    }
}
