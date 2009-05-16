using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;


namespace WindowsApplication1
{
    public partial class Arcade : Form
    {
        public Arcade()
        {
            InitializeComponent();
          
        }

        private void nESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Atari_2600_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "something")
            {
                string cmd = @"C:\Arcade\Atari 2600\Roms\2-in-1 - Freeway and Tennis [p1].a26";
                Process p = null;

                p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
            }
           
        }


        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox5.SelectedItem.ToString() == "Zoop Hookstone ") 
            {
                string cmd = @"C:\Arcade\Sega Genesis\Roms\Zoop (U) [!].gen";
                Process p = null;

                p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem.ToString() == "10-Yard Fight ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "100-in-1 Contra Function 16 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\100-in-1 Contra Function 16 (Unl).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "110-in-1 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\110-in-1 (Unl) [p1].nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "150-in-1 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\150-in-1 [p1][!].nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "1942")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "1943 - The Battle of Midway ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "1944")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "1999")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "3-D Battles of World Runner) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "3D Block ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "52 Games ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "76-in-1 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "8 Eyes ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Abadox")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Action 52 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Action in New York ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Addams Family) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Addams Family) The - Pugsley\'s Scavenger Hunt ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Advanced Dungeons & Dragons - Dragon Strike ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Advanced Dungeons & Dragons - Heroes of the Lance ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Advanced Dungeons & Dragons - Hillsfar ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Advanced Dungeons & Dragons - Pool of Radiance ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures in the Magic Kingdom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Bayou Billy) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Captain Comic) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Dino Riki) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Lolo ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Lolo 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Lolo 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Rad Gravity) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Rocky and Bullwinkle and Friends) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Adventures of Tom Sawyer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "After Burner ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Air Fortress")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Airwolf")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Al Unser Jr. Turbo Racing ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Aladdin ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Aladdin 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Aladdin 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Alfred Chicken ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Alien 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Alien Syndrome ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "All-Pro Basketball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Alpha Mission ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Amagon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "American Gladiators ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Anticipation ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Arch Rivals - A Basket Brawl! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Archon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Arkanoid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Arkista\'s Ring ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Asterix ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Astyanax ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Atari RBI Baseball")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Athena ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Athletic World ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Attack of the Killer Tomatoes ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Aussie Rules Footy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Baby Boomer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Back to the Future ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Back to the Future II & III ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bad Dudes ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bad Dudes vs Dragon Ninja ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bad News Baseball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bad Street Brawler ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Balloon Fight ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bandai Golf - Challenge Pebble Beach ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bandit Kings of Ancient China ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bard\'s Tale) The - Tales of the Unknown ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Barker Bill\'s Trick Shooting ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Base Wars ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Baseball Simulator 1.000 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Baseball Stars ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Baseball Stars II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bases Loaded ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bases Loaded 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bases Loaded 4 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bases Loaded II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Batman - Return of the Joker ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Batman 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Batman Returns ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Batman")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battle Chess ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battle City ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battle of Olympus) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battle Tank ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battleship ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battletoads & Double Dragon - The Ultimate Team ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Battletoads ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Beauty and the Beast ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Beetlejuice ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Best of the Best - Championship Karate ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bible Adventures")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bible Buffet ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Big Bird\'s Hide & Speak ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Big Nose the Caveman ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bigfoot ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bill & Ted\'s Excellent Video Game Adventure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bill Elliott\'s NASCAR Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bio Hazard ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bionic Commando ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Black Bass USA) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blackjack ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blackjack ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blades of Steel ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blaster Master ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blue Marlin) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blue Shadow ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Blues Brothers) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bo Jackson Baseball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bomberman ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bomberman Collection ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bomberman II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bonk\'s Adventure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Boulder Dash ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Boy and His Blob) A - Trouble on Blobolonia ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bram Stoker\'s Dracula ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Break Time - The National Pool Tour ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "BreakThru ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Brush Roller ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bubble Bath Babes ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bubble Bobble ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bubble Bobble Part 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bucky O\'Hare ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bugs Bunny Birthday Blowout) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bugs Bunny Crazy Castle) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "BugsBday")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Bump & Jump")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Burai Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Burger Time ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cabal")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Caesars Palace ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "California Games ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "California Raisins - The Grape Escape ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "CAPSILVE")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Captain America and the Avengers ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Captain Planet and The Planeteers ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Captain Skyhawk ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Casino Kid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Casino Kid 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Casino")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castelia")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castelian")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castle of Deceit ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castle of Dragon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castlequest")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castlevania II - Simon\'s Quest ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castlevania III - Dracula\'s Curse ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Castlevania")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Caveman Games ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Caveman Ninja ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Challenge of the Dragon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Championship Bowling ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Championship Pool ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Championship Rally ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cheetah Men II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Chessmaster) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Chiller ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Chip \'n Dale Rescue Rangers ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Chip \'n Dale Rescue Rangers 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Chubby Cherub ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Circus Caper ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "City Connection ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Clash at Demonhead ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Classic Concentration ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cliffhanger ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Clu Clu Land ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cobra Command ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cobra Triangle ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Code Name - Viper ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Color A Dinosaur ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Commando ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Conan ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Conflict ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Conquest of the Crystal Palace ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Contra ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Contra Force ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cool World ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Corvette ZR-1 Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cowboy Kid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Crackout ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Crash \'n the Boys - Street Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Crystal Mines ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Crystalis ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cyberball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Cybernoid - The Fighting Machine ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Danny Sullivan\'s Indy Heat ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Darkman ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Darkseed ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Darkwing Duck ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dash Galaxy in the Alien Asylum ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Day Dreamin\' Davey ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Days of Thunder ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Deadly Towers ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Death Race ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Deathbots ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Defender II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Defender of the Crown ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Defenders of Dynatron City ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Deja Vu ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Demogorgon Monk ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Demon Sword ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Desert Commander ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Destination Earthstar ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Destiny of an Emperor ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Devil World ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dick Tracy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Die Hard ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dig Dug II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Digger - The Legend of the Lost City ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Digger T. Rock - The Legend of the Lost City ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dirty Harry ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dizzy The Adventurer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donald Magic ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donkey Kong ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donkey Kong 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donkey Kong Classics ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donkey Kong Country 4 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donkey Kong Jr. (JU)")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Donkey Kong Jr. Math ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Dare ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Dragon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Dragon 4 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Dragon II - The Revenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Dragon III - The Sacred Stones ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Dribble ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Double Strike ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dr. Chaos ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dr. Jekyll and Mr. Hyde ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dr. Mario ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Ball Z - Super Butoden 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Power ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Quest ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Spirit - The New Legend ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Warrior ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Warrior II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Warrior III ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon Warrior IV ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon\'s Lair ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dragon) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Drop Zone ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Duck Hunt ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Duck Tales ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Duck Tales 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dudes With Attitude ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dungeon Magic - Sword of the Elements ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dusty Diamond\'s All-Star Softball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dynablaster ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Dynowarz - Destruction of Spondylus ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Earth Worm Jim 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Earthbound (Prototype)")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Elevator Action ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Eliminator Boat Duel ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Elite ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Excitebike ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Exodus")
                if (listBox2.SelectedItem.ToString() == "F-117A Stealth Fighter ")
                {
                    string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                    Process p = new Process();
                    p.StartInfo.FileName = cmd;
                    p.Start();
                    p.WaitForExit();
                    p.Dispose();
                }
            if (listBox2.SelectedItem.ToString() == "F-15 City War ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "F-15 Strike Eagle ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Family Feud ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fantastic Adventures of Dizzy) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fantasy Zone ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Faria - A World of Mystery and Danger! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fatal Fury 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Felix the Cat ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ferrari - Grand Prix Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fester\'s Quest ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fighting Hero ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Final Fantasy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Final Fantasy II (Prototype)")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Final Fantasy V ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Final Fight 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fire \'n Ice ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fire Dragon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fire Emblem ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fire Hawk ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Firehouse Rescue ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fist of the North Star ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Flight of the Intruder ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Flintstones) The - The Rescue of Dino & Hoppy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Flintstones) The - The Surprise at Dinosaur Peak! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Flying Dragon - The Secret Scroll ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Flying Warriors ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Formula 1 Sensation ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Formula One - Built To Win ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Four Players Tennis ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Frankenstein - The Monster Returns ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Free Fall ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Freedom Force ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Friday the 13th ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Fun House ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "G.I. Joe ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "G.I. Joe - The Atlantis Factor ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Galactic Crusader ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Galaga ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Galaxy 5000 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Game Genie ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gargoyle\'s Quest II - The Demon Darkness ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gauntlet ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gauntlet II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gemfire ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Genghis Khan ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "George Foreman\'s KO Boxing ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ghostbusters ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ghostbusters 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ghosts\'n Goblins ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ghoul School ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gilligan\'s Island ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Goal! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Goal! 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Godzilla - Monster of Monsters! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Godzilla 2 - War of the Monsters ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gold Medal Challenge \'92 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Golf ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Golf Grand Slam ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Golgo 13 - Top Secret Episode ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Goonies II) The")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Goonies) The  ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gotcha! - The Sport! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gradius ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Great Waldo Search) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Greg Norman\'s Golf Power ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gremlins 2 - The New Batch ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Guardian Legend) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Guerrilla War ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gumshoe ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gun Nac ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gun.Smoke ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gyromite ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Gyruss ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Harlem Globetrotters ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hatris ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Heavy Barrel ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Heavy Shreddin\' ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hi-Game 1999 - Rayban the Third ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hi-Game 1999 - Super Donkey Kong 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "High Speed ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hogan\'s Alley ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hollywood Squares ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Home Alone ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Home Alone 2 - Lost in New York ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hook ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hoops ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hot Slot")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hudson Hawk ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hudson\'s Adventure Island ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hudson\'s Adventure Island II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hudson\'s Adventure Island III ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hunt for Red October) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Hydlide ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "I Can Remember ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ice Climber ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ice Hockey ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ikari III - The Rescue ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ikari Warriors ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ikari Warriors II - Victory Road ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Image Fight ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Immortal) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Impossible Mission II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Incredible Crash Dummies) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Indiana Jones and the Last Crusade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Indiana Jones and the Temple of Doom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Infiltrator ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "International Cricket ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Iron Tank ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ironsword - Wizards & Warriors II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Isolated Warrior ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ivan Ironman Stewart\'s Super Off-Road ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jack Nicklaus\' Greatest 18 Holes of Major Championship Golf ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jackal ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jackie Chan\'s Action Kung Fu ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "James Bond Jr ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jaws ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jeopardy! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jeopardy! 25th Anniversary Edition ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jeopardy! Junior Edition ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jetsons) The - Cogswell\'s Caper! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jimmy Connor\'s Tennis ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Joe & Mac ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "John Elway\'s Quarterback ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jordan Vs Bird - One On One ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Journey to Silius ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Joust ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jovial Race ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jungle Book) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Jurassic Park ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kabuki - Quantum Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Karate Champ ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Karate Kid) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Karnov ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kart Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kick Master ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kick Off ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kickle Cubicle ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kid Icarus ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kid Klown ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kid Kool ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kid Niki - Radical Ninja ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "King Neptune\'s Adventure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "King of Fighters 96 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "King of Fighters 99 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "King of Kings) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "King\'s Knight ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "King\'s Quest V ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kings of the Beach ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kirby\'s Adventure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kiwi Kraze ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Klash Ball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Klax ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Knight Rider ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Konami Hyper Soccer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Krazy Kreatures ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Krion Conquest) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Krusty\'s Fun House ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kung Fu ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Kung-Fu Heroes ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "L\'Empereur ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Laser Invasion ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Last Action Hero ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Last Ninja) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Last Starfighter) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lee Trevino\'s Fighting Golf ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legacy of the Wizard ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legend of Kage) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legend of Prince Valiant) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legend of the Ghost Lion ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legend of Zelda) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legendary Wings ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Legends of the Diamond ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lemmings ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lethal Weapon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lifeforce ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lion King 3) The - Simon and Pumba ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lion King) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Little League Baseball - Championship Series ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Little Mermaid) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Little Nemo - The Dream Master ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Little Ninja Brothers ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Little Samson ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lode Runner ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lone Ranger) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Loopz ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Low G Man ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Lunar Pool ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "M.C. Kids ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "M.U.L.E. ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "M.U.S.C.L.E. ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mach Rider ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mad Max ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mafat Conspiracy - Golgo 13 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magic Block ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magic Darts ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magic Dragon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magic Johnson\'s Fast Break ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magic of Scheherazade) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magician")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Magmax")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mahjong  ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Major League Baseball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Maniac Mansion ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Maniac")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mappy-Land ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Marble Madness")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mario & Yoshi ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mario Bros. ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mario is Missing! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mario Open Golf ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mario\'s Time Machine! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Marvel\'s X-Men ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Master Chu & The Drunkard Hu ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Master Fighter 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mechanized Attack ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man 4 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man 5 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man 6 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mega Man 7 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Menace Beach ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mendel Palace ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mermaids of Atlantis ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Metal Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Metal Gear ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Metal Mech ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Metal Storm ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Metroid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Michael Andretti\'s World Grand Prix ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mickey Mousecapade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mickey\'s Adventures in Numberland ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mickey\'s Safari in Letterland ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mickey")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Micro Machines ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "MiG 29 - Soviet Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Might and Magic ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mighty Bomb Jack ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mighty Final Fight ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mike Tyson\'s Punch-Out!! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Millipede ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Milon\'s Secret Castle ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Miracle Piano Teaching System) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mission Cobra ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mission Impossible ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Monopoly")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Monster In My Pocket ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Monster Party ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Monster Truck Rally ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Moon Ranger ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mortal Kombat 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mortal Kombat 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mortal Kombat 4 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mortal Kombat Trilogy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Motor City Patrol ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mr. Gimmick ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ms. Pac-Man")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Muppet Adventure - Chaos at the Carnival ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mutant Virus) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Mystery Quest ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Napoleon\'s War ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "NES Open Tournament Golf ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "NES Play Action Football ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "New Zealand Story ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "NFL Football ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nigel Mansell\'s World Championship Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nightmare on Elm Street) A ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nightshade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ninja Crusaders ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ninja Gaiden ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ninja Gaiden 2 - The Dark Sword of Chaos ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ninja Gaiden 3 - The Ancient Ship of Doom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ninja Kid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nintendo World Championships 1990 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nintendo World Cup ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Noah\'s Ark ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nobunaga\'s Ambition ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Nobunaga\'s Ambition 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "North & South ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Operation Secret Storm ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Operation Wolf ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Over Horizon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Overlord ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "P\'radikus Conflict) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pac-Man ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pac-Mania ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Palamedes ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Panic Restaurant ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Paperboy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Paperboy 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Parodius ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Peek-A-Boo Poker ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Perfect Fit ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pesterminator - The Western Exterminator ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Peter Pan & The Pirates ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Phantom Fighter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pictionary ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pikachu Y2K ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pinball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pinball Quest ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pinbot ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pipe Block ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pipe Dream ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pirates! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pitfall")
                if (listBox2.SelectedItem.ToString() == "Platoon ")
                {
                    string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                    Process p = new Process();
                    p.StartInfo.FileName = cmd;
                    p.Start();
                    p.WaitForExit();
                    p.Dispose();
                }
            if (listBox2.SelectedItem.ToString() == "Pokemon Blue ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pokemon Golden ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pokemon Green ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pokemon Yellow ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Popeye ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "POW - Prisoners of War ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Power Blade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Power Blade 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Power Punch 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Predator ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Prince of Persia ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Princess Tomato in Salad Kingdom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pro Action Replay ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pro Sport Hockey ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pro Wrestling ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Probotector ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Probotector II - Return of the Evil Forces ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Punch-Out!! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Punisher) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Puss \'n Boots - Pero\'s Great Adventure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Puzznic ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Pyramid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Q-bert ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Qix ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Quattro Adventure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Quattro Arcade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Quattro Sports ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "R.B.I. Baseball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "R.B.I. Baseball 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "R.B.I. Baseball 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "R.C. Pro-Am ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "R.C. Pro-Am 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Race America ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Racket Attack ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rackets & Rivals ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rad Racer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rad Racer 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rad Racket - Deluxe Tennis II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Raid 2020 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Raid on Bungeling Bay ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rainbow Islands - The Story of Bubble Bobble 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rally Bike ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rambo ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rampage ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rampart ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ren & Stimpy Show) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Renegade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rescue - The Embassy Mission ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ring King ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "River City Ransom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Road Runner ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "RoadBlasters ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Robin Hood - Prince of Thieves ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Robo Warrior ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Robocop ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Robocop 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Robocop 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Robodemons ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rock \'n\' Ball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rocketeer) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rockin\' Kats ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rocman X ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Roger Clemens MVP Baseball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rollerball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rollerblade Racer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rollergames ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rolling Thunder ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Romance of the Three Kingdoms ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Romance of the Three Kingdoms II ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Roundball - 2-on-2 Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rush\'n Attack ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Rygar ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "SCAT - Special Cybernetic Attack Team ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "SCAT")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Secret Scout ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Section Z ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Seicross ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sesame Street 123 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sesame Street ABC ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sesame Street ABC - 123 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sesame Street Countdown ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shadow of the Ninja ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shadow Warriors ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shadow Warriors Episode II - The Dark Sword of Chaos ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shadowgate ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shatterhand ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shingen The Ruler ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shinobi ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shockwave ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Shooting Range ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Short Order - Eggsplode ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Side Pocket ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Silent Assault ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Silent Service ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Silk Worm ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Silver Surfer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Simpsons) The - Bart Vs. the Space Mutants ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Simpsons) The - Bart Vs. the World ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Simpsons) The - Bartman Meets Radioactive Man ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Skate or Die 2 - The Search for Double Trouble ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Skate or Die! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ski or Die ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Skull & Crossbones ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sky Kid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sky Shark ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Slalom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Smash T.V. ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Smurfs) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Snake Rattle\'n Roll ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Snake\'s Revenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Snoopy\'s Silly Sports Spectacular ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Snow Bros ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Soccer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Solar Jetman - Hunt for the Golden Warpship ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Solitaire ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Solomon\'s Key ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Solomon\'s Key 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Solstice ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Space Shuttle Project ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Spelunker ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Spider-Man - Return of the Sinister Six ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Spiritual Warfare ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Spot ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Spy Hunter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Spy Vs Spy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sqoon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Stadium Events ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Stanley - The Search for Dr. Livingston ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Force ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Soldier ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Trek - 25th Anniversary ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Trek - The Next Generation ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Voyager ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Wars ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Star Wars - The Empire Strikes Back ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Starship Hector ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Startropics ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Startropics 2 - Zoda\'s Revenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Stealth ATF ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Stinger ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Street Cop ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Street Fighter 2010 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Street Fighter 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Street Fighter 4 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Street Fighter Zero 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Street Gangs ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Strider ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Stunt Kids ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sunday Funday ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Cars ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Dodge Ball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Donkey Kong 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Donkey Kong ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Glove Ball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Jeopardy! ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Mario Bros. ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Mario Bros. + Duck Hunt ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Mario Bros. 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Mario Bros. 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Mario World ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Mary ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Off-Road ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Pitfall ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Skater ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Sky Kid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Spike V\'Ball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Sprint ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Spy Hunter ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Team Games ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Turrican ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Super Xevious ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Superman ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Swamp Thing ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "SWAT")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Sword Master ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Swords and Serpents ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "T&C 2 - Thrilla\'s Surfari ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "T&C Surf Design ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "T2")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Taboo - The Sixth Sense ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tag Team Wrestling ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tagin\' Dragon ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "TaleSpin ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Target Renegade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo Baseball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo Bowl ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo Cup - Soccer Game ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo NBA Basketball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo NFL Dynasties")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo Super Bowl ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tecmo World Wrestling ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Teenage Mutant Hero Turtles ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Teenage Mutant Hero Turtles II - The Arcade Game ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Teenage Mutant Ninja Turtles - Tournament Fighters ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Teenage Mutant Ninja Turtles III - The Manhattan Project ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tekken 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Terminator 2 - Judgment Day ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Terminator) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Terra Cresta ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tetris ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tetris 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Three Stooges ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Thunder & Lightning ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Thunderbirds ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Thundercade ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tiger-Heli ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tiles of Fate ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Time Lord ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Times of Lore ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tiny Toon Adventures ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tiny Toon Adventures 2 - Trouble in Wackyland ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tiny Toon Adventures Cartoon Workshop ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "To The Earth ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Toki ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tom & Jerry 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tom & Jerry and Tuffy ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Tombs and Treasure ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Toobin\' ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Top Gun ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Top Gun - The Second Mission ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Top Players\' Tennis - Featuring Chris Evert & Ivan Lendl ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Total Recall ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Totally Rad ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Touch Down Fever ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Toxic Crusaders ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Track & Field ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Treasure Master ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Trog ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Trojan ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Trolls on Treasure Island ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Turbo Racing ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Twin Cobra ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Twin Eagle ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ufouria ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultima - Exodus ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultima - Quest of the Avatar ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultima - Warriors of Destiny ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultimate Air Combat ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultimate Basketball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultimate League Soccer ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Ultimate Stuntman ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Uncharted Waters ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Uninvited ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Untouchables) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Urban Champion ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Vegas Dream ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Venice Beach Volleyball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Vice - Project Doom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Videomation ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Vindicators ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Volleyball ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "VS Castlevania ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "VS Slalom ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "VS Super Mario Bros. ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "VS TKO Boxing ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wacky Races ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wall Street Kid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wally Bear and the No Gang ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wario\'s Woods ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wayne Gretzky Hockey ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wayne\'s World ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "WCW World Championship Wrestling ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Werewolf - The Last Warrior ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wheel of Fortune ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wheel of Fortune Family Edition ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wheel of Fortune Junior Edition ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Where in Time is Carmen Sandiego ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Where\'s Waldo ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Who Framed Roger Rabbit ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Whomp\'Em ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Widget ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wild Gunman ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Willow ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Win) Lose or Draw ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Winter Games ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wizardry - Proving Grounds of the Mad Overlord ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wizardry - The Knight of Diamonds ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wizards & Warriors ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wizards & Warriors 3 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wolverine ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "World Champ ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "World Class Track Meet ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "World Games ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "World Heroes 2 ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wrath of the Black Manta ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wrecking Crew")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wrestlemania Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Wurm ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "WWF King of the Ring ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "WWF Steel Cage Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "WWF Wrestlemania ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "WWF Wrestlemania Challenge ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Xenophobe ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Xevious ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Xexyz ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Xexyz")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "XMEN")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Yo! Noid ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Yo!Noid")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Yoshi ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Yoshi\'s Cookie ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Yoshi")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Young Indiana Jones Chronicles) The ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Zanac ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Zelda II - The Adventure of Link ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Zelda")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Zelda2")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
            if (listBox2.SelectedItem.ToString() == "Zombie Nation ")
            {
                string cmd = @"C:\Arcade\NES\Roms\10-Yard Fight (U).nes";
                Process p = new Process();
                p.StartInfo.FileName = cmd;
                p.Start();
                p.WaitForExit();
                p.Dispose();
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



            /*
 




        */
        

    }
}