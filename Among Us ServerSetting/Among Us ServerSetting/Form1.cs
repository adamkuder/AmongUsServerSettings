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
        public Form1()
        {
            InitializeComponent();
            comboBoxMap.Items.AddRange(new object[] {"The Skeld",
                        "Mira Hq",
                        "Polus",
                        "dlekS ehT - not work ",
                        "AirShip"});
            splitContainer1.Panel2.Enabled = false;
            try
            {
                MemoryOpenProcess();
            }
            catch (Exception)
            {
                Application.Run(new FormErrorOpenProcess());
            }


        }
        public void MemoryOpenProcess()
        {
            memory.OpenProcess(Process.GetProcessesByName("Among Us").FirstOrDefault().Id);
            comboBoxMap.SelectedIndex = memory.ReadInt("GameAssembly.dll+02C6C4B8,5C,14,10");
            numericImpostor.Value = memory.ReadInt("GameAssembly.dll+02C6C310,5C,4,38");
            numericPlayerSpeed.Value = Math.Round((decimal)memory.ReadFloat("GameAssembly.dll+02C6C4B8,5C,14,14"),2);
            numericCrewVison.Value = Math.Round((decimal)memory.ReadFloat("GameAssembly.dll+02C6C310,5C,4,18"),2);
            numericImpostorVison.Value = Math.Round((decimal)memory.ReadFloat("GameAssembly.dll+02C6C4B8,5C,14,1C"),2);
            numericKillCooldown.Value = Math.Round((decimal)memory.ReadFloat("GameAssembly.dll+02C6C4B8,5C,14,20"),2);
            numericEmegency.Value = memory.ReadInt("GameAssembly.dll+02C6C4B8,5C,14,34");
            numericDiscussion.Value = memory.ReadInt("GameAssembly.dll+02C6C4B8,5C,14,44");
            numericVoteTime.Value = memory.ReadInt("GameAssembly.dll+02C616F8,5C,24,44");
            numericPlayerHat.Value = memory.ReadInt("GameAssembly.dll+02C6C504,5C,40");
            numericPlayerPet.Value = memory.ReadInt("GameAssembly.dll+02C6C504,5C,3C");
            numericPlayerCloth.Value = memory.ReadInt("GameAssembly.dll+02C6C504,5C,44");

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
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,10", "int", comboBoxMap.SelectedIndex.ToString());
        }

        private void ButtonImpostor_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C310,5C,4,38", "int", numericImpostor.Value.ToString());
        }

        private void ButtonPlayerSpeed_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,14", "float", numericPlayerSpeed.Value.ToString());
        }

        private void ButtonCrewVison_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C310,5C,4,18", "float", numericCrewVison.Value.ToString());
        }

        private void ButtonImpostorVison_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,1C", "float", numericImpostorVison.Value.ToString());
        }
        
        private void ButonKillCoolDown_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,20", "float", numericKillCooldown.Value.ToString());
        }

        private void ButtonEmergency_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,34", "int", numericEmegency.Value.ToString());
        }

        private void ButtonDiscussion_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C4B8,5C,14,44", "int", numericDiscussion.Value.ToString());
        }

        private void ButtonVoteTime_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C616F8,5C,24,44", "int", numericVoteTime.Value.ToString());
        }

        private void ButtonPlayerHat_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C504,5C,40", "int", numericPlayerHat.Value.ToString());
        }

        private void ButtonPlayerPet_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C504,5C,3C", "int", numericPlayerPet.Value.ToString());
        }

        private void ButtonPlayerCloth_Click(object sender, EventArgs e)
        {
            memory.WriteMemory("GameAssembly.dll+02C6C504,5C,44", "int", numericPlayerCloth.Value.ToString());
        }
    }
}
