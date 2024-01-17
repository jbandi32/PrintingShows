namespace A8_Bandi
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
            this.lblPrintShows = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.lblTheatre = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cbTheatre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblPrintShows
            // 
            this.lblPrintShows.AutoSize = true;
            this.lblPrintShows.Location = new System.Drawing.Point(109, 120);
            this.lblPrintShows.Name = "lblPrintShows";
            this.lblPrintShows.Size = new System.Drawing.Size(172, 25);
            this.lblPrintShows.TabIndex = 0;
            this.lblPrintShows.Text = "Print Shows From:";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(233, 192);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(48, 25);
            this.lblAnd.TabIndex = 1;
            this.lblAnd.Text = "And";
            // 
            // lblTheatre
            // 
            this.lblTheatre.AutoSize = true;
            this.lblTheatre.Location = new System.Drawing.Point(177, 259);
            this.lblTheatre.Name = "lblTheatre";
            this.lblTheatre.Size = new System.Drawing.Size(104, 25);
            this.lblTheatre.TabIndex = 2;
            this.lblTheatre.Text = "At Theatre";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(300, 314);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(242, 100);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(328, 116);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(214, 29);
            this.dtpStart.TabIndex = 4;
            this.dtpStart.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(328, 188);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(214, 29);
            this.dtpEnd.TabIndex = 5;
            this.dtpEnd.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // cbTheatre
            // 
            this.cbTheatre.FormattingEnabled = true;
            this.cbTheatre.Location = new System.Drawing.Point(338, 259);
            this.cbTheatre.Name = "cbTheatre";
            this.cbTheatre.Size = new System.Drawing.Size(204, 32);
            this.cbTheatre.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTheatre);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblTheatre);
            this.Controls.Add(this.lblAnd);
            this.Controls.Add(this.lblPrintShows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrintShows;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.Label lblTheatre;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cbTheatre;
    }
}

