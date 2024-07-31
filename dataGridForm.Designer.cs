
namespace dataGridForm
{
    partial class dataGridForm
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
            this.dataGridOutput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridOutput
            // 
            this.dataGridOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOutput.Location = new System.Drawing.Point(26, 28);
            this.dataGridOutput.Name = "dataGridOutput";
            this.dataGridOutput.RowHeadersWidth = 51;
            this.dataGridOutput.RowTemplate.Height = 24;
            this.dataGridOutput.Size = new System.Drawing.Size(483, 176);
            this.dataGridOutput.TabIndex = 0;
            this.dataGridOutput.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOutput_CellDoubleClick);
            // 
            // dataGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 236);
            this.Controls.Add(this.dataGridOutput);
            this.Name = "dataGridForm";
            this.Text = "Data Grid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridOutput;
    }
}

