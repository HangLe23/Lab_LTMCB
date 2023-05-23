
namespace Lab01
{
    partial class Lab01_Bai4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Values = new System.Windows.Forms.TextBox();
            this.exchange = new System.Windows.Forms.TextBox();
            this.Results = new System.Windows.Forms.TextBox();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(183, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuyển đổi tiền tệ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền đã đổi(VND)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tỷ giá quy đổi";
            // 
            // Values
            // 
            this.Values.Location = new System.Drawing.Point(234, 101);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(287, 26);
            this.Values.TabIndex = 4;
            // 
            // exchange
            // 
            this.exchange.BackColor = System.Drawing.Color.LightPink;
            this.exchange.Enabled = false;
            this.exchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exchange.Location = new System.Drawing.Point(234, 365);
            this.exchange.Name = "exchange";
            this.exchange.Size = new System.Drawing.Size(287, 26);
            this.exchange.TabIndex = 5;
            // 
            // Results
            // 
            this.Results.Enabled = false;
            this.Results.Location = new System.Drawing.Point(234, 279);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(287, 26);
            this.Results.TabIndex = 6;
            // 
            // Unit
            // 
            this.Unit.FormattingEnabled = true;
            this.Unit.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.Unit.Location = new System.Drawing.Point(559, 99);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(218, 28);
            this.Unit.TabIndex = 7;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(133, 195);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(109, 43);
            this.btnChange.TabIndex = 8;
            this.btnChange.Text = "Chuyển đổi";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(353, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 43);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Xóa";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(579, 195);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 43);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Lab01_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.exchange);
            this.Controls.Add(this.Values);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai4";
            this.Text = "BT4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Values;
        private System.Windows.Forms.TextBox exchange;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.ComboBox Unit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}