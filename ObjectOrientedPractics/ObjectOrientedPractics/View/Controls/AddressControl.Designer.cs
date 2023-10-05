
namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AddressPanel = new System.Windows.Forms.Panel();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.DiveleryAddresLabel = new System.Windows.Forms.Label();
            this.AddressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressPanel
            // 
            this.AddressPanel.Controls.Add(this.ApartmentTextBox);
            this.AddressPanel.Controls.Add(this.ApartmentLabel);
            this.AddressPanel.Controls.Add(this.BuildingTextBox);
            this.AddressPanel.Controls.Add(this.BuildingLabel);
            this.AddressPanel.Controls.Add(this.CityTextBox);
            this.AddressPanel.Controls.Add(this.CityLabel);
            this.AddressPanel.Controls.Add(this.StreetTextBox);
            this.AddressPanel.Controls.Add(this.StreetLabel);
            this.AddressPanel.Controls.Add(this.CountryTextBox);
            this.AddressPanel.Controls.Add(this.CountryLabel);
            this.AddressPanel.Controls.Add(this.PostIndexTextBox);
            this.AddressPanel.Controls.Add(this.PostIndexLabel);
            this.AddressPanel.Controls.Add(this.DiveleryAddresLabel);
            this.AddressPanel.Location = new System.Drawing.Point(3, 3);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.Size = new System.Drawing.Size(446, 388);
            this.AddressPanel.TabIndex = 0;
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(309, 130);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(98, 22);
            this.ApartmentTextBox.TabIndex = 12;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(226, 133);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(77, 17);
            this.ApartmentLabel.TabIndex = 11;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(86, 130);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(98, 22);
            this.BuildingTextBox.TabIndex = 10;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(4, 130);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(62, 17);
            this.BuildingLabel.TabIndex = 9;
            this.BuildingLabel.Text = "Building:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(336, 74);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(107, 22);
            this.CityTextBox.TabIndex = 8;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(295, 74);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(35, 17);
            this.CityLabel.TabIndex = 7;
            this.CityLabel.Text = "City:";
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(86, 102);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(357, 22);
            this.StreetTextBox.TabIndex = 6;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(4, 102);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(50, 17);
            this.StreetLabel.TabIndex = 5;
            this.StreetLabel.Text = "Street:";
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(86, 74);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(189, 22);
            this.CountryTextBox.TabIndex = 4;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(4, 74);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(61, 17);
            this.CountryLabel.TabIndex = 3;
            this.CountryLabel.Text = "Country:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(86, 46);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(134, 22);
            this.PostIndexTextBox.TabIndex = 2;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 46);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(77, 17);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // DiveleryAddresLabel
            // 
            this.DiveleryAddresLabel.AutoSize = true;
            this.DiveleryAddresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiveleryAddresLabel.Location = new System.Drawing.Point(3, 11);
            this.DiveleryAddresLabel.Name = "DiveleryAddresLabel";
            this.DiveleryAddresLabel.Size = new System.Drawing.Size(123, 17);
            this.DiveleryAddresLabel.TabIndex = 0;
            this.DiveleryAddresLabel.Text = "Divelery Addres";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressPanel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(452, 394);
            this.AddressPanel.ResumeLayout(false);
            this.AddressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddressPanel;
        private System.Windows.Forms.Label DiveleryAddresLabel;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.Label PostIndexLabel;
    }
}
