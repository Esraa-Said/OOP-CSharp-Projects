namespace BankAccountsApp
{
    public partial class Form1 : Form
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

            //BankAccount bankAccount = new BankAccount("Saldina Nurak");
            //BankAccount bankAccount2 = new BankAccount("Elon Musk");
            //BankAccount bankAccount3 = new BankAccount("Bill Gates");



            //bankAccounts.Add(bankAccount);
            //bankAccounts.Add(bankAccount2);
            //bankAccounts.Add(bankAccount3);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BankAccountsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OwnerName.Text))
                return;
            if(InterestRateNum.Value > 0)
            {
                SavingsAccount savingsAccount = new SavingsAccount(OwnerName.Text, InterestRateNum.Value);
                bankAccounts.Add(savingsAccount);

            }
            else 
            {
                BankAccount bankAccount = new BankAccount(OwnerName.Text);
                bankAccounts.Add(bankAccount);
            }
           

            RefreshGrid();
            OwnerName.Text = string.Empty;
            InterestRateNum.Value = 0;
        }

        private void RefreshGrid()
        {
            BankAccountsGrid.DataSource = null;
            BankAccountsGrid.DataSource = bankAccounts;

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;
                string message = selectedBankAccount.Deposit(AmountNum.Value);
                MessageBox.Show(message);
                RefreshGrid();
                AmountNum.Value = 0;
            }

        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (BankAccountsGrid.SelectedRows.Count == 1)
            {
                BankAccount selectedBankAccount = BankAccountsGrid.SelectedRows[0].DataBoundItem as BankAccount;

                string message = selectedBankAccount.Withdraw(AmountNum.Value);
                MessageBox.Show(message);
                RefreshGrid();
                AmountNum.Value = 0;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}