
namespace dataGridForm
{
    partial class dataCellView
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
            this.dataTxBx = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataTxBx
            // 
            this.dataTxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataTxBx.Location = new System.Drawing.Point(47, 159);
            this.dataTxBx.Name = "dataTxBx";
            this.dataTxBx.ReadOnly = true;
            this.dataTxBx.Size = new System.Drawing.Size(100, 34);
            this.dataTxBx.TabIndex = 0;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinish.Location = new System.Drawing.Point(47, 245);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(219, 32);
            this.btnFinish.TabIndex = 1;
            this.btnFinish.Text = "Ok";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // dataCellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 325);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dataTxBx);
            this.Name = "dataCellView";
            this.Text = "dataCellView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox dataTxBx;
        private System.Windows.Forms.Button btnFinish;
    }
}