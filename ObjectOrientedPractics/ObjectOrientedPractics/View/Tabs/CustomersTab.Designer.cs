
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RemovePanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerPanel = new System.Windows.Forms.Panel();
            this.AddresTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CustomersPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.RemovePanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.SelectedCustomerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Controls.Add(this.ButtonsPanel);
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.Controls.Add(this.CustomersLabel);
            this.CustomersPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(370, 509);
            this.CustomersPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.RemovePanel);
            this.ButtonsPanel.Controls.Add(this.AddPanel);
            this.ButtonsPanel.Location = new System.Drawing.Point(6, 442);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(361, 64);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // RemovePanel
            // 
            this.RemovePanel.Controls.Add(this.RemoveButton);
            this.RemovePanel.Location = new System.Drawing.Point(136, 3);
            this.RemovePanel.Name = "RemovePanel";
            this.RemovePanel.Size = new System.Drawing.Size(127, 58);
            this.RemovePanel.TabIndex = 2;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(121, 52);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddPanel
            // 
            this.AddPanel.Controls.Add(this.AddButton);
            this.AddPanel.Location = new System.Drawing.Point(3, 3);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(127, 58);
            this.AddPanel.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 52);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 16;
            this.CustomersListBox.Location = new System.Drawing.Point(6, 32);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(361, 404);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(6, 12);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(84, 17);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // SelectedCustomerPanel
            // 
            this.SelectedCustomerPanel.Controls.Add(this.AddresTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.AddressLabel);
            this.SelectedCustomerPanel.Controls.Add(this.FullNameTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerPanel.Controls.Add(this.IdTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.SelectedCustomerLabel);
            this.SelectedCustomerPanel.Controls.Add(this.IdLabel);
            this.SelectedCustomerPanel.Location = new System.Drawing.Point(376, 3);
            this.SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            this.SelectedCustomerPanel.Size = new System.Drawing.Size(452, 308);
            this.SelectedCustomerPanel.TabIndex = 1;
            // 
            // AddresTextBox
            // 
            this.AddresTextBox.Location = new System.Drawing.Point(87, 98);
            this.AddresTextBox.Multiline = true;
            this.AddresTextBox.Name = "AddresTextBox";
            this.AddresTextBox.Size = new System.Drawing.Size(359, 191);
            this.AddresTextBox.TabIndex = 8;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 105);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(64, 17);
            this.AddressLabel.TabIndex = 7;
            this.AddressLabel.Text = "Address:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(87, 70);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(359, 22);
            this.FullNameTextBox.TabIndex = 6;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(6, 70);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(75, 17);
            this.FullNameLabel.TabIndex = 5;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(87, 42);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(131, 22);
            this.IdTextBox.TabIndex = 4;
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(6, 12);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(144, 17);
            this.SelectedCustomerLabel.TabIndex = 3;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(6, 42);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 17);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectedCustomerPanel);
            this.Controls.Add(this.CustomersPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(831, 515);
            this.CustomersPanel.ResumeLayout(false);
            this.CustomersPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.RemovePanel.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.SelectedCustomerPanel.ResumeLayout(false);
            this.SelectedCustomerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel RemovePanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.Panel SelectedCustomerPanel;
        private System.Windows.Forms.TextBox AddresTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.Label IdLabel;
    }
}
