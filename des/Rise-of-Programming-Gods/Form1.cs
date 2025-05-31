using Rise_of_Programming_Gods.Characters;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace Rise_of_Programming_Gods
{
    public partial class Form1 : Form
    {
        private readonly BattleManager battleManager;
        private Timer battleTimer;
        private ToolTip toolTip;

        public Form1()
        {
            InitializeComponent();
            battleManager = new BattleManager();
            toolTip = new ToolTip();
            InitializeBattleTimer();
            SetupForm();
        }

        private int player1Health = 100;
        private int player2Health = 100;


        private void InitializeBattleTimer()
        {
            battleTimer = new Timer();
            battleTimer.Interval = 1000; // 1 second between turns
            battleTimer.Tick += BattleTimer_Tick;
        }

        private void SetupForm()
        {
            // Set the form background image and stretch it to fill the form
            this.BackgroundImage = Properties.Resources.classroombg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Existing setup code ...
            string[] characterTypes = new string[]
            {
        "PauCoder",
        "RogerRipper",
        "StarLord",
        "RyenVizier"
            };

            cmbPlayer1Type.Items.AddRange(characterTypes);
            cmbPlayer2Type.Items.AddRange(characterTypes);
            cmbPlayer1Type.SelectedIndex = 0;
            cmbPlayer2Type.SelectedIndex = 0;

            txtBattleLog.Multiline = true;
            txtBattleLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            txtBattleLog.ReadOnly = true;

            lblPlayer1Health.Text = "Health: 100";
            lblPlayer2Health.Text = "Health: 100";

            // Remove background from controls to see the form background if needed
        }


        private void btnStartBattle_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate player names
                if (string.IsNullOrWhiteSpace(txtPlayer1Name.Text) || string.IsNullOrWhiteSpace(txtPlayer2Name.Text))
                {
                    MessageBox.Show("Please enter names for both players.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate player types are selected
                if (cmbPlayer1Type.SelectedItem == null || cmbPlayer2Type.SelectedItem == null)
                {
                    MessageBox.Show("Please select types for both players.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Set fixed form size on start
                this.ClientSize = new Size(850, 450);

                // Reset health values and update UI
                ResetHealthUI();

                // Clear battle log before starting
                txtBattleLog.Clear();

                // Create player characters
                CodingWarrior player1 = CreateCharacter(txtPlayer1Name.Text, cmbPlayer1Type.SelectedItem.ToString());
                CodingWarrior player2 = CreateCharacter(txtPlayer2Name.Text, cmbPlayer2Type.SelectedItem.ToString());

                // Initialize the battle
                battleManager.InitializeBattle(player1, player2);

                // Display initial battle log
                UpdateBattleLog();

                // Start the battle timer
                battleTimer.Start();

                // Disable the start button while battle is ongoing
                btnStartBattle.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting battle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetHealthUI()
        {
            player1Health = 100;
            player2Health = 100;

            lblPlayer1Health.Text = "Health: 100";
            progressBarPlayer1.Value = 100;

            lblPlayer2Health.Text = "Health: 100";
            progressBarPlayer2.Value = 100;
        }




        private CodingWarrior CreateCharacter(string name, string type)
        {
            switch (type)
            {
                case "PauCoder":
                    return new PauCoder(name);
                case "RogerRipper":
                    return new RogerRipper(name);
                case "StarLord":
                    return new StarLord(name);
                case "RyenVizier":
                    return new RyenVizier(name);
                default:
                    throw new ArgumentException($"Unknown character type: {type}");
            }
        }

        private void BattleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                // Execute one turn of the battle; returns false if battle is over
                if (!battleManager.ExecuteTurn())
                {
                    battleTimer.Stop();
                    btnStartBattle.Enabled = true;
                }

                // Update the battle log text area
                UpdateBattleLog();

                // Update health UI after the turn
                UpdateHealthDisplays();
            }
            catch (Exception ex)
            {
                battleTimer.Stop();
                MessageBox.Show($"Error during battle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStartBattle.Enabled = true;
            }
        }

        private void UpdateHealthDisplays()
        {
            // Assuming battleManager has properties for Player1 and Player2:
            var player1 = battleManager.Player1;
            var player2 = battleManager.Player2;

            // Update labels to current health
            lblPlayer1Health.Text = $"Health: {Math.Max(0, player1.Health)}";
            lblPlayer2Health.Text = $"Health: {Math.Max(0, player2.Health)}";

            // Update progress bars, ensure value within range 0 - 100 (or max health)
            progressBarPlayer1.Value = Math.Max(0, Math.Min(progressBarPlayer1.Maximum, player1.Health));
            progressBarPlayer2.Value = Math.Max(0, Math.Min(progressBarPlayer2.Maximum, player2.Health));
        }


        private void txtBattleLog_TextChanged(object sender, EventArgs e)
        {
            // Empty handler - required by designer but no implementation needed
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Empty handler - required by designer but no implementation needed
        }

        private void UpdateBattleLog()
        {
            txtBattleLog.Clear();
            foreach (string log in battleManager.BattleLog)
            {
                txtBattleLog.AppendText(log + Environment.NewLine);
            }
            txtBattleLog.ScrollToCaret();
        }

        private void UpdateUI()
        {
            // Simple health display without advanced features
            if (battleManager.Player1 != null)
            {
                lblPlayer1Health.Text = $"Health: {battleManager.Player1.Health}";
                lblPlayer1Health.ForeColor = GetHealthColor(battleManager.Player1);
            }

            if (battleManager.Player2 != null)
            {
                lblPlayer2Health.Text = $"Health: {battleManager.Player2.Health}";
                lblPlayer2Health.ForeColor = GetHealthColor(battleManager.Player2);
            }
        }

        private Color GetHealthColor(CodingWarrior warrior)
        {
            if (warrior == null) return Color.Black;

            float healthPercent = (float)warrior.Health / warrior.MaxHealth;

            if (healthPercent > 0.7f)
                return Color.Green;
            else if (healthPercent > 0.3f)
                return Color.Orange;
            else
                return Color.Red;
        }


        private Image CombineCharacterImages(string char1, string char2)
        {
            // Load character images from resources based on character names
            Image img1 = GetCharacterImage(char1);
            Image img2 = GetCharacterImage(char2);

            // Create a new bitmap with width enough to hold both characters
            int width = img1.Width + img2.Width;
            int height = Math.Max(img1.Height, img2.Height);

            Bitmap combined = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(combined))
            {
                g.Clear(Color.Transparent);
                g.DrawImage(img1, new Point(0, height - img1.Height));  // Left character aligned bottom
                g.DrawImage(img2, new Point(img1.Width, height - img2.Height)); // Right character aligned bottom
            }

            return combined;
        }

        private Image GetCharacterImage(string characterType)
        {
            switch (characterType)
            {
                case "PauCoder":
                    return Properties.Resources.PauCoder;  // Ensure you have this in Resources
                case "RogerRipper":
                    return Properties.Resources.RogerRipper;
                case "StarLord":
                    return Properties.Resources.StarLord;
                case "RyenVizier":
                    return Properties.Resources.RyenVizier;
                default:
                    return null;
            }
        }



    }
}