namespace PR_task_1
{
    partial class task_3_load
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
            this.generate_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.load_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Classify_ = new System.Windows.Forms.Button();
            this.num_clicks = new System.Windows.Forms.TextBox();
            this.num_classes = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(37, 674);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(100, 23);
            this.generate_button.TabIndex = 177;
            this.generate_button.Text = "Classify";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.classify_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 634);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 176;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(37, 632);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(100, 23);
            this.load_button.TabIndex = 175;
            this.load_button.Text = "Load";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 503);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 174;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Classify_
            // 
            this.Classify_.Location = new System.Drawing.Point(103, 580);
            this.Classify_.Name = "Classify_";
            this.Classify_.Size = new System.Drawing.Size(85, 23);
            this.Classify_.TabIndex = 178;
            this.Classify_.Text = "Take clicks";
            this.Classify_.UseVisualStyleBackColor = true;
            this.Classify_.Click += new System.EventHandler(this.button1_Click);
            // 
            // num_clicks
            // 
            this.num_clicks.Location = new System.Drawing.Point(509, 583);
            this.num_clicks.Name = "num_clicks";
            this.num_clicks.Size = new System.Drawing.Size(149, 20);
            this.num_clicks.TabIndex = 179;
            // 
            // num_classes
            // 
            this.num_classes.Location = new System.Drawing.Point(272, 583);
            this.num_classes.Name = "num_classes";
            this.num_classes.Size = new System.Drawing.Size(149, 20);
            this.num_classes.TabIndex = 180;
            // 
            // task_3_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 742);
            this.Controls.Add(this.num_classes);
            this.Controls.Add(this.num_clicks);
            this.Controls.Add(this.Classify_);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "task_3_load";
            this.Text = "3aaaaaaaaa :D";
            this.Load += new System.EventHandler(this.task_3_load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Classify_;
        private System.Windows.Forms.TextBox num_clicks;
        private System.Windows.Forms.TextBox num_classes;

    }
}