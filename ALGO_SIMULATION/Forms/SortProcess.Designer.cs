namespace ALGO_SIMULATION.Forms
{
    partial class SortProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortProcessForm));
            this.RBbubble = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.RBselection = new System.Windows.Forms.RadioButton();
            this.RBinsertion = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.OutPutProcess = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ClearB = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.EnterValue = new System.Windows.Forms.Button();
            this.SortAnimationForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RBbubble
            // 
            this.RBbubble.AutoSize = true;
            this.RBbubble.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.RBbubble.FlatAppearance.BorderSize = 0;
            this.RBbubble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBbubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBbubble.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.RBbubble.Location = new System.Drawing.Point(80, 44);
            this.RBbubble.Name = "RBbubble";
            this.RBbubble.Size = new System.Drawing.Size(96, 29);
            this.RBbubble.TabIndex = 0;
            this.RBbubble.Text = "Bubble";
            this.RBbubble.UseVisualStyleBackColor = true;
            this.RBbubble.CheckedChanged += new System.EventHandler(this.RBbubble_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(73, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sort Type";
            // 
            // RBselection
            // 
            this.RBselection.AutoSize = true;
            this.RBselection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBselection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBselection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.RBselection.Location = new System.Drawing.Point(182, 44);
            this.RBselection.Name = "RBselection";
            this.RBselection.Size = new System.Drawing.Size(118, 29);
            this.RBselection.TabIndex = 2;
            this.RBselection.Text = "Selection";
            this.RBselection.UseVisualStyleBackColor = true;
            this.RBselection.CheckedChanged += new System.EventHandler(this.RBselection_CheckedChanged);
            // 
            // RBinsertion
            // 
            this.RBinsertion.AutoSize = true;
            this.RBinsertion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBinsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBinsertion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.RBinsertion.Location = new System.Drawing.Point(306, 44);
            this.RBinsertion.Name = "RBinsertion";
            this.RBinsertion.Size = new System.Drawing.Size(111, 29);
            this.RBinsertion.TabIndex = 3;
            this.RBinsertion.Text = "Insertion";
            this.RBinsertion.UseVisualStyleBackColor = true;
            this.RBinsertion.CheckedChanged += new System.EventHandler(this.RBinsertion_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(334, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Max value (12)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(439, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sort Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Enter Unsorted Numbers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.checkBox2.Location = new System.Drawing.Point(325, 261);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(105, 26);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "     Animation     ";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // OutPutProcess
            // 
            this.OutPutProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.OutPutProcess.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutPutProcess.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.OutPutProcess.Location = new System.Drawing.Point(443, 124);
            this.OutPutProcess.Multiline = true;
            this.OutPutProcess.Name = "OutPutProcess";
            this.OutPutProcess.ReadOnly = true;
            this.OutPutProcess.Size = new System.Drawing.Size(265, 197);
            this.OutPutProcess.TabIndex = 21;
            this.OutPutProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OutPutProcess.TextChanged += new System.EventHandler(this.OutPutProcess_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.textBox1.Location = new System.Drawing.Point(16, 289);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(293, 32);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ClearB
            // 
            this.ClearB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClearB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.ClearB.FlatAppearance.BorderSize = 0;
            this.ClearB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearB.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.ClearB.Location = new System.Drawing.Point(325, 196);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(105, 59);
            this.ClearB.TabIndex = 19;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = false;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.textBox2.Location = new System.Drawing.Point(16, 124);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(293, 145);
            this.textBox2.TabIndex = 18;
            // 
            // EnterValue
            // 
            this.EnterValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.EnterValue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(21)))), ((int)(((byte)(41)))));
            this.EnterValue.FlatAppearance.BorderSize = 0;
            this.EnterValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterValue.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(91)))));
            this.EnterValue.Location = new System.Drawing.Point(325, 124);
            this.EnterValue.Name = "EnterValue";
            this.EnterValue.Size = new System.Drawing.Size(105, 66);
            this.EnterValue.TabIndex = 17;
            this.EnterValue.Text = "Sort The Numbers";
            this.EnterValue.UseVisualStyleBackColor = false;
            this.EnterValue.Click += new System.EventHandler(this.EnterValue_Click_1);
            // 
            // SortAnimationForm
            // 
            this.SortAnimationForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(90)))), ((int)(((byte)(189)))));
            this.SortAnimationForm.Location = new System.Drawing.Point(16, 342);
            this.SortAnimationForm.Name = "SortAnimationForm";
            this.SortAnimationForm.Size = new System.Drawing.Size(692, 250);
            this.SortAnimationForm.TabIndex = 27;
            this.SortAnimationForm.Paint += new System.Windows.Forms.PaintEventHandler(this.SortAnimationForm_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-18, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // SortProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(720, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.OutPutProcess);
            this.Controls.Add(this.SortAnimationForm);
            this.Controls.Add(this.ClearB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.EnterValue);
            this.Controls.Add(this.RBinsertion);
            this.Controls.Add(this.RBselection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RBbubble);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortProcessForm";
            this.Text = "SortProcess";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RBbubble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBselection;
        private System.Windows.Forms.RadioButton RBinsertion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox OutPutProcess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button EnterValue;
        private System.Windows.Forms.Panel SortAnimationForm;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}