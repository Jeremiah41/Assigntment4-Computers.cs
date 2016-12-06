namespace StartForm.cs
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.PictureBoxStartForm = new System.Windows.Forms.PictureBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ButtonStartOrder = new System.Windows.Forms.Button();
            this.ButtonSavedOrder = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStartForm)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxStartForm
            // 
            this.PictureBoxStartForm.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBoxStartForm.InitialImage")));
            this.PictureBoxStartForm.Location = new System.Drawing.Point(88, 94);
            this.PictureBoxStartForm.Name = "PictureBoxStartForm";
            this.PictureBoxStartForm.Size = new System.Drawing.Size(252, 200);
            this.PictureBoxStartForm.TabIndex = 0;
            this.PictureBoxStartForm.TabStop = false;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(124, 56);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(190, 24);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Corperate Computers";
            // 
            // ButtonStartOrder
            // 
            this.ButtonStartOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonStartOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStartOrder.Location = new System.Drawing.Point(140, 324);
            this.ButtonStartOrder.Name = "ButtonStartOrder";
            this.ButtonStartOrder.Size = new System.Drawing.Size(147, 29);
            this.ButtonStartOrder.TabIndex = 2;
            this.ButtonStartOrder.Text = "Start a New Order";
            this.ButtonStartOrder.UseVisualStyleBackColor = true;
            this.ButtonStartOrder.Click += new System.EventHandler(this.ButtonStartOrder_Click);
            // 
            // ButtonSavedOrder
            // 
            this.ButtonSavedOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonSavedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSavedOrder.Location = new System.Drawing.Point(140, 359);
            this.ButtonSavedOrder.Name = "ButtonSavedOrder";
            this.ButtonSavedOrder.Size = new System.Drawing.Size(147, 29);
            this.ButtonSavedOrder.TabIndex = 3;
            this.ButtonSavedOrder.Text = "Open a Saved Order";
            this.ButtonSavedOrder.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(140, 394);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(147, 29);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 465);
            this.ControlBox = false;
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSavedOrder);
            this.Controls.Add(this.ButtonStartOrder);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.PictureBoxStartForm);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corperate Computers";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStartForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxStartForm;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonStartOrder;
        private System.Windows.Forms.Button ButtonSavedOrder;
        private System.Windows.Forms.Button ButtonExit;
    }
}

