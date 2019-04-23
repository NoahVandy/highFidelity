namespace highFidelity
{
    partial class searchForm
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
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.lbl_searchResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(66, 167);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowTemplate.Height = 37;
            this.dgv_search.Size = new System.Drawing.Size(1552, 631);
            this.dgv_search.TabIndex = 0;
            // 
            // lbl_searchResults
            // 
            this.lbl_searchResults.AutoSize = true;
            this.lbl_searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchResults.Location = new System.Drawing.Point(305, 61);
            this.lbl_searchResults.Name = "lbl_searchResults";
            this.lbl_searchResults.Size = new System.Drawing.Size(645, 82);
            this.lbl_searchResults.TabIndex = 1;
            this.lbl_searchResults.Text = "Search Results for ";
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1772, 1022);
            this.Controls.Add(this.lbl_searchResults);
            this.Controls.Add(this.dgv_search);
            this.Name = "searchForm";
            this.Text = "searchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Label lbl_searchResults;
    }
}