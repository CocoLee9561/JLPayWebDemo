namespace JlpayDemoForms
{
    partial class Form1
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
            this.Micropay_Btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Micropayasyn_Btn = new System.Windows.Forms.Button();
            this.Qrcodepay_Btn = new System.Windows.Forms.Button();
            this.QueryOrder_Btn = new System.Windows.Forms.Button();
            this.RefundOrder_Btn = new System.Windows.Forms.Button();
            this.CancelOrder_Btn = new System.Windows.Forms.Button();
            this.AppPay_Btn = new System.Windows.Forms.Button();
            this.OfficialPay_Btn = new System.Windows.Forms.Button();
            this.WapH5Pay_Btn = new System.Windows.Forms.Button();
            this.ChnQuery_Btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Micropay_Btn
            // 
            this.Micropay_Btn.Location = new System.Drawing.Point(43, 158);
            this.Micropay_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Micropay_Btn.Name = "Micropay_Btn";
            this.Micropay_Btn.Size = new System.Drawing.Size(100, 29);
            this.Micropay_Btn.TabIndex = 0;
            this.Micropay_Btn.Text = "扫码付";
            this.Micropay_Btn.UseVisualStyleBackColor = true;
            this.Micropay_Btn.Click += new System.EventHandler(this.Micropay_Btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 97);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 25);
            this.textBox1.TabIndex = 1;
            // 
            // Micropayasyn_Btn
            // 
            this.Micropayasyn_Btn.Location = new System.Drawing.Point(43, 195);
            this.Micropayasyn_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Micropayasyn_Btn.Name = "Micropayasyn_Btn";
            this.Micropayasyn_Btn.Size = new System.Drawing.Size(100, 29);
            this.Micropayasyn_Btn.TabIndex = 2;
            this.Micropayasyn_Btn.Text = "扫码付异步";
            this.Micropayasyn_Btn.UseVisualStyleBackColor = true;
            this.Micropayasyn_Btn.Click += new System.EventHandler(this.Micropayasyn_Btn_Click);
            // 
            // Qrcodepay_Btn
            // 
            this.Qrcodepay_Btn.Location = new System.Drawing.Point(43, 231);
            this.Qrcodepay_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Qrcodepay_Btn.Name = "Qrcodepay_Btn";
            this.Qrcodepay_Btn.Size = new System.Drawing.Size(100, 29);
            this.Qrcodepay_Btn.TabIndex = 4;
            this.Qrcodepay_Btn.Text = "二维码";
            this.Qrcodepay_Btn.UseVisualStyleBackColor = true;
            this.Qrcodepay_Btn.Click += new System.EventHandler(this.Qrcodepay_Btn_Click);
            // 
            // QueryOrder_Btn
            // 
            this.QueryOrder_Btn.Location = new System.Drawing.Point(43, 268);
            this.QueryOrder_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QueryOrder_Btn.Name = "QueryOrder_Btn";
            this.QueryOrder_Btn.Size = new System.Drawing.Size(100, 29);
            this.QueryOrder_Btn.TabIndex = 5;
            this.QueryOrder_Btn.Text = "查询订单";
            this.QueryOrder_Btn.UseVisualStyleBackColor = true;
            this.QueryOrder_Btn.Click += new System.EventHandler(this.QueryOrder_Btn_Click);
            // 
            // RefundOrder_Btn
            // 
            this.RefundOrder_Btn.Location = new System.Drawing.Point(43, 416);
            this.RefundOrder_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RefundOrder_Btn.Name = "RefundOrder_Btn";
            this.RefundOrder_Btn.Size = new System.Drawing.Size(100, 29);
            this.RefundOrder_Btn.TabIndex = 6;
            this.RefundOrder_Btn.Text = "退款";
            this.RefundOrder_Btn.UseVisualStyleBackColor = true;
            this.RefundOrder_Btn.Click += new System.EventHandler(this.RefundOrder_Btn_Click);
            // 
            // CancelOrder_Btn
            // 
            this.CancelOrder_Btn.Location = new System.Drawing.Point(43, 305);
            this.CancelOrder_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CancelOrder_Btn.Name = "CancelOrder_Btn";
            this.CancelOrder_Btn.Size = new System.Drawing.Size(100, 29);
            this.CancelOrder_Btn.TabIndex = 7;
            this.CancelOrder_Btn.Text = "撤销订单";
            this.CancelOrder_Btn.UseVisualStyleBackColor = true;
            this.CancelOrder_Btn.Click += new System.EventHandler(this.CancelOrder_Btn_Click);
            // 
            // AppPay_Btn
            // 
            this.AppPay_Btn.Location = new System.Drawing.Point(43, 342);
            this.AppPay_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AppPay_Btn.Name = "AppPay_Btn";
            this.AppPay_Btn.Size = new System.Drawing.Size(100, 29);
            this.AppPay_Btn.TabIndex = 8;
            this.AppPay_Btn.Text = "app支付";
            this.AppPay_Btn.UseVisualStyleBackColor = true;
            this.AppPay_Btn.Click += new System.EventHandler(this.AppPay_Btn_Click);
            // 
            // OfficialPay_Btn
            // 
            this.OfficialPay_Btn.Location = new System.Drawing.Point(43, 379);
            this.OfficialPay_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OfficialPay_Btn.Name = "OfficialPay_Btn";
            this.OfficialPay_Btn.Size = new System.Drawing.Size(100, 29);
            this.OfficialPay_Btn.TabIndex = 9;
            this.OfficialPay_Btn.Text = "公众号支付";
            this.OfficialPay_Btn.UseVisualStyleBackColor = true;
            this.OfficialPay_Btn.Click += new System.EventHandler(this.OfficialPay_Btn_Click);
            // 
            // WapH5Pay_Btn
            // 
            this.WapH5Pay_Btn.Location = new System.Drawing.Point(28, 453);
            this.WapH5Pay_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WapH5Pay_Btn.Name = "WapH5Pay_Btn";
            this.WapH5Pay_Btn.Size = new System.Drawing.Size(149, 29);
            this.WapH5Pay_Btn.TabIndex = 10;
            this.WapH5Pay_Btn.Text = "支付宝服务支付";
            this.WapH5Pay_Btn.UseVisualStyleBackColor = true;
            this.WapH5Pay_Btn.Click += new System.EventHandler(this.WapH5Pay_Btn_Click);
            // 
            // ChnQuery_Btn
            // 
            this.ChnQuery_Btn.Location = new System.Drawing.Point(28, 490);
            this.ChnQuery_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ChnQuery_Btn.Name = "ChnQuery_Btn";
            this.ChnQuery_Btn.Size = new System.Drawing.Size(149, 29);
            this.ChnQuery_Btn.TabIndex = 11;
            this.ChnQuery_Btn.Text = "查询订单渠道";
            this.ChnQuery_Btn.UseVisualStyleBackColor = true;
            this.ChnQuery_Btn.Click += new System.EventHandler(this.ChnQuery_Btn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(280, 416);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(677, 272);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(388, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 13;
            this.label1.Text = "外接码付Demo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 719);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ChnQuery_Btn);
            this.Controls.Add(this.WapH5Pay_Btn);
            this.Controls.Add(this.OfficialPay_Btn);
            this.Controls.Add(this.AppPay_Btn);
            this.Controls.Add(this.CancelOrder_Btn);
            this.Controls.Add(this.RefundOrder_Btn);
            this.Controls.Add(this.QueryOrder_Btn);
            this.Controls.Add(this.Qrcodepay_Btn);
            this.Controls.Add(this.Micropayasyn_Btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Micropay_Btn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Micropay_Btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Micropayasyn_Btn;
        private System.Windows.Forms.Button Qrcodepay_Btn;
        private System.Windows.Forms.Button QueryOrder_Btn;
        private System.Windows.Forms.Button RefundOrder_Btn;
        private System.Windows.Forms.Button CancelOrder_Btn;
        private System.Windows.Forms.Button AppPay_Btn;
        private System.Windows.Forms.Button OfficialPay_Btn;
        private System.Windows.Forms.Button WapH5Pay_Btn;
        private System.Windows.Forms.Button ChnQuery_Btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}

