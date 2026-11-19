namespace ALGO_SIMULATION.Forms
{
    partial class Hashsets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hashsets));
            this.clearbttn = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnExceptWith = new System.Windows.Forms.Button();
            this.btnIntersectWith = new System.Windows.Forms.Button();
            this.btnUnionWith = new System.Windows.Forms.Button();
            this.cbTargetSet = new System.Windows.Forms.ComboBox();
            this.btnAddToSet2 = new System.Windows.Forms.Button();
            this.btnAddToSet1 = new System.Windows.Forms.Button();
            this.txtSet2Input = new System.Windows.Forms.TextBox();
            this.txtSet1Input = new System.Windows.Forms.TextBox();
            this.lbSet2 = new System.Windows.Forms.ListBox();
            this.lbSet1 = new System.Windows.Forms.ListBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // clearbttn
            // 
            this.clearbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.clearbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbttn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.clearbttn.Location = new System.Drawing.Point(272, 294);
            this.clearbttn.Name = "clearbttn";
            this.clearbttn.Size = new System.Drawing.Size(94, 51);
            this.clearbttn.TabIndex = 23;
            this.clearbttn.Text = "Clear";
            this.clearbttn.UseVisualStyleBackColor = false;
            this.clearbttn.Click += new System.EventHandler(this.clearbttn_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbOutput.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 21;
            this.lbOutput.Location = new System.Drawing.Point(395, 225);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(234, 357);
            this.lbOutput.TabIndex = 22;
            this.lbOutput.SelectedIndexChanged += new System.EventHandler(this.lbOutput_SelectedIndexChanged);
            // 
            // btnExceptWith
            // 
            this.btnExceptWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnExceptWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExceptWith.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExceptWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.btnExceptWith.Location = new System.Drawing.Point(395, 162);
            this.btnExceptWith.Name = "btnExceptWith";
            this.btnExceptWith.Size = new System.Drawing.Size(234, 49);
            this.btnExceptWith.TabIndex = 21;
            this.btnExceptWith.Text = "Except With";
            this.btnExceptWith.UseVisualStyleBackColor = false;
            this.btnExceptWith.Click += new System.EventHandler(this.btnExceptWith_Click);
            // 
            // btnIntersectWith
            // 
            this.btnIntersectWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnIntersectWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntersectWith.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntersectWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.btnIntersectWith.Location = new System.Drawing.Point(395, 108);
            this.btnIntersectWith.Name = "btnIntersectWith";
            this.btnIntersectWith.Size = new System.Drawing.Size(234, 48);
            this.btnIntersectWith.TabIndex = 20;
            this.btnIntersectWith.Text = "Intersect With";
            this.btnIntersectWith.UseVisualStyleBackColor = false;
            this.btnIntersectWith.Click += new System.EventHandler(this.btnIntersectWith_Click);
            // 
            // btnUnionWith
            // 
            this.btnUnionWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnUnionWith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnionWith.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnionWith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.btnUnionWith.Location = new System.Drawing.Point(395, 53);
            this.btnUnionWith.Name = "btnUnionWith";
            this.btnUnionWith.Size = new System.Drawing.Size(234, 49);
            this.btnUnionWith.TabIndex = 19;
            this.btnUnionWith.Text = "Union With";
            this.btnUnionWith.UseVisualStyleBackColor = false;
            this.btnUnionWith.Click += new System.EventHandler(this.btnUnionWith_Click);
            // 
            // cbTargetSet
            // 
            this.cbTargetSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.cbTargetSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTargetSet.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTargetSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.cbTargetSet.FormattingEnabled = true;
            this.cbTargetSet.Items.AddRange(new object[] {
            "Set1",
            "Set2"});
            this.cbTargetSet.Location = new System.Drawing.Point(272, 258);
            this.cbTargetSet.Name = "cbTargetSet";
            this.cbTargetSet.Size = new System.Drawing.Size(94, 29);
            this.cbTargetSet.TabIndex = 18;
            this.cbTargetSet.SelectedIndexChanged += new System.EventHandler(this.cbTargetSet_SelectedIndexChanged);
            // 
            // btnAddToSet2
            // 
            this.btnAddToSet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnAddToSet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToSet2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToSet2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.btnAddToSet2.Location = new System.Drawing.Point(26, 532);
            this.btnAddToSet2.Name = "btnAddToSet2";
            this.btnAddToSet2.Size = new System.Drawing.Size(218, 50);
            this.btnAddToSet2.TabIndex = 17;
            this.btnAddToSet2.Text = "Add to Set 2";
            this.btnAddToSet2.UseVisualStyleBackColor = false;
            this.btnAddToSet2.Click += new System.EventHandler(this.btnAddToSet2_Click);
            // 
            // btnAddToSet1
            // 
            this.btnAddToSet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.btnAddToSet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToSet1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToSet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.btnAddToSet1.Location = new System.Drawing.Point(26, 256);
            this.btnAddToSet1.Name = "btnAddToSet1";
            this.btnAddToSet1.Size = new System.Drawing.Size(218, 50);
            this.btnAddToSet1.TabIndex = 16;
            this.btnAddToSet1.Text = "Add to Set 1";
            this.btnAddToSet1.UseVisualStyleBackColor = false;
            this.btnAddToSet1.Click += new System.EventHandler(this.btnAddToSet1_Click);
            // 
            // txtSet2Input
            // 
            this.txtSet2Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.txtSet2Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSet2Input.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSet2Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.txtSet2Input.Location = new System.Drawing.Point(26, 503);
            this.txtSet2Input.Name = "txtSet2Input";
            this.txtSet2Input.Size = new System.Drawing.Size(218, 23);
            this.txtSet2Input.TabIndex = 15;
            this.txtSet2Input.TextChanged += new System.EventHandler(this.txtSet2Input_TextChanged);
            // 
            // txtSet1Input
            // 
            this.txtSet1Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.txtSet1Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSet1Input.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSet1Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.txtSet1Input.Location = new System.Drawing.Point(26, 227);
            this.txtSet1Input.Name = "txtSet1Input";
            this.txtSet1Input.Size = new System.Drawing.Size(218, 23);
            this.txtSet1Input.TabIndex = 14;
            this.txtSet1Input.TextChanged += new System.EventHandler(this.txtSet1Input_TextChanged);
            // 
            // lbSet2
            // 
            this.lbSet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.lbSet2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSet2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSet2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.lbSet2.FormattingEnabled = true;
            this.lbSet2.ItemHeight = 21;
            this.lbSet2.Location = new System.Drawing.Point(26, 329);
            this.lbSet2.Name = "lbSet2";
            this.lbSet2.Size = new System.Drawing.Size(218, 168);
            this.lbSet2.TabIndex = 13;
            this.lbSet2.SelectedIndexChanged += new System.EventHandler(this.lbSet2_SelectedIndexChanged);
            // 
            // lbSet1
            // 
            this.lbSet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.lbSet1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSet1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.lbSet1.FormattingEnabled = true;
            this.lbSet1.ItemHeight = 21;
            this.lbSet1.Location = new System.Drawing.Point(26, 53);
            this.lbSet1.Name = "lbSet1";
            this.lbSet1.Size = new System.Drawing.Size(218, 168);
            this.lbSet1.TabIndex = 12;
            this.lbSet1.SelectedIndexChanged += new System.EventHandler(this.lbSet1_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(174, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(291, 240);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // Hashsets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(720, 620);
            this.Controls.Add(this.clearbttn);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnExceptWith);
            this.Controls.Add(this.btnIntersectWith);
            this.Controls.Add(this.btnUnionWith);
            this.Controls.Add(this.cbTargetSet);
            this.Controls.Add(this.btnAddToSet2);
            this.Controls.Add(this.btnAddToSet1);
            this.Controls.Add(this.txtSet2Input);
            this.Controls.Add(this.txtSet1Input);
            this.Controls.Add(this.lbSet2);
            this.Controls.Add(this.lbSet1);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hashsets";
            this.Text = "Hashset";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearbttn;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnExceptWith;
        private System.Windows.Forms.Button btnIntersectWith;
        private System.Windows.Forms.Button btnUnionWith;
        private System.Windows.Forms.ComboBox cbTargetSet;
        private System.Windows.Forms.Button btnAddToSet2;
        private System.Windows.Forms.Button btnAddToSet1;
        private System.Windows.Forms.TextBox txtSet2Input;
        private System.Windows.Forms.TextBox txtSet1Input;
        private System.Windows.Forms.ListBox lbSet2;
        private System.Windows.Forms.ListBox lbSet1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}