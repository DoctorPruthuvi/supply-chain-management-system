namespace newlounge171
{
    partial class iteminfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.itemspanel = new System.Windows.Forms.Panel();
            this.supply_info1 = new newlounge171.supply_info();
            this.fruitveginfo1 = new newlounge171.fruitveginfo();
            this.dryfoodinfo1 = new newlounge171.dryfoodinfo();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.b1.FlatAppearance.BorderSize = 0;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.SystemColors.Control;
            this.b1.Location = new System.Drawing.Point(-1, 10);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(261, 44);
            this.b1.TabIndex = 0;
            this.b1.Text = "Dryfood Informations";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.b2.FlatAppearance.BorderSize = 0;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.ForeColor = System.Drawing.SystemColors.Control;
            this.b2.Location = new System.Drawing.Point(262, 10);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(261, 44);
            this.b2.TabIndex = 3;
            this.b2.Text = "Fruits and Vegitables";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.b3.FlatAppearance.BorderSize = 0;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.ForeColor = System.Drawing.SystemColors.Control;
            this.b3.Location = new System.Drawing.Point(525, 10);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(261, 44);
            this.b3.TabIndex = 4;
            this.b3.Text = "Supplying Informations";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button3_Click);
            // 
            // itemspanel
            // 
            this.itemspanel.BackColor = System.Drawing.Color.Crimson;
            this.itemspanel.Location = new System.Drawing.Point(-1, 0);
            this.itemspanel.Name = "itemspanel";
            this.itemspanel.Size = new System.Drawing.Size(261, 10);
            this.itemspanel.TabIndex = 1;
            // 
            // supply_info1
            // 
            this.supply_info1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.supply_info1.Location = new System.Drawing.Point(0, 55);
            this.supply_info1.Name = "supply_info1";
            this.supply_info1.Size = new System.Drawing.Size(786, 380);
            this.supply_info1.TabIndex = 7;
            this.supply_info1.Load += new System.EventHandler(this.supply_info1_Load);
            // 
            // fruitveginfo1
            // 
            this.fruitveginfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.fruitveginfo1.Location = new System.Drawing.Point(0, 55);
            this.fruitveginfo1.Name = "fruitveginfo1";
            this.fruitveginfo1.Size = new System.Drawing.Size(786, 380);
            this.fruitveginfo1.TabIndex = 6;
            // 
            // dryfoodinfo1
            // 
            this.dryfoodinfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.dryfoodinfo1.Location = new System.Drawing.Point(0, 55);
            this.dryfoodinfo1.Name = "dryfoodinfo1";
            this.dryfoodinfo1.Size = new System.Drawing.Size(786, 380);
            this.dryfoodinfo1.TabIndex = 5;
            // 
            // iteminfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(27)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.supply_info1);
            this.Controls.Add(this.fruitveginfo1);
            this.Controls.Add(this.dryfoodinfo1);
            this.Controls.Add(this.itemspanel);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b1);
            this.Name = "iteminfo";
            this.Size = new System.Drawing.Size(786, 435);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Panel itemspanel;
        private dryfoodinfo dryfoodinfo1;
        private fruitveginfo fruitveginfo1;
        private supply_info supply_info1;
    }
}
