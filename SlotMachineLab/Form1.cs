using System;

namespace SlotMachineLab
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();

        // Keep track of winnings and inserted amounts
        private decimal totalInserted = 0m;
        private decimal amountInserted = 0m;
        private decimal totalWinnings = 0m;

        // List of file paths for slot machine images
        string[] imageFilePaths =
        {
            Directory.GetCurrentDirectory() + @"\resources\Apple.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Banana.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Cherries.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Grapes.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Lemon.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Lime.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Orange.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Pear.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Strawberry.jpg",
            Directory.GetCurrentDirectory() + @"\resources\Watermelon.jpg",
        };

        // Contains refrences to the three slots for easy iteration
        PictureBox[] slotList;

        // Each slot has an ID. Each ID corresponds to what image the slot is on
        int[] slotIds;



        public Form1()
        {
            InitializeComponent();

            // Initialize lists
            slotList = new PictureBox[] { slot1, slot2, slot3 };
            slotIds = new int[slotList.Length];
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            // Checks if the amount entered is a real number and sets the amountInserted variable
            if (validateAmountInserted())
            {
                totalInserted += amountInserted;
                decimal earned = 0;
                Spin();
                switch(CheckForWinner())
                {
                    case 1:
                        // Executes when you get 2 of the same image
                        earned = amountInserted * 2;
                        totalWinnings += earned;
                        MessageBox.Show("You've Earned: " + earned.ToString("C"));
                        break;
                    case 3:
                        // Executes when all 3 slots are the same
                        earned = amountInserted * 6;
                        totalWinnings += earned;
                        MessageBox.Show("You've Earned: " + earned.ToString("C"));
                        break;
                }

            }
            else MessageBox.Show("Invalid Amount Entered");
        }

        // Checks if the amount entered is a real number and sets the amountInserted variable
        private bool validateAmountInserted()
        {
            if (decimal.TryParse(enterAmountBox.Text, out amountInserted)) 
                return true;
            return false;
        }

        // Runs logic for spinning the slots and randomly assigning them
        private void Spin()
        {
            for (int i = 0; i < slotList.Length; i++)
            {
                int randNum = rand.Next(0, imageFilePaths.Length);
                slotIds[i] = randNum;
                slotList[i].Image = Image.FromFile(imageFilePaths[randNum]);
            }
        }

        // Returns the amount of duplicates in the slotIds array
        private int CheckForWinner()
        {
            int duplicates = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (slotIds[i] == slotIds[j])
                    {
                        duplicates++;
                    }
                }
            }
            return duplicates;
        }

        // Displays all final information before closing the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            decimal profit = totalWinnings - totalInserted;
            MessageBox.Show("Total earned: " + totalWinnings.ToString("C") +
                            "\nTotal spent: " + totalInserted.ToString("C") +
                            "\nProfit: " + profit.ToString("C"));
            this.Close();
        }
    }
}
