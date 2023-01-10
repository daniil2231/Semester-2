
namespace AnimalDemoInClassWithAbstract
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
            this.cbAnimalType = new System.Windows.Forms.ComboBox();
            this.tbAnimalName = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.lbAnimals = new System.Windows.Forms.ListBox();
            this.btnMakeAnimalSpeak = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAnimalType
            // 
            this.cbAnimalType.FormattingEnabled = true;
            this.cbAnimalType.Items.AddRange(new object[] {
            "Duck",
            "Cat",
            "Dog"});
            this.cbAnimalType.Location = new System.Drawing.Point(118, 21);
            this.cbAnimalType.Name = "cbAnimalType";
            this.cbAnimalType.Size = new System.Drawing.Size(121, 24);
            this.cbAnimalType.TabIndex = 0;
            // 
            // tbAnimalName
            // 
            this.tbAnimalName.Location = new System.Drawing.Point(12, 23);
            this.tbAnimalName.Name = "tbAnimalName";
            this.tbAnimalName.Size = new System.Drawing.Size(100, 22);
            this.tbAnimalName.TabIndex = 1;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(56, 62);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(117, 32);
            this.btnAddAnimal.TabIndex = 2;
            this.btnAddAnimal.Text = "Add animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // lbAnimals
            // 
            this.lbAnimals.FormattingEnabled = true;
            this.lbAnimals.ItemHeight = 16;
            this.lbAnimals.Location = new System.Drawing.Point(13, 108);
            this.lbAnimals.Name = "lbAnimals";
            this.lbAnimals.Size = new System.Drawing.Size(226, 212);
            this.lbAnimals.TabIndex = 3;
            // 
            // btnMakeAnimalSpeak
            // 
            this.btnMakeAnimalSpeak.Location = new System.Drawing.Point(46, 326);
            this.btnMakeAnimalSpeak.Name = "btnMakeAnimalSpeak";
            this.btnMakeAnimalSpeak.Size = new System.Drawing.Size(139, 48);
            this.btnMakeAnimalSpeak.TabIndex = 4;
            this.btnMakeAnimalSpeak.Text = "Make selected animal speak";
            this.btnMakeAnimalSpeak.UseVisualStyleBackColor = true;
            this.btnMakeAnimalSpeak.Click += new System.EventHandler(this.btnMakeAnimalSpeak_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.Location = new System.Drawing.Point(118, 3);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(44, 17);
            this.lblAnimalType.TabIndex = 6;
            this.lblAnimalType.Text = "Type:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 394);
            this.Controls.Add(this.lblAnimalType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnMakeAnimalSpeak);
            this.Controls.Add(this.lbAnimals);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.tbAnimalName);
            this.Controls.Add(this.cbAnimalType);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAnimalType;
        private System.Windows.Forms.TextBox tbAnimalName;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListBox lbAnimals;
        private System.Windows.Forms.Button btnMakeAnimalSpeak;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAnimalType;
    }
}

