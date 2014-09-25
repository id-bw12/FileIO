namespace FileIO
{
    partial class Form1
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
            this.enterBox = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.writeBttn = new System.Windows.Forms.Button();
            this.readBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterBox
            // 
            this.enterBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBox.Location = new System.Drawing.Point(47, 94);
            this.enterBox.Name = "enterBox";
            this.enterBox.Size = new System.Drawing.Size(171, 29);
            this.enterBox.TabIndex = 0;
            this.enterBox.TextChanged += new System.EventHandler(this.TextBoxes_Changed);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLbl.Location = new System.Drawing.Point(12, 55);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(243, 24);
            this.infoLbl.TabIndex = 1;
            this.infoLbl.Text = "Hit Write when you\'re done ";
            // 
            // writeBttn
            // 
            this.writeBttn.Enabled = false;
            this.writeBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeBttn.Location = new System.Drawing.Point(16, 161);
            this.writeBttn.Name = "writeBttn";
            this.writeBttn.Size = new System.Drawing.Size(98, 37);
            this.writeBttn.TabIndex = 2;
            this.writeBttn.Text = "Write";
            this.writeBttn.UseVisualStyleBackColor = true;
            this.writeBttn.Click += new System.EventHandler(this.writeBttn_Click);
            // 
            // readBttn
            // 
            this.readBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBttn.Location = new System.Drawing.Point(120, 161);
            this.readBttn.Name = "readBttn";
            this.readBttn.Size = new System.Drawing.Size(98, 37);
            this.readBttn.TabIndex = 3;
            this.readBttn.Text = "Read";
            this.readBttn.UseVisualStyleBackColor = true;
            this.readBttn.Click += new System.EventHandler(this.readBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.readBttn);
            this.Controls.Add(this.writeBttn);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.enterBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox enterBox;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Button writeBttn;
        private System.Windows.Forms.Button readBttn;
    }
}

