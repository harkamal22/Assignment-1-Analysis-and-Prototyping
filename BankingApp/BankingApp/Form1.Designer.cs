namespace BankingApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblAccount;
        private Label lblAmount;
        private Label lblResultTitle;

        private ComboBox comboAccount;
        private TextBox txtAmount;

        private Button btnDeposit;
        private Button btnWithdraw;
        private Button btnInfo;

        private TextBox txtResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblAccount = new Label();
            this.lblAmount = new Label();
            this.lblResultTitle = new Label();

            this.comboAccount = new ComboBox();
            this.txtAmount = new TextBox();

            this.btnDeposit = new Button();
            this.btnWithdraw = new Button();
            this.btnInfo = new Button();

            this.txtResult = new TextBox();

            this.SuspendLayout();

            // Title
            this.lblTitle.Text = "Bank Account Management System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(80, 20);
            this.lblTitle.Size = new System.Drawing.Size(450, 40);

            // Account Label
            this.lblAccount.Text = "Select Account:";
            this.lblAccount.Location = new System.Drawing.Point(60, 100);
            this.lblAccount.Size = new System.Drawing.Size(120, 25);

            // Combo Account
            this.comboAccount.Location = new System.Drawing.Point(200, 100);
            this.comboAccount.Size = new System.Drawing.Size(200, 25);
            this.comboAccount.Items.AddRange(new object[] {
            "Everyday Account",
            "Investment Account",
            "Omni Account"});
            this.comboAccount.SelectedIndex = 0;

            // Amount Label
            this.lblAmount.Text = "Enter Amount:";
            this.lblAmount.Location = new System.Drawing.Point(60, 150);
            this.lblAmount.Size = new System.Drawing.Size(120, 25);

            // Amount TextBox
            this.txtAmount.Location = new System.Drawing.Point(200, 150);
            this.txtAmount.Size = new System.Drawing.Size(200, 25);

            // Deposit Button
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.Location = new System.Drawing.Point(60, 210);
            this.btnDeposit.Size = new System.Drawing.Size(120, 40);
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);

            // Withdraw Button
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Location = new System.Drawing.Point(200, 210);
            this.btnWithdraw.Size = new System.Drawing.Size(120, 40);
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);

            // Account Info Button
            this.btnInfo.Text = "Account Info";
            this.btnInfo.Location = new System.Drawing.Point(340, 210);
            this.btnInfo.Size = new System.Drawing.Size(120, 40);
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);

            // Result Title
            this.lblResultTitle.Text = "Transaction Details";
            this.lblResultTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResultTitle.Location = new System.Drawing.Point(60, 280);
            this.lblResultTitle.Size = new System.Drawing.Size(200, 30);

            // Result TextBox
            this.txtResult.Location = new System.Drawing.Point(60, 320);
            this.txtResult.Size = new System.Drawing.Size(400, 150);
            this.txtResult.Multiline = true;
            this.txtResult.ScrollBars = ScrollBars.Vertical;

            // Form
            this.ClientSize = new System.Drawing.Size(520, 520);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.comboAccount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblResultTitle);
            this.Controls.Add(this.txtResult);

            this.Text = "Banking Application";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}