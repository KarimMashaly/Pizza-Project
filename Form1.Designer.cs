namespace Pizza_Project
{
    partial class frmMainForm
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
            this.btnOrderNow = new System.Windows.Forms.Button();
            this.LbPizzaHut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrderNow
            // 
            this.btnOrderNow.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderNow.FlatAppearance.BorderSize = 0;
            this.btnOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrderNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderNow.ForeColor = System.Drawing.Color.Chocolate;
            this.btnOrderNow.Location = new System.Drawing.Point(166, 574);
            this.btnOrderNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrderNow.Name = "btnOrderNow";
            this.btnOrderNow.Size = new System.Drawing.Size(214, 96);
            this.btnOrderNow.TabIndex = 0;
            this.btnOrderNow.Text = "Order Now";
            this.btnOrderNow.UseVisualStyleBackColor = false;
            this.btnOrderNow.UseWaitCursor = true;
            this.btnOrderNow.Click += new System.EventHandler(this.btnOrderNow_Click);
            // 
            // LbPizzaHut
            // 
            this.LbPizzaHut.BackColor = System.Drawing.Color.Transparent;
            this.LbPizzaHut.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPizzaHut.ForeColor = System.Drawing.Color.Chocolate;
            this.LbPizzaHut.Location = new System.Drawing.Point(66, 22);
            this.LbPizzaHut.Name = "LbPizzaHut";
            this.LbPizzaHut.Size = new System.Drawing.Size(660, 137);
            this.LbPizzaHut.TabIndex = 1;
            this.LbPizzaHut.Text = "Pizza Hut";
            this.LbPizzaHut.UseWaitCursor = true;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pizza_Project.Properties.Resources.Pizza;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1246, 723);
            this.Controls.Add(this.LbPizzaHut);
            this.Controls.Add(this.btnOrderNow);
            this.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainForm";
            this.Text = "Pizza";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrderNow;
        private System.Windows.Forms.Label LbPizzaHut;
    }
}

