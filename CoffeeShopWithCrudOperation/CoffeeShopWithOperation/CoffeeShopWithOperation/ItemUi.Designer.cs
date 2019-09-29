namespace CoffeeShopWithOperation
{
    partial class ItemUi
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
            this.nameItemTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.showItemDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.priceItemTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.idItemTextBox = new System.Windows.Forms.TextBox();
            this.showItemButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.searchItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showItemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameItemTextBox
            // 
            this.nameItemTextBox.Location = new System.Drawing.Point(181, 74);
            this.nameItemTextBox.Name = "nameItemTextBox";
            this.nameItemTextBox.Size = new System.Drawing.Size(140, 20);
            this.nameItemTextBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(31, 309);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(87, 33);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // showItemDataGridView
            // 
            this.showItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showItemDataGridView.Location = new System.Drawing.Point(31, 152);
            this.showItemDataGridView.Name = "showItemDataGridView";
            this.showItemDataGridView.Size = new System.Drawing.Size(482, 134);
            this.showItemDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Price";
            // 
            // priceItemTextBox
            // 
            this.priceItemTextBox.Location = new System.Drawing.Point(181, 110);
            this.priceItemTextBox.Name = "priceItemTextBox";
            this.priceItemTextBox.Size = new System.Drawing.Size(140, 20);
            this.priceItemTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // idItemTextBox
            // 
            this.idItemTextBox.Location = new System.Drawing.Point(181, 41);
            this.idItemTextBox.Name = "idItemTextBox";
            this.idItemTextBox.Size = new System.Drawing.Size(140, 20);
            this.idItemTextBox.TabIndex = 1;
            // 
            // showItemButton
            // 
            this.showItemButton.Location = new System.Drawing.Point(127, 309);
            this.showItemButton.Name = "showItemButton";
            this.showItemButton.Size = new System.Drawing.Size(87, 33);
            this.showItemButton.TabIndex = 2;
            this.showItemButton.Text = "Show";
            this.showItemButton.UseVisualStyleBackColor = true;
            this.showItemButton.Click += new System.EventHandler(this.showItemButton_Click);
            // 
            // updateItemButton
            // 
            this.updateItemButton.Location = new System.Drawing.Point(220, 309);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.Size = new System.Drawing.Size(87, 33);
            this.updateItemButton.TabIndex = 2;
            this.updateItemButton.Text = "Update";
            this.updateItemButton.UseVisualStyleBackColor = true;
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(321, 309);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(87, 33);
            this.deleteItemButton.TabIndex = 2;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // searchItemButton
            // 
            this.searchItemButton.Location = new System.Drawing.Point(426, 309);
            this.searchItemButton.Name = "searchItemButton";
            this.searchItemButton.Size = new System.Drawing.Size(87, 33);
            this.searchItemButton.TabIndex = 2;
            this.searchItemButton.Text = "Search";
            this.searchItemButton.UseVisualStyleBackColor = true;
            this.searchItemButton.Click += new System.EventHandler(this.searchItemButton_Click);
            // 
            // ItemUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 373);
            this.Controls.Add(this.showItemDataGridView);
            this.Controls.Add(this.searchItemButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.updateItemButton);
            this.Controls.Add(this.showItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.idItemTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.priceItemTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameItemTextBox);
            this.Controls.Add(this.label1);
            this.Name = "ItemUi";
            this.Text = "ItemUi";
            ((System.ComponentModel.ISupportInitialize)(this.showItemDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameItemTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridView showItemDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceItemTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idItemTextBox;
        private System.Windows.Forms.Button showItemButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button searchItemButton;
    }
}