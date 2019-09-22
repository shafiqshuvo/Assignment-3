namespace PurchaseTicketUI
{
    partial class PurchaseTicketUI
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
            this.numberofticketscombo = new System.Windows.Forms.ComboBox();
            this.Customernametext = new System.Windows.Forms.TextBox();
            this.unitpricetext = new System.Windows.Forms.TextBox();
            this.paymenttext = new System.Windows.Forms.TextBox();
            this.totalapricebutton = new System.Windows.Forms.Button();
            this.detailsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of Tickets";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payment";
            // 
            // numberofticketscombo
            // 
            this.numberofticketscombo.FormattingEnabled = true;
            this.numberofticketscombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.numberofticketscombo.Location = new System.Drawing.Point(240, 79);
            this.numberofticketscombo.Name = "numberofticketscombo";
            this.numberofticketscombo.Size = new System.Drawing.Size(121, 21);
            this.numberofticketscombo.TabIndex = 4;
            this.numberofticketscombo.SelectedIndexChanged += new System.EventHandler(this.numberofTickets_SelectedIndexChanged);
            // 
            // Customernametext
            // 
            this.Customernametext.Location = new System.Drawing.Point(240, 29);
            this.Customernametext.Name = "Customernametext";
            this.Customernametext.Size = new System.Drawing.Size(121, 20);
            this.Customernametext.TabIndex = 5;
            this.Customernametext.TextChanged += new System.EventHandler(this.Customernametext_TextChanged);
            // 
            // unitpricetext
            // 
            this.unitpricetext.Location = new System.Drawing.Point(240, 127);
            this.unitpricetext.Name = "unitpricetext";
            this.unitpricetext.Size = new System.Drawing.Size(121, 20);
            this.unitpricetext.TabIndex = 6;
            // 
            // paymenttext
            // 
            this.paymenttext.Location = new System.Drawing.Point(240, 169);
            this.paymenttext.Name = "paymenttext";
            this.paymenttext.Size = new System.Drawing.Size(121, 20);
            this.paymenttext.TabIndex = 7;
            this.paymenttext.TextChanged += new System.EventHandler(this.TotalPrice_TextChanged);
            // 
            // totalapricebutton
            // 
            this.totalapricebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalapricebutton.Location = new System.Drawing.Point(141, 238);
            this.totalapricebutton.Name = "totalapricebutton";
            this.totalapricebutton.Size = new System.Drawing.Size(100, 38);
            this.totalapricebutton.TabIndex = 8;
            this.totalapricebutton.Text = "Total Price";
            this.totalapricebutton.UseVisualStyleBackColor = true;
            this.totalapricebutton.Click += new System.EventHandler(this.totalaprice_Click);
            // 
            // detailsbutton
            // 
            this.detailsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsbutton.Location = new System.Drawing.Point(306, 238);
            this.detailsbutton.Name = "detailsbutton";
            this.detailsbutton.Size = new System.Drawing.Size(122, 38);
            this.detailsbutton.TabIndex = 9;
            this.detailsbutton.Text = "Details";
            this.detailsbutton.UseVisualStyleBackColor = true;
            this.detailsbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PurchaseTicketUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 448);
            this.Controls.Add(this.detailsbutton);
            this.Controls.Add(this.totalapricebutton);
            this.Controls.Add(this.paymenttext);
            this.Controls.Add(this.unitpricetext);
            this.Controls.Add(this.Customernametext);
            this.Controls.Add(this.numberofticketscombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseTicketUI";
            this.Text = "PurchaseTicketUI";
            this.Load += new System.EventHandler(this.PurchaseTicketUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox numberofticketscombo;
        private System.Windows.Forms.TextBox Customernametext;
        private System.Windows.Forms.TextBox unitpricetext;
        private System.Windows.Forms.TextBox paymenttext;
        private System.Windows.Forms.Button totalapricebutton;
        private System.Windows.Forms.Button detailsbutton;
    }
}

