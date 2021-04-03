using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us_ServerSetting
{
    public partial class Form1 : Form
    {
        Memory.Mem memory = new Memory.Mem();
        private static string addressMainOffsetServerSetting = "GameAssembly.dll+028D7458,5C,14,";
        private static string addressOffsetMap = "10";
        private static string addressOffsetImpostor = "38";
        private static string addressOffsetPlayerSpeed = "14";
        private static string addressOffsetCrewVison = "18";
        private static string addressOffsetImpostorVison = "1C";
        private static string addressOffsetKillCooldown = "20";
        private static string addressOffsetEmegency = "34";
        private static string addressOffsetDiscussion = "44";
        private static string addressOffsetVoteTime = "48";
        private static string addressOffsetPlayerSetting = "GameAssembly.dll+028D0DB8,28,5C,";
        private static string addressOffsetPlayerHat = "48";
        private static string addressOffsetPlayerCloth = "4C";
        private static string addressOffsetPlayerPet = "44";
        private static string addressOffsetPlayerColor = "40";
        public Form1()
        {
            InitializeComponent();
            comboBoxMap.Items.AddRange(new object[] {"The Skeld",
                        "Mira Hq",
                        "Polus",
                        "dlekS ehT - not work ",
                        "AirShip"});

            try
            {
                MemoryOpenProcess();
                
            }
            catch (Exception)
            {
                Application.Run(new FormErrorOpenProcess());
            }
            MemoryReadOptionsGame();




        }
        public void MemoryOpenProcess()
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
        }

        public void MemoryReadOptionsGame()
        {
            comboBoxMap.SelectedIndex = memory.ReadInt(addressMainOffsetServerSetting + addressOffsetMap);
            numericImpostor.Value = memory.ReadInt(addressMainOffsetServerSetting + addressOffsetImpostor);
            numericPlayerSpeed.Value = Math.Round((decimal)memory.ReadFloat(addressMainOffsetServerSetting + addressOffsetPlayerSpeed), 2);
            numericCrewVison.Value = Math.Round((decimal)memory.ReadFloat(addressMainOffsetServerSetting + addressOffsetCrewVison), 2);
            numericImpostorVison.Value = Math.Round((decimal)memory.ReadFloat(addressMainOffsetServerSetting + addressOffsetImpostorVison), 2);
            numericKillCooldown.Value = Math.Round((decimal)memory.ReadFloat(addressMainOffsetServerSetting + addressOffsetKillCooldown), 2);
            numericEmegency.Value = memory.ReadInt(addressMainOffsetServerSetting + addressOffsetEmegency);
            numericDiscussion.Value = memory.ReadInt(addressMainOffsetServerSetting + addressOffsetDiscussion);
            numericVoteTime.Value = memory.ReadInt(addressMainOffsetServerSetting + addressOffsetVoteTime);
            numericPlayerHat.Value = memory.ReadInt(addressOffsetPlayerSetting + addressOffsetPlayerHat);
            numericPlayerPet.Value = memory.ReadInt(addressOffsetPlayerSetting + addressOffsetPlayerPet);
            numericPlayerCloth.Value = memory.ReadInt(addressOffsetPlayerSetting + addressOffsetPlayerCloth);
        }

        private void ButtonMore_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2.Enabled == false)
            {
                splitContainer1.Panel2.Show();
                splitContainer1.Panel2.Enabled = true;
                Size = new Size(550, 400);
            }
            else
            {
                splitContainer1.Panel2.Hide();
                splitContainer1.Panel2.Enabled = false;
                Size = new Size(300, 400);
            }
        }
        private void ButtonMap_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetMap, "int", comboBoxMap.SelectedIndex.ToString());
        }

        private void ButtonImpostor_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetImpostor, "int", numericImpostor.Value.ToString());
        }

        private void ButtonPlayerSpeed_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetPlayerSpeed, "float", numericPlayerSpeed.Value.ToString());
        }

        private void ButtonCrewVison_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetCrewVison, "float", numericCrewVison.Value.ToString());
            
        }

        private void ButtonImpostorVison_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetImpostorVison, "float", numericImpostorVison.Value.ToString());
        }
        
        private void ButonKillCoolDown_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetKillCooldown, "float", numericKillCooldown.Value.ToString());
        }

        private void ButtonEmergency_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetEmegency, "int", numericEmegency.Value.ToString());
        }

        private void ButtonDiscussion_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting+addressOffsetDiscussion, "int", numericDiscussion.Value.ToString());
        }

        private void ButtonVoteTime_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressMainOffsetServerSetting + addressOffsetVoteTime, "int", numericVoteTime.Value.ToString());
        }

        private void ButtonPlayerHat_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressOffsetPlayerSetting + addressOffsetPlayerHat, "int", numericPlayerHat.Value.ToString());
        }

        private void ButtonPlayerPet_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressOffsetPlayerSetting + addressOffsetPlayerPet, "int", numericPlayerPet.Value.ToString());
        }

        private void ButtonPlayerCloth_Click(object sender, EventArgs e)
        {
            memory.WriteMemory(addressOffsetPlayerSetting + addressOffsetPlayerCloth, "int", numericPlayerCloth.Value.ToString());
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            MemoryReadOptionsGame();
        }
    }
}
