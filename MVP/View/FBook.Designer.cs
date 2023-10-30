namespace MVP.View
{
    partial class FBook
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
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtAuthor = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.LabTitle = new System.Windows.Forms.Label();
            this.LabAuthor = new System.Windows.Forms.Label();
            this.LabYear = new System.Windows.Forms.Label();
            this.DTBYear = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(237, 175);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(84, 30);
            this.BtnUpdate.TabIndex = 17;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(393, 175);
            this.BtnInsert.Margin = new System.Windows.Forms.Padding(6);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 30);
            this.BtnInsert.TabIndex = 16;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(98, 175);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 30);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Delete ";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtAuthor
            // 
            this.TxtAuthor.Location = new System.Drawing.Point(213, 44);
            this.TxtAuthor.Margin = new System.Windows.Forms.Padding(11);
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.Size = new System.Drawing.Size(132, 29);
            this.TxtAuthor.TabIndex = 10;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(20, 44);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(11);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(132, 29);
            this.TxtTitle.TabIndex = 9;
            // 
            // LabTitle
            // 
            this.LabTitle.AutoSize = true;
            this.LabTitle.Location = new System.Drawing.Point(65, 19);
            this.LabTitle.Name = "LabTitle";
            this.LabTitle.Size = new System.Drawing.Size(45, 24);
            this.LabTitle.TabIndex = 18;
            this.LabTitle.Text = "Title";
            // 
            // LabAuthor
            // 
            this.LabAuthor.AutoSize = true;
            this.LabAuthor.Location = new System.Drawing.Point(233, 19);
            this.LabAuthor.Name = "LabAuthor";
            this.LabAuthor.Size = new System.Drawing.Size(66, 24);
            this.LabAuthor.TabIndex = 19;
            this.LabAuthor.Text = "Author";
            // 
            // LabYear
            // 
            this.LabYear.AutoSize = true;
            this.LabYear.Location = new System.Drawing.Point(419, 19);
            this.LabYear.Name = "LabYear";
            this.LabYear.Size = new System.Drawing.Size(49, 24);
            this.LabYear.TabIndex = 20;
            this.LabYear.Text = "Year";
            // 
            // DTBYear
            // 
            this.DTBYear.Location = new System.Drawing.Point(359, 43);
            this.DTBYear.Name = "DTBYear";
            this.DTBYear.Size = new System.Drawing.Size(200, 29);
            this.DTBYear.TabIndex = 21;
            // 
            // FBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 237);
            this.Controls.Add(this.DTBYear);
            this.Controls.Add(this.LabYear);
            this.Controls.Add(this.LabAuthor);
            this.Controls.Add(this.LabTitle);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.TxtAuthor);
            this.Controls.Add(this.TxtTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FBook";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnInsert;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtAuthor;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label LabTitle;
        private System.Windows.Forms.Label LabAuthor;
        private System.Windows.Forms.Label LabYear;
        private System.Windows.Forms.DateTimePicker DTBYear;
    }
}