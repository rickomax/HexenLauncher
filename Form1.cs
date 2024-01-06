using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HexenLauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (var i = 2; i < 32; i++)
            {
                playersComboBox.Items.Add(i);
            }
            playersComboBox.SelectedIndex = 0;
            skillComboBox.SelectedIndex = 0;
            netModeComboBox.SelectedIndex = 0;
            gameComboBox.SelectedIndex = 0;
            hostRadioButton.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            loadGameComboBox.Enabled = loadGameCheckBox.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ipTextBox.Enabled = false;
            skillComboBox.Enabled = true;
            netModeComboBox.Enabled = true;
            ReloadGameData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ipTextBox.Enabled = true;
            levelComboBox.Enabled = false;
            playersComboBox.Enabled = false;
            skillComboBox.Enabled = false;
            netModeComboBox.Enabled = false;
            episodeComboBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedGame = gameComboBox.SelectedItem.ToString();
            var arguments = "";
            if (hostRadioButton.Checked)
            {
                if (selectedGame == "strife.strife")
                {
                    arguments += "StrifeCoop.pk3 ";
                    arguments += "+map map02";
                }
                arguments += "-iwad " + GetIWADName();
                arguments += "-host ";
                arguments += playersComboBox.SelectedItem;
                arguments += " -skill " + skillComboBox.SelectedItem;
                arguments += " -netmode " + netModeComboBox.SelectedItem;
                if ((episodeComboBox.Enabled || levelComboBox.Enabled) && !loadGameCheckBox.Checked)
                {
                    arguments += " -warp ";
                    if (episodeComboBox.Enabled)
                    {
                        arguments += episodeComboBox.SelectedItem + " ";

                    }
                    if (levelComboBox.Enabled)
                    {
                        arguments += levelComboBox.SelectedItem;
                    }
                }
            }
            else if (joinRadioButton.Checked)
            {
                arguments += " -join " + ipTextBox.Text;
            }
            if (loadGameCheckBox.Checked)
            {
                arguments += $" -loadgame {(loadGameComboBox.SelectedIndex > -1 ? loadGameComboBox.SelectedItem : loadGameComboBox.Text)}";
            }
            string executableName;
            if (selectedGame == "rekkr")
            {
                executableName = "rekkr";
            }
            else
            {
                executableName = "gzdoom";
            }
            debugTextBox.Text = $"{AppDomain.CurrentDomain.BaseDirectory}/{executableName}.exe {arguments}";
            Process.Start($"{AppDomain.CurrentDomain.BaseDirectory}/{executableName}.exe", arguments);
        }

        private string GetIWADName()
        {
            switch (gameComboBox.SelectedItem.ToString())
            {
                case "hexen.hexen":
                    {
                        return "hexen.wad";
                    }
                case "doom.id.doom1.ultimate":
                    {
                        return "doom.wad";
                    }
                case "heretic.shadow":
                    {
                        return "heretic.wad";
                    }
                case "rekkr":
                    {
                        return "rekkrsl.wad";
                    }
                case "strife.strife":
                    {
                        return "strife1.wad";
                    }
            }
            throw new Exception("Unknown game selected");
        }

        private void gameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadGameData();
        }

        private void ReloadGameData()
        {
            var selectedGame = gameComboBox.SelectedItem.ToString();
            switch (selectedGame)
            {
                case "hexen.hexen":
                    {
                        levelComboBox.Enabled = true;
                        episodeComboBox.Enabled = false;
                        levelComboBox.Items.Clear();

                        for (var i = 1; i <= 31; i++)
                        {
                            levelComboBox.Items.Add(i);
                        }

                        levelComboBox.SelectedIndex = 0;
                        break;
                    }
                case "doom.id.doom1.ultimate":
                    {
                        levelComboBox.Enabled = true;
                        episodeComboBox.Enabled = true;
                        episodeComboBox.Items.Clear();
                        for (var i = 1; i <= 4; i++)
                        {
                            episodeComboBox.Items.Add(i);
                        }

                        episodeComboBox.SelectedIndex = 0;
                        levelComboBox.Items.Clear();
                        for (var i = 1; i <= 10; i++)
                        {
                            levelComboBox.Items.Add(i);
                        }

                        levelComboBox.SelectedIndex = 0;
                        break;
                    }
                case "heretic.shadow":
                    {
                        levelComboBox.Enabled = true;
                        episodeComboBox.Enabled = true;
                        episodeComboBox.Items.Clear();
                        for (var i = 1; i <= 5; i++)
                        {
                            episodeComboBox.Items.Add(i);
                        }

                        episodeComboBox.SelectedIndex = 0;
                        levelComboBox.Items.Clear();
                        for (var i = 1; i <= 10; i++)
                        {
                            levelComboBox.Items.Add(i);
                        }

                        levelComboBox.SelectedIndex = 0;
                        break;
                    }
                case "rekkr":
                    {
                        levelComboBox.Enabled = true;
                        episodeComboBox.Enabled = true;
                        episodeComboBox.Items.Clear();
                        for (var i = 1; i <= 5; i++)
                        {
                            episodeComboBox.Items.Add(i);
                        }

                        episodeComboBox.SelectedIndex = 0;
                        levelComboBox.Items.Clear();
                        for (var i = 1; i <= 10; i++)
                        {
                            levelComboBox.Items.Add(i);
                        }

                        levelComboBox.SelectedIndex = 0;
                        break;
                    }
                case "strife.strife":
                    {
                        episodeComboBox.Enabled = false;
                        episodeComboBox.Items.Clear();
                        levelComboBox.Enabled = false;
                        levelComboBox.Items.Clear();
                        break;
                    }
            }

            loadGameComboBox.Items.Clear();
            string savedGamesFolder;
            if (selectedGame == "rekkr")
            {
                savedGamesFolder = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) ?? throw new InvalidOperationException(), "Save");
            }
            else
            {

                savedGamesFolder = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE") ?? throw new InvalidOperationException(), "saved games", "GZDoom", selectedGame);
            }
            if (Directory.Exists(savedGamesFolder))
            {
                foreach (var file in Directory.GetFiles(savedGamesFolder))
                {
                    loadGameComboBox.Items.Add(Path.GetFileName(file));
                }
                loadGameComboBox.SelectedIndex = 0;
            }
        }
    }
}
