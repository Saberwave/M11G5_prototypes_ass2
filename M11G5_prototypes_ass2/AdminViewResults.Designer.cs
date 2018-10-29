namespace M11G5_prototypes_ass2
{
    partial class AdminViewResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewResults));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.StdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module1Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Module1DateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Module2completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Module2DateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BusinessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoStudentsSignUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalthatcompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StdName,
            this.Module1Completed,
            this.Module1DateCompleted,
            this.Module2completed,
            this.Module2DateCompleted});
            this.dataGridView2.Location = new System.Drawing.Point(63, 295);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 58);
            this.dataGridView2.TabIndex = 70;
            // 
            // StdName
            // 
            this.StdName.HeaderText = "Student Name";
            this.StdName.Name = "StdName";
            // 
            // Module1Completed
            // 
            this.Module1Completed.HeaderText = "Module 1 Completed";
            this.Module1Completed.Name = "Module1Completed";
            // 
            // Module1DateCompleted
            // 
            this.Module1DateCompleted.HeaderText = "Module1DateCompleted";
            this.Module1DateCompleted.Name = "Module1DateCompleted";
            this.Module1DateCompleted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Module1DateCompleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Module2completed
            // 
            this.Module2completed.HeaderText = "Module 2 Completed";
            this.Module2completed.Name = "Module2completed";
            // 
            // Module2DateCompleted
            // 
            this.Module2DateCompleted.HeaderText = "Module 2 Date completed";
            this.Module2DateCompleted.Name = "Module2DateCompleted";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BusinessName,
            this.Location,
            this.Trainer,
            this.NoStudentsSignUp,
            this.totalthatcompleted});
            this.dataGridView1.Location = new System.Drawing.Point(63, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 58);
            this.dataGridView1.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(22, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(675, 22);
            this.label2.TabIndex = 68;
            this.label2.Text = "Below you will see the results of all courses that have been run recently.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = global::M11G5_prototypes_ass2.Properties.Resources.SphBtn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(377, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 97);
            this.button1.TabIndex = 72;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::M11G5_prototypes_ass2.Properties.Resources.SafeDriversCourse;
            this.pictureBox2.Location = new System.Drawing.Point(5, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 157);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // BusinessName
            // 
            this.BusinessName.HeaderText = "BusinessName";
            this.BusinessName.Name = "BusinessName";
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // Trainer
            // 
            this.Trainer.HeaderText = "Trainer";
            this.Trainer.Name = "Trainer";
            // 
            // NoStudentsSignUp
            // 
            this.NoStudentsSignUp.HeaderText = "Total Students Enrolled";
            this.NoStudentsSignUp.Name = "NoStudentsSignUp";
            // 
            // totalthatcompleted
            // 
            this.totalthatcompleted.HeaderText = "Total That Completed";
            this.totalthatcompleted.Name = "totalthatcompleted";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::M11G5_prototypes_ass2.Properties.Resources.rms_logo_195;
            this.pictureBox1.Location = new System.Drawing.Point(171, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(513, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImage = global::M11G5_prototypes_ass2.Properties.Resources.SphBtn;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(134, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 97);
            this.button2.TabIndex = 75;
            this.button2.Text = "Update Results";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminViewResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(707, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminViewResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin View Results";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StdName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Module1Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module1DateCompleted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Module2completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Module2DateCompleted;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusinessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoStudentsSignUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalthatcompleted;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}