
namespace Amortization
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loan_amount = new System.Windows.Forms.TextBox();
            this.rebate_amt = new System.Windows.Forms.TextBox();
            this.month_groupBox = new System.Windows.Forms.GroupBox();
            this.two_years = new System.Windows.Forms.RadioButton();
            this.one_year = new System.Windows.Forms.RadioButton();
            this.eighteen_months = new System.Windows.Forms.RadioButton();
            this.six_months = new System.Windows.Forms.RadioButton();
            this.rebate_Check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.display_all = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.APRcomboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.Total_loans = new System.Windows.Forms.TextBox();
            this.Total_interest = new System.Windows.Forms.TextBox();
            this.month_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Annual APR (%)";
            // 
            // loan_amount
            // 
            this.loan_amount.Location = new System.Drawing.Point(117, 92);
            this.loan_amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loan_amount.Name = "loan_amount";
            this.loan_amount.Size = new System.Drawing.Size(113, 21);
            this.loan_amount.TabIndex = 1;
            this.loan_amount.Click += new System.EventHandler(this.loan_amount_Click);
            this.loan_amount.TextChanged += new System.EventHandler(this.loan_amount_TextChanged);
            this.loan_amount.Enter += new System.EventHandler(this.loan_amount_Enter);
            this.loan_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loan_amount_KeyPress);
            // 
            // rebate_amt
            // 
            this.rebate_amt.Enabled = false;
            this.rebate_amt.Location = new System.Drawing.Point(117, 160);
            this.rebate_amt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rebate_amt.Name = "rebate_amt";
            this.rebate_amt.Size = new System.Drawing.Size(113, 21);
            this.rebate_amt.TabIndex = 4;
            this.rebate_amt.Click += new System.EventHandler(this.rebate_amt_Click);
            this.rebate_amt.TextChanged += new System.EventHandler(this.rebate_amt_TextChanged);
            this.rebate_amt.Enter += new System.EventHandler(this.rebate_amt_Enter);
            this.rebate_amt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rebate_amt_KeyPress);
            // 
            // month_groupBox
            // 
            this.month_groupBox.Controls.Add(this.two_years);
            this.month_groupBox.Controls.Add(this.one_year);
            this.month_groupBox.Controls.Add(this.eighteen_months);
            this.month_groupBox.Controls.Add(this.six_months);
            this.month_groupBox.Location = new System.Drawing.Point(287, 85);
            this.month_groupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.month_groupBox.Name = "month_groupBox";
            this.month_groupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.month_groupBox.Size = new System.Drawing.Size(157, 95);
            this.month_groupBox.TabIndex = 5;
            this.month_groupBox.TabStop = false;
            this.month_groupBox.Text = "Loan Months";
            this.month_groupBox.TextChanged += new System.EventHandler(this.month_groupBox_TextChanged);
            // 
            // two_years
            // 
            this.two_years.AutoSize = true;
            this.two_years.Location = new System.Drawing.Point(100, 59);
            this.two_years.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.two_years.Name = "two_years";
            this.two_years.Size = new System.Drawing.Size(35, 16);
            this.two_years.TabIndex = 4;
            this.two_years.TabStop = true;
            this.two_years.Text = "24";
            this.two_years.UseVisualStyleBackColor = true;
            // 
            // one_year
            // 
            this.one_year.AutoSize = true;
            this.one_year.Location = new System.Drawing.Point(27, 59);
            this.one_year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.one_year.Name = "one_year";
            this.one_year.Size = new System.Drawing.Size(35, 16);
            this.one_year.TabIndex = 2;
            this.one_year.TabStop = true;
            this.one_year.Text = "12";
            this.one_year.UseVisualStyleBackColor = true;
            // 
            // eighteen_months
            // 
            this.eighteen_months.AutoSize = true;
            this.eighteen_months.Location = new System.Drawing.Point(100, 25);
            this.eighteen_months.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eighteen_months.Name = "eighteen_months";
            this.eighteen_months.Size = new System.Drawing.Size(35, 16);
            this.eighteen_months.TabIndex = 3;
            this.eighteen_months.TabStop = true;
            this.eighteen_months.Text = "18";
            this.eighteen_months.UseVisualStyleBackColor = true;
            // 
            // six_months
            // 
            this.six_months.AutoSize = true;
            this.six_months.Location = new System.Drawing.Point(27, 25);
            this.six_months.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.six_months.Name = "six_months";
            this.six_months.Size = new System.Drawing.Size(29, 16);
            this.six_months.TabIndex = 1;
            this.six_months.TabStop = true;
            this.six_months.Text = "6";
            this.six_months.UseVisualStyleBackColor = true;
            // 
            // rebate_Check
            // 
            this.rebate_Check.AutoSize = true;
            this.rebate_Check.Location = new System.Drawing.Point(29, 164);
            this.rebate_Check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rebate_Check.Name = "rebate_Check";
            this.rebate_Check.Size = new System.Drawing.Size(66, 16);
            this.rebate_Check.TabIndex = 3;
            this.rebate_Check.Text = "Rebate?";
            this.rebate_Check.UseVisualStyleBackColor = true;
            this.rebate_Check.CheckedChanged += new System.EventHandler(this.rebate_Check_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vehicle Loan Calculator";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(451, 66);
            this.calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(94, 69);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "&Calculate Loan";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(451, 139);
            this.accept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(94, 61);
            this.accept.TabIndex = 7;
            this.accept.Text = "&Accept Loan";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // display_all
            // 
            this.display_all.Location = new System.Drawing.Point(451, 204);
            this.display_all.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.display_all.Name = "display_all";
            this.display_all.Size = new System.Drawing.Size(94, 65);
            this.display_all.TabIndex = 8;
            this.display_all.Text = "&Display All Loans";
            this.display_all.UseVisualStyleBackColor = true;
            this.display_all.Click += new System.EventHandler(this.display_all_Click);
            // 
            // exit
            // 
            this.exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exit.Location = new System.Drawing.Point(451, 273);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(94, 58);
            this.exit.TabIndex = 9;
            this.exit.Text = "&Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 370);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total loans";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 333);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "Total interest";
            // 
            // APRcomboBox
            // 
            this.APRcomboBox.FormattingEnabled = true;
            this.APRcomboBox.Items.AddRange(new object[] {
            "2.5"});
            this.APRcomboBox.Location = new System.Drawing.Point(117, 127);
            this.APRcomboBox.Name = "APRcomboBox";
            this.APRcomboBox.Size = new System.Drawing.Size(113, 20);
            this.APRcomboBox.TabIndex = 2;
            this.APRcomboBox.TextChanged += new System.EventHandler(this.APRcomboBox_TextChanged);
            this.APRcomboBox.Click += new System.EventHandler(this.APRcomboBox_Click);
            this.APRcomboBox.Enter += new System.EventHandler(this.APRcomboBox_Enter);
            this.APRcomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.APRcomboBox_KeyPress);
            // 
            // listBox
            // 
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("Courier New", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(29, 204);
            this.listBox.MultiColumn = true;
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(415, 206);
            this.listBox.TabIndex = 19;
            this.listBox.TabStop = false;
            // 
            // Total_loans
            // 
            this.Total_loans.Enabled = false;
            this.Total_loans.Location = new System.Drawing.Point(451, 384);
            this.Total_loans.Margin = new System.Windows.Forms.Padding(2);
            this.Total_loans.Name = "Total_loans";
            this.Total_loans.Size = new System.Drawing.Size(95, 21);
            this.Total_loans.TabIndex = 15;
            this.Total_loans.TabStop = false;
            // 
            // Total_interest
            // 
            this.Total_interest.Enabled = false;
            this.Total_interest.Location = new System.Drawing.Point(451, 347);
            this.Total_interest.Margin = new System.Windows.Forms.Padding(2);
            this.Total_interest.Name = "Total_interest";
            this.Total_interest.Size = new System.Drawing.Size(95, 21);
            this.Total_interest.TabIndex = 14;
            this.Total_interest.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.exit;
            this.ClientSize = new System.Drawing.Size(561, 444);
            this.ControlBox = false;
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.APRcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total_loans);
            this.Controls.Add(this.Total_interest);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.display_all);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rebate_Check);
            this.Controls.Add(this.month_groupBox);
            this.Controls.Add(this.rebate_amt);
            this.Controls.Add(this.loan_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(13, 40, 13, 13);
            this.Text = "Amortization";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.month_groupBox.ResumeLayout(false);
            this.month_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loan_amount;
        private System.Windows.Forms.TextBox rebate_amt;
        private System.Windows.Forms.GroupBox month_groupBox;
        private System.Windows.Forms.RadioButton two_years;
        private System.Windows.Forms.RadioButton one_year;
        private System.Windows.Forms.RadioButton eighteen_months;
        private System.Windows.Forms.RadioButton six_months;
        private System.Windows.Forms.CheckBox rebate_Check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button display_all;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox APRcomboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox Total_loans;
        private System.Windows.Forms.TextBox Total_interest;
    }
}

