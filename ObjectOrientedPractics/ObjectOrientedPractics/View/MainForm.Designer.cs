
namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomerstabPage = new System.Windows.Forms.TabPage();
            this.customersTabs1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.tabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.CustomerstabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ItemsTabPage);
            this.tabControl.Controls.Add(this.CustomerstabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(839, 544);
            this.tabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.itemsTab1);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(831, 515);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Items = null;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(825, 509);
            this.itemsTab1.TabIndex = 0;
            // 
            // CustomerstabPage
            // 
            this.CustomerstabPage.Controls.Add(this.customersTabs1);
            this.CustomerstabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomerstabPage.Name = "CustomerstabPage";
            this.CustomerstabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerstabPage.Size = new System.Drawing.Size(831, 515);
            this.CustomerstabPage.TabIndex = 1;
            this.CustomerstabPage.Text = "Customers";
            this.CustomerstabPage.UseVisualStyleBackColor = true;
            // 
            // customersTabs1
            // 
            this.customersTabs1.Customers = null;
            this.customersTabs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTabs1.Location = new System.Drawing.Point(3, 3);
            this.customersTabs1.Name = "customersTabs1";
            this.customersTabs1.Size = new System.Drawing.Size(825, 509);
            this.customersTabs1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 544);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Object Oriented Practics";
            this.tabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.CustomerstabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.TabPage CustomerstabPage;
        private View.Tabs.CustomersTab customersTabs1;
        private View.Tabs.ItemsTab itemsTab1;
    }
}

