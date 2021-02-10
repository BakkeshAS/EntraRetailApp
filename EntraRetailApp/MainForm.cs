/* Student Name: Bakkesh Shivakumar Aladahalli
 * Student ID: 20230557
 * Date: 11/01/2021
 * Assignment: 4
 * Assignment: Electronic Point of Sale (EPOS) Application 
 * MainForm.cs */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EntraRetailApp
{
    public partial class MainForm : Form
    {
        #region Global Variables

        /*Global variables*/
        static int SerialNumber = 1, CartRow = 0;
        // Colletions holding the inventory data
        readonly string[] STOCKITEMS = { "Whole Milk", "Fresh Berries", "Apple", "Carrot",
        "Tomato", "Siced Pan", "Free Range Large Eggs", "Free Range Medium Eggs",
        "Cheddar Cheese Red Slice", "Cheddar Cheese White Slice", "Chicken Fillets",
        "Pork Chops", "Whole Chicken", "Bacon Unsmoked", "BBQ Salmon",
        "Pork Sausage", "Mince", "Sunflower Oil", "Organic Sunflower Oil",
        "Vegetable Oil", "Organic Vegetable Oil", "Olive Oil Pure",
        "Olive Oil Extra Virgin", "Kellogg’s Rice Krispices", "Kellogg’s Special K",
        "Kellogg’s Coco Pops","Kellogg’s Wheat Flakes ", "Elica Sparkling Wine",
        "Gilma Dessert Wine", "Desante Rose Wine", "Rockford White Wine", "Rockford Red Wine",
        "Gilma Red Wine"};

        /* Each items are available in variable sizes/Quantity
         * and hence the one that has only two variants will have
         * empty string in the 3rd and 4th column*/
        readonly string[,] STOCKITEMSSIZE = {
            {"1 Litre", "2 Litre", "3 Litre", "" },
            {"250 Grams", "500 Grams", "", "" },
            {"1000 Grams", "2000 Grams", "", "" },
            {"1000 Grams", "2000 Grams", "", "" },
            {"250 Grams", "500 Grams", "1000 Grams", "" },
            {"800 Grams", "", "", "" },
            {"6 Piece", "10 Piece", "12 Piece", "18 Piece" },
            {"6 Piece", "10 Piece", "12 Piece", "18 Piece" },
            {"200 Grams", "400 Grams", "", "" },
            {"200 Grams", "400 Grams", "", "" },
            {"450 Grams", "900 Grams", "", "" },
            {"4 Piece", "8 Piece", "", "" },
            {"1", "", "", "" },
            {"800 Grams", "1400 Grams", "", "" },
            {"100 Grams", "200 Grams", "400 Grams", "" },
            {"450 Grams", "900 Grams", "", "" },
            {"450 Grams", "900 Grams", "", "" },
            {"1 Litre", "", "", "" },
            {"1 Litre", "", "", "" },
            {"1 Litre", "", "", "" },
            {"1 Litre", "", "", "" },
            {"500 Millilitre", "1000 Millilitre", "", "" },
            {"500 Millilitre", "1000 Millilitre", "", "" },
            {"400 Grams", "900 Grams", "", "" },
            {"400 Grams", "900 Grams", "", "" },
            {"400 Grams", "900 Grams", "", "" },
            {"400 Grams", "900 Grams", "", "" },
            {"30cl", "75cl", "", "" },
            {"30cl", "75cl", "", "" },
            {"30cl", "75cl", "", "" },
            {"30cl", "75cl", "", "" },
            {"30cl", "75cl", "", "" },
            {"30cl", "75cl", "", "" }
        };

        /* Each items are available in variable sizes/Quantity
         * and respective prices. Hence the one that has only two 
         * variants will have 0 in the 3rd and 4th column */
        readonly decimal[,] STOCKITEMSPRICE = {
            {1, 1.5m, 2, 0 },
            {4, 6.5m,0 , 0},
            {2, 3, 0, 0},
            {1, 1.75m, 0, 0 },
            {1, 2, 3, 0 },
            {1.5m, 0, 0, 0 },
            {2, 2.8m, 3.2m, 4 },
            {1.6m, 2, 2.6m, 3.2m },
            {2, 3.2m, 0, 0},
            {2, 3.2m, 0, 0},
            {4, 6, 0, 0},
            {4, 7, 0, 0},
            {5, 0, 0, 0},
            {4, 6, 0, 0},
            {4, 6, 10, 0},
            {2, 3.5m, 0, 0},
            {3, 4.5m, 0, 0},
            {1.95m, 0, 0, 0},
            {3.95m, 0, 0, 0},
            {1.95m, 0, 0, 0},
            {3.95m, 0, 0, 0},
            {2.55m, 3.95m, 0, 0},
            {2.85m, 4.55m, 0, 0},
            {3.49m, 6, 0, 0},
            {3.12m, 6.49m, 0, 0},
            {3.85m, 5.45m, 0, 0},
            {3.95m, 6.25m, 0, 0},
            {8, 18, 0, 0},
            {9, 20, 0, 0},
            {7, 18, 0, 0},
            {6, 16, 0, 0},
            {5, 12, 0, 0},
            {3, 8, 0, 0}
        };


        const int STOCKSIZE = 67, //Total Items alond with different sizes in the Shop.
            TOTALITEMS = 33,      // total unique items in the shop.
            SIZES = 4,            // Items sizes are available upto 4 sizes as of now in the shop.
            CARTSIZE = 5,         // There are 5 values(Columns) in any cart's Row.
            SALESDATACOLUMNS = 8; /* Once sale happens the Transaction ID, Sl.No., 
                                   * Total Price, and the Date Column Vales are added */

        // Text file names
        const string STOCKFILENAME = "Stocks.txt", // Read in or out the stock values.
            TRANSACTIONFILENAME = "Transactions.txt", // Read in or out the Transactions.
            SALESREPORTNAME = "SalesReport"; /* A part of the file name that is used in 
                                              * creation of Daily Sales Report. */
        // 
        decimal TotalCostOfCart = 0m;

        // ************Collections***************
        /* As of now company has 67 items, the stock of each
        * is maintained in the collection below.
        * ItemsStock[Row,Col], here Row is Item and 
        * Col is Size of an Item, Eg: Item: Whole Milk, 
        * Avalable in three sizes viz: 1 Litre, 2Litre, 3Litre. But we
        * have four Col as we dont have the fourth Size we save 0 in it. */
        int[,] ItemsStock = new int[TOTALITEMS, SIZES];

        // this array is used to restore the stock value if there
        // is an incomplete transaction
        int[,] ClearItemsStock = new int[TOTALITEMS, SIZES];

        /* Here in our case the cart size can not exceed 67
         * and each item in the cart has five elements- Sl.No.,
         * Item, Size, Quantity, Price.  */
        string[,] CartItems = new string[STOCKSIZE, CARTSIZE];

        //collection used to chceck the uniqueness of Transaction IDs
        List<string> TransactionIDs = new List<string>();

        //collection for the transactions
        string[] TransactionArray = new string[8];
        List<string[]> TransactionsData = new List<string[]>();

        // cost of the individual items in the cart - collection
        List<decimal> CartItemsCost = new List<decimal>();

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region User Defined Functions

        /* will update the stock quantity in 
         * QuantityStockPriceListBox */
        private void UpdateQuantityStockPrice()
        {
            string QuantityStockPrice = "";
            int Row = StockItemsListBox.SelectedIndex;

            // Clear the items in the listview before updating it.
            QuantityStockPriceListBox.Items.Clear();
            if (Row != -1)
            {
                for (int Column = 0; Column < SIZES; Column++)
                {
                    if (STOCKITEMSSIZE[Row, Column] != "" && STOCKITEMSPRICE[Row, Column] != 0)
                    {
                        QuantityStockPrice = STOCKITEMSSIZE[Row, Column] + "\t" +
                        ItemsStock[Row, Column] + "\t" +
                        STOCKITEMSPRICE[Row, Column].ToString("C2");
                        // Add to QuantityStockPriceListBox
                        QuantityStockPriceListBox.Items.Add(QuantityStockPrice);
                    }
                }
            }
        }

        /* Clear */
        private void Clear()
        {
            CartListView.Items.Clear();
            TotalCostLabel.Text = (0.00).ToString("C2");
            QuantityStockPriceListBox.Items.Clear();
            StockItemsListBox.SelectedIndex = 0;
            StockItemsListBox_SelectedIndexChanged(null, null);
            Array.Clear(CartItems, 0, CartItems.Length);
            SerialNumber = 1;
            CartRow = 0;
            ConfirmButton.Enabled = false;
            TransactionIDsListBox.Items.Clear();
            CartItemsCost.Clear();
        }

        #endregion

        #region Event Handlers
        // when MainForm loads for very first time, this event is triggered.
        /* Stock items are populated in StockItemsListBox,
         * the item stock quantity is read in from the text file - Stocks 
         * and also load the historical transactions into a collection - TransactionsData*/
        private void MainForm_Load(object sender, EventArgs e)
        {
            // reading the stock values into a collection
            StreamReader InputTextFile;
            InputTextFile = File.OpenText(STOCKFILENAME);
            while (!InputTextFile.EndOfStream)
            {
                try
                {
                    for (int Row = 0; Row < TOTALITEMS; Row++)
                    {
                        for (int Column = 0; Column < SIZES; Column++)
                        {
                            /* check for the existance of an item so that 
                             * the correspond stock value can be added*/
                            if (STOCKITEMSSIZE[Row, Column] != "" && STOCKITEMSPRICE[Row, Column] != 0)
                            {
                                ItemsStock[Row, Column] = Int32.Parse(InputTextFile.ReadLine());
                                ClearItemsStock[Row, Column] = ItemsStock[Row, Column];
                            }
                            else
                            {
                                /* if there in no value for this cloumn then 
                                 * it means that there is no corresponding item 
                                 * hence add -1, which is used in the computation later*/
                                ItemsStock[Row, Column] = -1;
                                ClearItemsStock[Row, Column] = -1;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error Contact your IT team",
                        "Error Message!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            // close the file connection
            InputTextFile.Close();

            // populate Transactions Collection
            InputTextFile = File.OpenText(TRANSACTIONFILENAME);
            while (!InputTextFile.EndOfStream)
            {
                string[] TransactionItem = new string[8];

                try
                {
                    for (int Index = 0; Index < 8; Index++)
                    {
                        TransactionItem[Index] = InputTextFile.ReadLine();
                    }
                    /* Transaction ids are stored here for the purpose of generating 
                     * Unique Transaction IDs. */
                    TransactionIDs.Add(TransactionItem[0]);
                    TransactionsData.Add(TransactionItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("System Error Contact your IT team",
                        "Error Message!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            InputTextFile.Close();

            // Adding items to StockItemsListBox
            foreach (string Items in STOCKITEMS)
            {
                StockItemsListBox.Items.Add(Items);
            }
            // select first item by default
            StockItemsListBox.SelectedIndex = 0;
        }

        /* The corresponding details of the Item selected is shown in 
         * the QuantityStockPriceListBox*/
        private void StockItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateQuantityStockPrice();

            // to disable the add button
            AddButton.Enabled = false;
        }

        /* Minor UI changes to the Add Button is made depending on the stock availibility */
        private void QuantityStockPriceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if we accidentally click on the empty space in the listbox then the selected index will be -1 
             * and that creates "index out of bound" issue with the index of an array*/
            if (StockItemsListBox.SelectedIndex >= 0 && QuantityStockPriceListBox.SelectedIndex >= 0)
            {
                if (ItemsStock[StockItemsListBox.SelectedIndex, QuantityStockPriceListBox.SelectedIndex] > 0)
                {
                    AddButton.Enabled = true;
                    AddButton.Focus();
                }
                else
                    AddButton.Enabled = false;
            }

        }

        /* After selection of Item and Size, when the add button is clicked
         * The cart is populated and if the same item is added again then the quantity 
         * is updated, if the max available stock is utilized then the add button is 
         * disabled */
        private void AddButton_Click(object sender, EventArgs e)
        {
            //local variables
            bool SearchFound = true;

            int Row = StockItemsListBox.SelectedIndex,
                Column = QuantityStockPriceListBox.SelectedIndex,
                ItemStock, ItemInCart = 1, QuantitySelectedIndex,
                Quantity;

            decimal TotalCostOfItem, CalculateCost = 0m;

            /* UI: Add Button - if a perticular item's size is selected 
             * and that size is not available in the stock the Add Button disables */
            if (ItemsStock[Row, Column] == 0)
                AddButton.Enabled = false;

            ItemStock = ItemsStock[Row, Column];
            TotalCostOfItem = STOCKITEMSPRICE[Row, Column];

            // check for stock availability, then add to cart
            if (ItemStock > 0)
            {
                // check if the item already exist in the cart
                for (int SearchRow = 0; SearchRow < STOCKSIZE; SearchRow++)
                {
                    if (CartItems[SearchRow, 1] == STOCKITEMS[Row] &&
                        CartItems[SearchRow, 2] == STOCKITEMSSIZE[Row, Column])
                    {
                        Quantity = Int32.Parse(CartItems[SearchRow, 3]);
                        Quantity += 1;
                        CartItems[SearchRow, 3] = Quantity.ToString();
                        CartListView.Items.RemoveAt(SearchRow);
                        SearchFound = true;
                        break;
                    }
                    else
                    {
                        SearchFound = false;
                    }
                    /* if the CartItems is empty/null after a perticular RowIndex
                     * there is no point in iterating any further hence break */
                    if (null == CartItems[SearchRow, 0])
                    {
                        break;
                    }
                }
                if (!SearchFound)
                {
                    //Updating the cart array
                    CartItems[CartRow, 0] = (SerialNumber++).ToString();
                    CartItems[CartRow, 1] = STOCKITEMS[Row];
                    CartItems[CartRow, 2] = STOCKITEMSSIZE[Row, Column];
                    CartItems[CartRow, 3] = ItemInCart.ToString();
                    CartItems[CartRow++, 4] = TotalCostOfItem.ToString("C2");
                }

                // updating the cost of cart array
                CartItemsCost.Add(TotalCostOfItem);

                // updating the Stock array
                ItemsStock[Row, Column] = ItemStock - 1;

                /* Listview is cleared so that it will be populated with 
                 * the updated values. */
                CartListView.Items.Clear();

                // Update the Cart ListView and refresh ListView
                string[] CartItem = new string[CARTSIZE];
                for (int RowIndex = 0; RowIndex < TOTALITEMS; RowIndex++)
                {
                    if (null == CartItems[RowIndex, 0])
                    {
                        break;
                    }
                    for (int Index = 0; Index < CARTSIZE; Index++)
                    {
                        CartItem[Index] = CartItems[RowIndex, Index];
                    }
                    ListViewItem CartListViewItem = new ListViewItem(CartItem);
                    CartListView.Items.Add(CartListViewItem);
                }
                // Total cart items cost calculation & display
                foreach (decimal Item in CartItemsCost)
                {
                    CalculateCost += Item;
                }
                TotalCostOfCart = CalculateCost;
                TotalCostLabel.Text = TotalCostOfCart.ToString("C2");
                CalculateCost = 0;

                // updating QuantityStockPriceListBox
                QuantitySelectedIndex = QuantityStockPriceListBox.SelectedIndex;
                UpdateQuantityStockPrice();
                //UI: to keep selection of the selected size in the ListBx 
                QuantityStockPriceListBox.SelectedIndex = QuantitySelectedIndex;

                /* when an item is added to the cart
                 * confirm button is enabled*/
                ConfirmButton.Enabled = true;
            }
        }

        /* when Confirm button is pressed a confirmation messaage with cart details and 
         * Unique Transaction ID pops up, 
         * on confirmation the quantity of the items are deducted from the stock
         * collection and the Transaction details is pushed to the Transactions.txt file */
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            /* Unique Random number is generated as transaction ID */
            bool RandomnessFlag = true;
            string TransactionID = "";
            Random RandomNumber = new Random();
            while (RandomnessFlag)
            {
                TransactionID = RandomNumber.Next(0, 999999).ToString("D6");

                if (!TransactionIDs.Contains(TransactionID))
                {
                    RandomnessFlag = false;
                }
            }

            StringBuilder ItemsConfirmation = new StringBuilder();
            for (int RowIndex = 0; RowIndex < STOCKSIZE; RowIndex++)
            {
                if (CartItems[RowIndex, 0] == null)
                {
                    break;
                }
                ItemsConfirmation.Append("Item: " + CartItems[RowIndex, 0] + ", ");
                for (int ColIndex = 1; ColIndex < 3; ColIndex++)
                {
                    ItemsConfirmation.Append(CartItems[RowIndex, ColIndex] + ", ");
                }
                ItemsConfirmation.Append("Quantity: " + CartItems[RowIndex, 3] + ", ");
                ItemsConfirmation.Append("Price per unit: " + CartItems[RowIndex, 4]);
                ItemsConfirmation.AppendLine();
                ItemsConfirmation.AppendLine();
            }
            var result = MessageBox.Show("Transaction Number: " +
                                      TransactionID +
                                      Environment.NewLine +
                                      Environment.NewLine +
                                      ItemsConfirmation +
                                      Environment.NewLine + "Total Cart Cost: " +
                                      TotalCostOfCart.ToString("C2") +
                                      Environment.NewLine +
                                      Environment.NewLine +
                                      "Press OK button to Confirm " +
                                                        "the Purchase",
                                      "Purchase Confirmation !",
                                      MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Information);

            // If the OK button is pressed ...
            if (result == DialogResult.OK)
            {
                // Transaction getting stored in collection and text file 
                try
                {
                    StreamWriter OutputTextFile;
                    OutputTextFile =
                        File.AppendText(TRANSACTIONFILENAME);
                    for (int i = 0; i < CartListView.Items.Count; i++)
                    {
                        string[] TransactionBlock = new string[8];
                        TransactionBlock[0] = TransactionID;
                        for (int k = 0; k < CartListView.Items[i].SubItems.Count; k++)
                        {
                            TransactionBlock[k + 1] = CartListView.Items[i].SubItems[k].Text;
                        }
                        TransactionBlock[6] = TotalCostOfCart.ToString("C2");
                        TransactionBlock[7] = DateTime.Now.ToString("dd/MM/yyyy");

                        TransactionIDs.Add(TransactionBlock[0]);
                        TransactionsData.Add(TransactionBlock);

                        // write to txt file
                        for (int ik = 0; ik < 8; ik++)
                        {
                            OutputTextFile.WriteLine(TransactionBlock[ik]);
                        }
                    }
                    // close the file connection
                    OutputTextFile.Close();
                    MessageBox.Show("Transaction Completed & Saved Successfully!",
                        "Alert Message!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Transaction",
                        "Error Message!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // Clearing form for next user using ClearButton_Click()
                Clear();
            }

            // will update the current stock values to ClearStock Array.
            for (int Row = 0; Row < TOTALITEMS; Row++)
            {
                for (int Column = 0; Column < SIZES; Column++)
                {
                    ClearItemsStock[Row, Column] = ItemsStock[Row, Column];
                }
            }
        }


        /* this event handeller helps in search by date functionality */
        private void SearchNowButton_Click(object sender, EventArgs e)
        {
            int SerialNumber = 1;
            string[] TransactionItem = new string[CARTSIZE];

            // search the transactions by date
            foreach (string[] Item in TransactionsData)
            {
                if (SearchDateTimePicker.Value.ToString("dd/MM/yyyy") == Item[7])
                {
                    TransactionItem[0] = SerialNumber.ToString();
                    for (int TransactionRow = 1; TransactionRow < CARTSIZE; TransactionRow++)
                    {
                        TransactionItem[TransactionRow] = Item[TransactionRow + 1];
                    }
                    TotalCostLabel.Text = Item[6];
                    SerialNumber++;
                    
                    // add items to list view and update the date label
                    ListViewItem CartListViewItem = new ListViewItem(TransactionItem);
                    CartListView.Items.Add(CartListViewItem);
                    SearchDateLabel.Text = Item[7];
                }
            }

            // if there are no search results then show appropriate message.
            if (SerialNumber == 1)
            {
                MessageBox.Show("No Transactions found for this date " +
                                   Environment.NewLine,
                                   "Alert!",
                                   MessageBoxButtons.OKCancel,
                                   MessageBoxIcon.Information);
            }
        }

        /* This will do minor tweeks in the UI to accommodate the Search Group box 
         * with transaction IDs listBox, which will be populated*/
        private void SearchButton_Click(object sender, EventArgs e)
        {
            /* Shopping Group Box inVisible
             * Search Group Box visible*/
            ShoppingGroupBox.Visible = false;
            SearchGroupBox.Visible = true;
            SearchItemLabel.Visible = true;
            TransactionIDRadioButton_CheckedChanged(null, null);
        }
        
        /* this event tracks the change of selection of the Search by TransactionID radio button 
         * when the rodio button is checked the Transaction IDs are shown in the ListBox for the user to select */
        private void TransactionIDRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // if Transaction ID radiobutton is checked
            if (TransactionIDRadioButton.Checked)
            {
                // UI: hide search by date functionality
                SearchNowButton.Visible = false;
                SearchDatesLabel.Visible = false;
                SearchDateTimePicker.Visible = false;

                TransactionLabel.Visible = true;
                TransactionIDsListBox.Visible = true;
                TotalCostLabel.Visible = true;
                TotaLabel.Visible = true;

                // clear the list view for new search 
                CartListView.Items.Clear();
                TotalCostLabel.Text = (0.00).ToString("C2");
                DateLabel.Visible = false;
                SearchDateLabel.Visible = false;

                // populate theTransaction IDs in the listbox
                foreach (string Item in TransactionIDs)
                {
                    if (!TransactionIDsListBox.Items.Contains(Item))
                        TransactionIDsListBox.Items.Add(Item);
                }
            }
        }

        /* this event tracks the change of selection of the Search by date radio button 
         * when the rodio button is checked the Transaction IDs Listbox is hidden
         * and the date picked is made visible for the user */
        private void DateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // if Date radiobutton is checked
            if (DateRadioButton.Checked)
            {
                // UI: hide search by ID functionality
                TransactionLabel.Visible = false;
                TransactionIDsListBox.Visible = false;

                // UI: show the search by date functionaliy
                SearchNowButton.Visible = true;
                SearchDatesLabel.Visible = true;
                SearchDateTimePicker.Visible = true;

                // Clear and populate the list view with the transaction details
                DateLabel.Visible = false;
                SearchDateLabel.Visible = false;
                CartListView.Items.Clear();
                TotalCostLabel.Text = (0.00).ToString("C2");
                DateLabel.Visible = false;
                SearchDateLabel.Visible = false;
                TotalCostLabel.Visible = false;
                TotaLabel.Visible = false;
            }
        }

        /* When a Transaction ID is selected the corresponding items in that ID will 
         * be displayed in the LIstView with the total cost of the transaction*/
        private void TransactionIDsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SerialNumber = 1;
            // Clear and populate the list view with the transaction details
            CartListView.Items.Clear();
            DateLabel.Visible = true;
            SearchDateLabel.Visible = true;
            string[] TransactionItem = new string[CARTSIZE];
            foreach (string[] Item in TransactionsData)
            {
                if (TransactionIDsListBox.SelectedItem.ToString() == Item[0])
                {
                    TransactionItem[0] = SerialNumber.ToString();
                    for (int TransactionRow = 1; TransactionRow < CARTSIZE; TransactionRow++)
                    {
                        TransactionItem[TransactionRow] = Item[TransactionRow + 1];
                    }
                    TotalCostLabel.Text = Item[6];
                    SerialNumber++;
                    ListViewItem CartListViewItem = new ListViewItem(TransactionItem);
                    CartListView.Items.Add(CartListViewItem);
                    SearchDateLabel.Text = Item[7];
                }

            }
        }

        /* Clears the form to next user */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // will get back the previous stock values of an unsuccessful transaction.
            for (int Row = 0; Row < TOTALITEMS; Row++)
            {
                for (int Column = 0; Column < SIZES; Column++)
                {
                    ItemsStock[Row, Column] = ClearItemsStock[Row, Column];
                }
            }
            Clear();

            /* Shopping Group Box Visible
             * Search Group Box invisible*/
            ShoppingGroupBox.Visible = true;
            SearchGroupBox.Visible = false;
            SearchItemLabel.Visible = false;
            DateLabel.Visible = false;
            SearchDateLabel.Visible = false;
        }

        /* When a specific transaction is selected form transactions ID ListBox
         * the details of the same is displayed in the listView */
        private void ManagementReportButton_Click(object sender, EventArgs e)
        {
            int SerialNo = 0;

            Opacity = .75; //UI: MainForm's opacity changes to 75%
            ManagementReportForm ManagementReport = new ManagementReportForm();

            for (int Row = 0; Row < TOTALITEMS; Row++)
            {
                for (int Col = 0; Col < SIZES; Col++)
                {
                    if (ItemsStock[Row, Col] != -1)
                    {
                        string[] ReportItem = new string[CARTSIZE];
                        ReportItem[0] = (++SerialNo).ToString();                  // Sl.No.
                        ReportItem[1] = STOCKITEMS[Row];                          // Item
                        ReportItem[2] = STOCKITEMSSIZE[Row, Col];                 // Size
                        ReportItem[3] = ItemsStock[Row, Col].ToString();          // Stock
                        ReportItem[4] = STOCKITEMSPRICE[Row, Col].ToString("C2"); // Price

                        ManagementReport.ReportData.Add(ReportItem);

                    }
                }
            }
            ManagementReport.ShowDialog();
            Opacity = 1; //UI: MainForm's opacity changes to 100%
        }

        /* A message box pops asking for the confirmation to created daily sales report
         * if user confirms the same is created in a text file and the file opens*/
        private void DailyReportButton_Click(object sender, EventArgs e)
        {
            //confirm before creating a daily report
            var result = MessageBox.Show("Press OK button to Generate " +
                                                            "Daily Sales Report" +
                                          Environment.NewLine,
                                          "Daily Sales Report!",
                                          MessageBoxButtons.OKCancel,
                                          MessageBoxIcon.Information);

            // If the OK button is pressed ...
            if (result == DialogResult.OK)
            {
                // if result is true then only create the local variables
                bool ItemExistFlag = false;
                int SerialNumber = 1, ItemQuantity;
                string DateWithTime = DateTime.Now.ToString("dd/MM/yyyy h:mm tt"),
                       TextFileName = SALESREPORTNAME + " - " +
                                      DateTime.Now.ToString("dddd, dd MMMM yyyy") +
                                      ".txt", Formatter = "";

                List<string[]> WriteToFileItems = new List<string[]>();

                foreach (string[] Item in TransactionsData)
                {
                    string[] TransactionItem = new string[CARTSIZE];
                    if (Item[7] == DateTime.Now.ToString("dd/MM/yyyy"))
                    {
                        for (int Index = 0; Index < CARTSIZE; Index++)
                        {
                            TransactionItem[Index] = Item[Index + 2];
                        }
                        TransactionItem[4] = Item[7];

                        foreach (string[] Block in WriteToFileItems)
                        {
                            if (Block[0] == TransactionItem[0] && Block[1] == TransactionItem[1])
                            {
                                ItemQuantity = Int32.Parse(Block[2]);
                                ItemQuantity += Int32.Parse(TransactionItem[2]);
                                Block[2] = ItemQuantity.ToString();
                                ItemExistFlag = true;
                            }
                        }

                        if (!ItemExistFlag)
                        {
                            WriteToFileItems.Add(TransactionItem);
                        }
                        ItemExistFlag = false;
                    }
                }

                // Transaction getting saved 
                try
                {
                    StreamWriter OutputTextFile;
                    OutputTextFile =
                        File.CreateText(TextFileName);
                    OutputTextFile.WriteLine("\t\t\t\t Daily Sales Report");
                    OutputTextFile.WriteLine("\t\t Report Generation Date & Time: " +
                                    DateTime.Now.ToString("dd/MM/yyyy h:mm tt"));
                    // add an empty line
                    OutputTextFile.WriteLine();
                    OutputTextFile.Write("Sl.No. \t");
                    OutputTextFile.Write("Item: \t\t\t");
                    OutputTextFile.Write("Size: \t\t");
                    OutputTextFile.Write("Quantity Sold: \t");
                    OutputTextFile.Write("Price: \t");
                    OutputTextFile.WriteLine();
                    foreach (string[] Item in WriteToFileItems)
                    {
                        if (Item[4] == DateTime.Now.ToString("dd/MM/yyyy"))
                        {
                            OutputTextFile.Write(SerialNumber + "\t");
                            // for the proper alignment of the text in the text file
                            Formatter = Item[0];
                            if (Formatter.Length < 26)
                            {
                                for (int Length = Formatter.Length; Length <= 26; Length++)
                                {
                                    Formatter += "  ";
                                }
                            }
                            OutputTextFile.Write(Formatter + "\t");
                            Formatter = Item[1];
                            if (Formatter.Length < 15)
                            {
                                for (int Length = Formatter.Length; Length <= 15; Length++)
                                {
                                    Formatter += "  ";
                                }
                            }
                            OutputTextFile.Write(Formatter + "\t");
                            OutputTextFile.Write(Item[2] + "\t\t");
                            OutputTextFile.Write(Item[3] + "\t");
                            OutputTextFile.WriteLine();
                            SerialNumber++;
                        }
                    }
                    OutputTextFile.Close();

                    // open the sales report
                    Process.Start(TextFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " +
                         "Unable to Generate Sales Report " +
                         Environment.NewLine +
                         "Contact IT Support Team!",
                         "Error Message!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /* The closing stock is read out to the file - Stocks.txt */
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            // works for both Exit button and the cross 
            // Transaction getting stored in collection and text file 
            try
            {
                StreamWriter OutputTextFile;
                OutputTextFile =
                    File.CreateText(STOCKFILENAME);
                for (int RowIndex = 0; RowIndex < TOTALITEMS; RowIndex++)
                {
                    for (int ColumnIndex = 0; ColumnIndex < 4; ColumnIndex++)
                    {
                        if (ItemsStock[RowIndex, ColumnIndex] != -1)
                        {
                            OutputTextFile.WriteLine(ItemsStock[RowIndex, ColumnIndex]);
                        }
                    }
                }
                // close the file connection
                OutputTextFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Transaction",
                       "Error Message!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
            }
        }

        /* When user clicks the Exit button the function Close()
         * is called and the application closes after executing the 
         * MainForm_Closing event*/
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
