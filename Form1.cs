using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace gui_lucky_seven
{
    public partial class Form1: Form
    {
        InsertMoneyForm insertMoneyForm = new InsertMoneyForm();
        AddWallet addwallet = new AddWallet();

        Random rnd = new Random();
        string[] imageNames = { "bar.png", "bell.png", "cherries.png", "diamond.png", "orange.png", "seven.png" };
        string imageFolderPath = Path.Combine(Application.StartupPath, "Images", "slot_icons");

        private int addedBalance;
        private int userBalance;

        private int insertAmount;
        private int slotBalance;
        private int creditsBalance;
        
        private bool isGameStarted = false;
        
        private int[] bets = { 25, 50, 100 };
        private int currentBetIndex = 0;
        private int choiceOfBet;
        private void label_userWalletUpdate()
        {
            label_userWallet.Text = "₱" + userBalance.ToString();
        }
        private void label_userWallet_Click(object sender, EventArgs e)
        {
            label_userWalletUpdate();
        }
        private void button_addWallet_Click(object sender, EventArgs e)
        {
            if (addwallet.ShowDialog() == DialogResult.OK)
            {

                if (int.TryParse(addwallet.userWalletBalance, out addedBalance))
                {
                    if (addedBalance < 0)
                    {
                        MessageBox.Show("Invalid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        userBalance += addedBalance;
                        MessageBox.Show("Wallet Balance set to: " + userBalance);
                        label_userWalletUpdate();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            label_betAmountUpdate();
            label_help.Text = (
                "please click + (above left corner) \nto add money on your wallet" +
                "\n\nGUIDE" +
                "\nL      Lever" +
                "\nG      Gold Button" +
                "\nU      Reset (if no credits left)" +
                "\nI       Insert Cash" +
                "\n< >   Left and Right" +
                "\n_      Select the Bet" +
                "\n\nBETTING"+
                "\nBet 25: \n+30credits(cherries, seven)" +
                "\nBet 50: \n+60credits(orange, cherries, seven)" +
                "\nBet 100: \n+120credits(all combinations)" +
                "\n\nTUTORIAL" +
                "\nStep#1:  Insert Cash" +
                "\nStep#2:  Push Gold Button"+
                "\nStep#3:  Choose Your Bet"+
                "\nStep#4:  Select Your Bet"+
                "\nStep#5:  Click The Lever" +
                "\nStep#6:  Reset, Withdraw, or Step#5");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string randomImagePath_1 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
            string randomImagePath_2 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
            string randomImagePath_3 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
            slot1.SizeMode = PictureBoxSizeMode.StretchImage;
            slot2.SizeMode = PictureBoxSizeMode.StretchImage;
            slot3.SizeMode = PictureBoxSizeMode.StretchImage;
            slot1.Image = Image.FromFile(randomImagePath_1);
            slot2.Image = Image.FromFile(randomImagePath_2);
            slot3.Image = Image.FromFile(randomImagePath_3);
            
            label_slotBalanceUpdate();
            label_userWalletUpdate();
            UpdateSubLabelIntro();
            BlinkMainLabelIntro();
            label_betAmountUpdate();
        }
        private void creditsUpdate()
        {

            if (creditsBalance >= choiceOfBet)
            {
                creditsBalance -= choiceOfBet;
            }

            label_creditsAmount.Text = creditsBalance.ToString();

            // Show undo button only if credits < minimum bet (25)
            bool showUndo = creditsBalance < bets[0];
            IsVisibleEnableButtonUndo(showUndo);

            if (creditsBalance < choiceOfBet)
            {
                IsVisibleEnableLever(false);
            }

        }
        
        private async void BlinkMainLabelIntro()
        {
            string[] introArray = { "S", "L", "O", "T", " ", "M", "A", "C", "H", "I", "N", "E" };

            while (!isGameStarted || isGameStarted)
            {
                await Task.Delay(450);
                label_introduction.Text = "";
                foreach (string INTROARRAY in introArray)
                {
                    label_introduction.Text += INTROARRAY;
                    await Task.Delay(250);
                }
                await Task.Delay(450);
                label_introduction.Text = "";
                await Task.Delay(450);
                label_introduction.Text = "SLOT MACHINE";
                await Task.Delay(450);
                label_introduction.Text = "";
                await Task.Delay(450);
                label_introduction.Text = "SLOT MACHINE";
                await Task.Delay(450);
                label_introduction.Text = "";
                await Task.Delay(450);
                label_introduction.Text = "SLOT MACHINE";
                await Task.Delay(450);
                label_introduction.Text = "";

            }
        }
        private async void UpdateSubLabelIntro()
        {
            while (!isGameStarted)
            {
                label_subIntro.Location = new Point(399, 148);
                if (slotBalance > 0)
                {
                    label_subIntro.Location = new Point(354, 148);
                    label_subIntro.Text = ">push gold the button to start<";
                    label_calculation.Text = "inserted: ₱"+slotBalance;
                    IsVisibleEnableLabelIntro(true);
                    IsVisibleEnableGoldButton(true);
                    IsVisibleEnableButton(false);
                    IsVisibleEnableLever(false);
                    IsVisibleEnableRightLeft(false);
                    IsVisibleEnableButtonUp(false);
                    IsVisibleEnableButtonUndo(false);
                }
                else
                {
                    label_subIntro.Text = ">insert cash to begin<";
                    label_calculation.Text = "₱100 = 400 credits";
                    IsVisibleEnableLabelIntro(true);
                    IsVisibleEnableGoldButton(false);
                    IsVisibleEnableButton(false);
                    IsVisibleEnableLabel(false);
                    IsVisibleEnableLever(false);
                    IsVisibleEnableRightLeft(false);
                    IsVisibleEnableButtonUp(false);
                    IsVisibleEnableButtonUndo(false);
                }

                await Task.Delay(115);
                label_subIntro.Text = "";
                label_calculation.Text = "";
                await Task.Delay(115);
                
                
            }

        }
        bool isSpinning = false;
        private bool hasSpunOnce = false;
        private async Task SpinSlots()
        {
            
            label_winAmount.Text = "_";
            isSpinning = true;

            if (creditsBalance >= choiceOfBet)
            {
                creditsUpdate();
                IsVisibleEnableLever(true);
                IsVisibleEnableButtonUndo(false);
                IsVisibleEnableButtonUp(false);
            }
            else
            {
                IsVisibleEnableLever(false);
                IsVisibleEnableButtonUndo(true);
                IsVisibleEnableButtonUp(true);
            }

            if (isSpinning)
            {
                IsVisibleEnableButton(false);
                IsVisibleEnableButtonInsertMoney(false);
                IsVisibleEnableLever(false);
            }

            slot1.SizeMode = PictureBoxSizeMode.StretchImage;
            slot2.SizeMode = PictureBoxSizeMode.StretchImage;
            slot3.SizeMode = PictureBoxSizeMode.StretchImage;

            string[,] user_slot = new string[1, 3];

            // Slot 1 Animation
            for (int i = 1; i <= 15; i++)
            {
                string randomImagePath_1 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
                slot1.Image = Image.FromFile(randomImagePath_1);

                if (i == 15)
                {
                    user_slot[0, 0] = Path.GetFileName(randomImagePath_1);
                    break;
                }

                string randomImagePath_2 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
                string randomImagePath_3 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
                slot2.Image = Image.FromFile(randomImagePath_2);
                slot3.Image = Image.FromFile(randomImagePath_3);

                await Task.Delay(125);
            }

            // Slot 2 Animation
            for (int i = 1; i <= 10; i++)
            {
                string randomImagePath_2 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
                slot2.Image = Image.FromFile(randomImagePath_2);

                if (i == 10)
                {
                    user_slot[0, 1] = Path.GetFileName(randomImagePath_2);
                    break;
                }

                string randomImagePath_3 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
                slot3.Image = Image.FromFile(randomImagePath_3);

                await Task.Delay(125);
            }

            // Slot 3 Animation
            for (int i = 1; i <= 10; i++)
            {
                string randomImagePath_3 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
                slot3.Image = Image.FromFile(randomImagePath_3);

                if (i == 10)
                {
                    user_slot[0, 2] = Path.GetFileName(randomImagePath_3);
                    break;
                }

                await Task.Delay(125);
            }

            // Check for winning combinations
            string s1 = user_slot[0, 0];
            string s2 = user_slot[0, 1];
            string s3 = user_slot[0, 2];
            int winAmount = 0;

            // Three 7s (jackpot)
            if (s1 == "seven.png" && s2 == "seven.png" && s3 == "seven.png")
            {
                winAmount = 5000;
            }
            else
            {
                switch (currentBetIndex)
                {
                    case 0: // Bet 25
                        if ((s1 == "cherries.png" && s2 == "cherries.png") ||
                            (s2 == "cherries.png" && s3 == "cherries.png") ||
                            (s1 == "cherries.png" && s2 == "cherries.png" && s3 == "cherries.png") ||
                            (s1 == "seven.png" && s2 == "seven.png") ||
                            (s2 == "seven.png" && s3 == "seven.png"))
                        {
                            winAmount = 30;
                        }
                        break;
                    case 1: // Bet 50
                        if ((s1 == "cherries.png" && s2 == "cherries.png") ||
                            (s2 == "cherries.png" && s3 == "cherries.png") ||
                            (s1 == "cherries.png" && s2 == "cherries.png" && s3 == "cherries.png") ||
                            (s1 == "orange.png" && s2 == "orange.png") ||
                            (s2 == "orange.png" && s3 == "orange.png") ||
                            (s1 == "orange.png" && s2 == "orange.png" && s3 == "orange.png") ||
                            (s1 == "seven.png" && s2 == "seven.png") ||
                            (s2 == "seven.png" && s3 == "seven.png"))
                        {
                            winAmount = 60;
                        }
                        break;
                    case 2: // Bet 100
                        string[] validSymbols = { "cherries.png", "orange.png", "diamond.png", "bar.png", "seven.png", "bell.png" };
                        bool threeMatch = validSymbols.Contains(s1) && s1 == s2 && s2 == s3;
                        bool firstSecondMatch = validSymbols.Contains(s1) && s1 == s2;
                        bool secondThirdMatch = validSymbols.Contains(s2) && s2 == s3;

                        if (threeMatch || firstSecondMatch || secondThirdMatch)
                        {
                            winAmount = 120;
                        }
                        break;
                }
            }

            // Update credits and display win
            creditsBalance += winAmount;
            label_creditsAmount.Text = creditsBalance.ToString();
            label_winAmount.Text = winAmount > 0 ? $"{winAmount}" : "_";

            // Update undo button visibility
            bool showUndo = creditsBalance < choiceOfBet;
            IsVisibleEnableButtonUndo(showUndo);

            // Show withdraw button after first spin
            hasSpunOnce = true;
            IsVisibleEnableButton(hasSpunOnce);

            if (creditsBalance >= choiceOfBet)
            {
                IsVisibleEnableLever(true);
                IsVisibleEnableButtonInsertMoney(true);
            }
        }
        private void IsVisibleEnableLabelIntro(bool x)
        {
            label_subIntro.Visible = x;
            label_subIntro.Enabled = x;
            label_calculation.Visible = x;
            label_calculation.Enabled = x;
        }

        private void button_insertMoney_Click(object sender, EventArgs e)
        {
            if (insertMoneyForm.ShowDialog() == DialogResult.OK)
            {

                if (int.TryParse(insertMoneyForm.userMoneyAmount, out insertAmount))
                {
                    if (insertAmount < 100)
                    {
                        MessageBox.Show("Invalid amount. Minimum amount to insert is ₱100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (insertAmount > 500)
                    {
                        MessageBox.Show("Invalid amount. Maximum amount to insert is ₱500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (insertAmount > userBalance)
                    {
                        MessageBox.Show("Insufficient wallet balance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (insertAmount % 5 != 0)
                    {
                        MessageBox.Show("Invalid amount. Please insert a multiple of 25 (e.g., ₱150, ₱275, ₱300).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        userBalance -= insertAmount;
                        slotBalance += insertAmount;
                        creditsBalance += (insertAmount * 4);
                        MessageBox.Show("Slot Balance set to: " + slotBalance);
                        label_creditsAmountUpdate();
                        label_userWalletUpdate();
                        label_slotBalanceUpdate();
                        if (creditsBalance >= choiceOfBet)
                        {
                            IsVisibleEnableLever(true);
                        }
                        else
                        {
                            IsVisibleEnableLever(false);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void IsVisibleEnableLabel(bool x)
        {
            label_slotBalance.Visible = x;
            label_slotBalance.Enabled = x;
            label_BALANCE.Visible = x;
            label_BALANCE.Enabled = x;
            label_creditsAmount.Visible = x;
            label_creditsAmount.Enabled = x;
            label_CREDITS.Visible = x;
            label_CREDITS.Enabled = x;
            label_betAmount.Visible = x;
            label_betAmount.Enabled = x;
            label_BET.Visible = x;
            label_BET.Enabled = x;
            label_winAmount.Visible = x;
            label_winAmount.Enabled = x;
            label_WIN.Visible = x;
            label_WIN.Enabled = x;
        }
        private void IsVisibleEnableButton(bool x)
        {
            button_withdraw.Visible = x;
            button_withdraw.Enabled = x;
        }
        private void IsVisibleEnableRightLeft(bool x)
        {
            button_right.Enabled = x;
            button_right.Visible = x;
            button_left.Enabled = x;
            button_left.Visible = x;
        }
        private void IsVisibleEnableLever(bool x)
        {
            button_spin.Visible = x;
            button_spin.Enabled = x;
        }
        private void IsVisibleEnableGoldButton(bool x)
        {
            button_select.Visible = x;
            button_select.Enabled = x;
        }
        private void IsVisibleEnableButtonUp(bool x)
        {
            button_up.Visible = x;
            button_up.Enabled = x;
        }
        private void IsVisibleEnableButtonUndo(bool x)
        {
            button_undo.Enabled = x;
            button_undo.Visible = x;
        }
        private void IsVisibleEnableButtonInsertMoney(bool x)
        {
            button_insertMoney.Enabled = x;
            button_insertMoney.Visible = x;
        }
        private void gold_button()
        {
            isGameStarted = true;
            IsVisibleEnableLabelIntro(false);
            IsVisibleEnableButton(false);
            IsVisibleEnableLabel(true);
            IsVisibleEnableLever(false);
            IsVisibleEnableRightLeft(true);
            IsVisibleEnableButtonUp(true);
            IsVisibleEnableGoldButton(false);
        }
        private void button_select_Click(object sender, EventArgs e)
        {
            gold_button();
        }
        private void label_subIntro_Click(object sender, EventArgs e)
        {
            UpdateSubLabelIntro();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            await SpinSlots();
        }
        private void label_slotBalanceUpdate()
        { 
            label_slotBalance.Text = ("₱" + slotBalance.ToString());
        }
        private void label_slotBalance_Click(object sender, EventArgs e)
        {
            label_slotBalanceUpdate();
        }

        private void label_creditsAmountUpdate()
        {
            label_creditsAmount.Text = creditsBalance.ToString();
        }
        private void label_betAmount_Click(object sender, EventArgs e)
        {
            label_creditsAmountUpdate();
            
        }


        private void label_betAmountUpdate()
        {

            choiceOfBet = bets[currentBetIndex];
            if (isBetSelected)
            {
                label_betAmount.Text = choiceOfBet.ToString();
            }
            else 
            {
                label_betAmount.Text = ">" + choiceOfBet.ToString() + "<";
            }

        }
        private void label_betAmount_Click_1(object sender, EventArgs e)
        {
            
            label_betAmountUpdate();
        }
        
        private void button_right_Click_1(object sender, EventArgs e)
        {
            if (currentBetIndex < bets.Length - 1)
            {
                currentBetIndex++;
            }
            else
            {
                currentBetIndex = 0; // Wrap around to the first bet amount
            }
            label_betAmountUpdate();
        }
        private void button_left_Click(object sender, EventArgs e)
        {
            if (currentBetIndex > 0 && currentBetIndex < 3)
            {
                currentBetIndex --;
            }
            else
            {
                currentBetIndex = bets.Length - 1; // Wrap around to the last bet amount
            }
            label_betAmountUpdate();

        }
        bool isBetSelected = false;
        private void button_up_Click(object sender, EventArgs e)
        {
            isBetSelected = true;
            IsVisibleEnableRightLeft(false);
            IsVisibleEnableButtonUp(false);
            IsVisibleEnableLever(true);
            IsVisibleEnableButtonInsertMoney(false);
            label_betAmountUpdate();

        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            WithdrawAndRestart();
        }

        private void button_withdraw_Click(object sender, EventArgs e)
        {
            WithdrawAndRestart();
        }

        private void WithdrawAndRestart()
        {
            userBalance += creditsBalance / 5;

            // Reset balances
            slotBalance = 0;
            creditsBalance = 0;
            insertAmount = 0;

            // Update UI
            label_userWalletUpdate();
            label_slotBalanceUpdate();
            label_creditsAmount.Text = "0";
            label_winAmount.Text = "_";

            // Reset game state
            isGameStarted = false;
            isBetSelected = false;
            currentBetIndex = 0;
            label_betAmountUpdate();

            // Reset slot images
            string randomImagePath_1 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
            string randomImagePath_2 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
            string randomImagePath_3 = Path.Combine(imageFolderPath, imageNames[rnd.Next(imageNames.Length)]);
            slot1.Image = Image.FromFile(randomImagePath_1);
            slot2.Image = Image.FromFile(randomImagePath_2);
            slot3.Image = Image.FromFile(randomImagePath_3);

            UpdateSubLabelIntro();
            IsVisibleEnableLabel(false);
            IsVisibleEnableButton(false);
            IsVisibleEnableRightLeft(false);
            IsVisibleEnableLever(false);
            IsVisibleEnableButtonUp(false);
            IsVisibleEnableButtonUndo(false);
            IsVisibleEnableButtonInsertMoney(true);
        }
    }
}
