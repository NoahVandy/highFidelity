namespace highFidelity
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
            this.lbl_ineventoryName = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmbbox_search = new System.Windows.Forms.ComboBox();
            this.txtbx_size = new System.Windows.Forms.TextBox();
            this.txtbx_color = new System.Windows.Forms.TextBox();
            this.txtbx_stock = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_edit = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.txtbx_model = new System.Windows.Forms.TextBox();
            this.txtbx_cost = new System.Windows.Forms.TextBox();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.btn_showItems = new System.Windows.Forms.Button();
            this.txtbx_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ineventoryName
            // 
            this.lbl_ineventoryName.AutoSize = true;
            this.lbl_ineventoryName.Font = new System.Drawing.Font("Javanese Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ineventoryName.Location = new System.Drawing.Point(245, 51);
            this.lbl_ineventoryName.Name = "lbl_ineventoryName";
            this.lbl_ineventoryName.Size = new System.Drawing.Size(488, 102);
            this.lbl_ineventoryName.TabIndex = 1;
            this.lbl_ineventoryName.Text = "Inventory of Van Shoes";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.Color.Transparent;
            this.lbl_search.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(57, 159);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(159, 82);
            this.lbl_search.TabIndex = 2;
            this.lbl_search.Text = "Search: ";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(1087, 798);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(160, 87);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(199, 296);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(160, 87);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(583, 296);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(160, 87);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmbbox_search
            // 
            this.cmbbox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_search.FormattingEnabled = true;
            this.cmbbox_search.Location = new System.Drawing.Point(199, 174);
            this.cmbbox_search.Name = "cmbbox_search";
            this.cmbbox_search.Size = new System.Drawing.Size(545, 48);
            this.cmbbox_search.TabIndex = 6;
            // 
            // txtbx_size
            // 
            this.txtbx_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_size.Location = new System.Drawing.Point(1086, 242);
            this.txtbx_size.Name = "txtbx_size";
            this.txtbx_size.Size = new System.Drawing.Size(347, 48);
            this.txtbx_size.TabIndex = 9;
            // 
            // txtbx_color
            // 
            this.txtbx_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_color.Location = new System.Drawing.Point(1086, 466);
            this.txtbx_color.Name = "txtbx_color";
            this.txtbx_color.Size = new System.Drawing.Size(347, 48);
            this.txtbx_color.TabIndex = 11;
            // 
            // txtbx_stock
            // 
            this.txtbx_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_stock.Location = new System.Drawing.Point(1086, 354);
            this.txtbx_stock.Name = "txtbx_stock";
            this.txtbx_stock.Size = new System.Drawing.Size(347, 48);
            this.txtbx_stock.TabIndex = 10;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_color.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(955, 457);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(129, 82);
            this.lbl_color.TabIndex = 13;
            this.lbl_color.Text = "Color:";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.BackColor = System.Drawing.Color.Transparent;
            this.lbl_size.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.Location = new System.Drawing.Point(975, 233);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(109, 82);
            this.lbl_size.TabIndex = 14;
            this.lbl_size.Text = "Size:";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stock.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(953, 345);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(133, 82);
            this.lbl_stock.TabIndex = 15;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.BackColor = System.Drawing.Color.Transparent;
            this.lbl_model.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(953, 569);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(143, 82);
            this.lbl_model.TabIndex = 16;
            this.lbl_model.Text = "Model:";
            // 
            // lbl_edit
            // 
            this.lbl_edit.AutoSize = true;
            this.lbl_edit.Font = new System.Drawing.Font("Javanese Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_edit.Location = new System.Drawing.Point(1081, 19);
            this.lbl_edit.Name = "lbl_edit";
            this.lbl_edit.Size = new System.Drawing.Size(248, 102);
            this.lbl_edit.TabIndex = 17;
            this.lbl_edit.Text = "Edit Items";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(1273, 798);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(160, 87);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txtbx_model
            // 
            this.txtbx_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_model.Location = new System.Drawing.Point(1086, 578);
            this.txtbx_model.Name = "txtbx_model";
            this.txtbx_model.Size = new System.Drawing.Size(347, 48);
            this.txtbx_model.TabIndex = 12;
            // 
            // txtbx_cost
            // 
            this.txtbx_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_cost.Location = new System.Drawing.Point(1085, 690);
            this.txtbx_cost.Name = "txtbx_cost";
            this.txtbx_cost.Size = new System.Drawing.Size(347, 48);
            this.txtbx_cost.TabIndex = 13;
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cost.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(964, 681);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(115, 82);
            this.lbl_cost.TabIndex = 21;
            this.lbl_cost.Text = "Cost:";
            // 
            // dgv_items
            // 
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Location = new System.Drawing.Point(199, 500);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.RowTemplate.Height = 37;
            this.dgv_items.Size = new System.Drawing.Size(534, 230);
            this.dgv_items.TabIndex = 22;
            // 
            // btn_showItems
            // 
            this.btn_showItems.Location = new System.Drawing.Point(339, 814);
            this.btn_showItems.Name = "btn_showItems";
            this.btn_showItems.Size = new System.Drawing.Size(273, 82);
            this.btn_showItems.TabIndex = 23;
            this.btn_showItems.Text = "Refresh";
            this.btn_showItems.UseVisualStyleBackColor = true;
            this.btn_showItems.Click += new System.EventHandler(this.btn_showItems_Click);
            // 
            // txtbx_id
            // 
            this.txtbx_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_id.Location = new System.Drawing.Point(1088, 130);
            this.txtbx_id.Name = "txtbx_id";
            this.txtbx_id.Size = new System.Drawing.Size(347, 48);
            this.txtbx_id.TabIndex = 8;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_id.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(990, 121);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(85, 82);
            this.lbl_id.TabIndex = 25;
            this.lbl_id.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1524, 908);
            this.Controls.Add(this.txtbx_id);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_showItems);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.cmbbox_search);
            this.Controls.Add(this.txtbx_cost);
            this.Controls.Add(this.txtbx_model);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txtbx_size);
            this.Controls.Add(this.txtbx_stock);
            this.Controls.Add(this.txtbx_color);
            this.Controls.Add(this.lbl_edit);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_stock);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_ineventoryName);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.lbl_cost);
            this.MaximumSize = new System.Drawing.Size(1552, 987);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1552, 987);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ineventoryName;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmbbox_search;
        private System.Windows.Forms.TextBox txtbx_size;
        private System.Windows.Forms.TextBox txtbx_color;
        private System.Windows.Forms.TextBox txtbx_stock;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_edit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txtbx_model;
        private System.Windows.Forms.TextBox txtbx_cost;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.Button btn_showItems;
        private System.Windows.Forms.TextBox txtbx_id;
        private System.Windows.Forms.Label lbl_id;
    }
}

