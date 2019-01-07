namespace eDostavaClient
{
    partial class RestoranOverview
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBlokovi = new System.Windows.Forms.ComboBox();
            this.btnPretraziRestorane = new System.Windows.Forms.Button();
            this.dgvRestorani = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestorani)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blokovi";
            // 
            // cmbBlokovi
            // 
            this.cmbBlokovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlokovi.FormattingEnabled = true;
            this.cmbBlokovi.Location = new System.Drawing.Point(85, 11);
            this.cmbBlokovi.Name = "cmbBlokovi";
            this.cmbBlokovi.Size = new System.Drawing.Size(230, 24);
            this.cmbBlokovi.TabIndex = 1;
            // 
            // btnPretraziRestorane
            // 
            this.btnPretraziRestorane.Location = new System.Drawing.Point(321, 10);
            this.btnPretraziRestorane.Name = "btnPretraziRestorane";
            this.btnPretraziRestorane.Size = new System.Drawing.Size(125, 25);
            this.btnPretraziRestorane.TabIndex = 2;
            this.btnPretraziRestorane.Text = "Pretražite restorane";
            this.btnPretraziRestorane.UseVisualStyleBackColor = true;
            this.btnPretraziRestorane.Click += new System.EventHandler(this.btnPretraziRestorane_Click);
            // 
            // dgvRestorani
            // 
            this.dgvRestorani.AllowUserToOrderColumns = true;
            this.dgvRestorani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestorani.Location = new System.Drawing.Point(15, 53);
            this.dgvRestorani.Name = "dgvRestorani";
            this.dgvRestorani.RowTemplate.Height = 24;
            this.dgvRestorani.Size = new System.Drawing.Size(815, 432);
            this.dgvRestorani.TabIndex = 3;
            // 
            // RestoranOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 497);
            this.Controls.Add(this.dgvRestorani);
            this.Controls.Add(this.btnPretraziRestorane);
            this.Controls.Add(this.cmbBlokovi);
            this.Controls.Add(this.label1);
            this.Name = "RestoranOverview";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestorani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBlokovi;
        private System.Windows.Forms.Button btnPretraziRestorane;
        private System.Windows.Forms.DataGridView dgvRestorani;
    }
}

