using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDesignPractice
{
    public partial class mainMenu : Form
    {
        string path = @"c:\Bee-Hatcher-Save";
        string savePath = @"c:\Bee-Hatcher-Save\SaveData.txt";
        public int ArenaCloser = 3;
        public static mainMenu instance;
        public mainMenu()
        {
            InitializeComponent();
            createDir();
            instance = this;
            
            
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newWindow = new areaMain();
            newWindow.Show();
            this.Hide();



        }

        private void App_Close()
        {

        }
        //Erase all Cathys / save files
        private void button2_Click(object sender, EventArgs e)
        {
            //Specify game's save directory

            //Check for existence of the directory
            DialogResult confirmation = MessageBox.Show("TRULY ERASE IT?", "ARE YOU SURE?", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes) {
                if (Directory.Exists(path))
                {
                    Directory.Delete(path, true);
                    MessageBox.Show("THEN IT WILL BE DESTROYED", "DEVICE_KILLED");
                    Directory.CreateDirectory(path);
                    return;

                }
            }
            else
            {
                MessageBox.Show("THEN IT WAS SPARED", "DEVICE_SPARED");
                return;
            }
        }

        
        private void createDir() 
        {
            //specify directory for the game's save files
            string path = @"c:\Bee-Hatcher-Save";
            //check if directory exists already
            if (Directory.Exists(path))
            {
                MessageBox.Show("The path " + path + " exists");
                return;

            }
            DirectoryInfo saveDir;
            try
            {
                //Attempt directory creation
                saveDir = Directory.CreateDirectory(path);
                MessageBox.Show("Directory created at " + path);


            }//error message if the file is unable to be created
            catch (UnauthorizedAccessException e)
            {
                MessageBox.Show("The File at " + path + " could not be created. Missing permissions? ");
            }
            


        }
    }
}
