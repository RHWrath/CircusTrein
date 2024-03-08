namespace CircusTrein
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Size = new Label();
            comboBoxSize = new ComboBox();
            Diet = new Label();
            comboBoxDiet = new ComboBox();
            AddAnimal = new Button();
            AnimalListTxt = new TextBox();
            label2 = new Label();
            CalculateAnimal = new Button();
            WagensTxt = new TextBox();
            label3 = new Label();
            ClearAnimalListButton = new Button();
            ClearWagon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "input animals";
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Location = new Point(12, 46);
            Size.Name = "Size";
            Size.Size = new Size(36, 20);
            Size.TabIndex = 1;
            Size.Text = "Size";
            // 
            // comboBoxSize
            // 
            comboBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSize.FormattingEnabled = true;
            comboBoxSize.Location = new Point(54, 38);
            comboBoxSize.Name = "comboBoxSize";
            comboBoxSize.Size = new Size(151, 28);
            comboBoxSize.TabIndex = 2;
            // 
            // Diet
            // 
            Diet.AutoSize = true;
            Diet.Location = new Point(12, 91);
            Diet.Name = "Diet";
            Diet.Size = new Size(37, 20);
            Diet.TabIndex = 3;
            Diet.Text = "Diet";
            // 
            // comboBoxDiet
            // 
            comboBoxDiet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDiet.FormattingEnabled = true;
            comboBoxDiet.Location = new Point(54, 83);
            comboBoxDiet.Name = "comboBoxDiet";
            comboBoxDiet.Size = new Size(151, 28);
            comboBoxDiet.TabIndex = 4;
            // 
            // AddAnimal
            // 
            AddAnimal.Location = new Point(54, 117);
            AddAnimal.Name = "AddAnimal";
            AddAnimal.Size = new Size(121, 73);
            AddAnimal.TabIndex = 5;
            AddAnimal.Text = "Add Animal";
            AddAnimal.UseVisualStyleBackColor = true;
            AddAnimal.Click += AddAnimal_Click;
            // 
            // AnimalListTxt
            // 
            AnimalListTxt.Location = new Point(564, 46);
            AnimalListTxt.Multiline = true;
            AnimalListTxt.Name = "AnimalListTxt";
            AnimalListTxt.ReadOnly = true;
            AnimalListTxt.Size = new Size(339, 196);
            AnimalListTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(704, 9);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Animal list";
            // 
            // CalculateAnimal
            // 
            CalculateAnimal.Location = new Point(54, 196);
            CalculateAnimal.Name = "CalculateAnimal";
            CalculateAnimal.Size = new Size(121, 79);
            CalculateAnimal.TabIndex = 8;
            CalculateAnimal.Text = "Calculate";
            CalculateAnimal.UseVisualStyleBackColor = true;
            CalculateAnimal.Click += CalculateAnimal_Click;
            // 
            // WagensTxt
            // 
            WagensTxt.Location = new Point(54, 356);
            WagensTxt.Name = "WagensTxt";
            WagensTxt.ReadOnly = true;
            WagensTxt.Size = new Size(117, 27);
            WagensTxt.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 333);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 10;
            label3.Text = "Aantal wagonen";
            // 
            // ClearAnimalListButton
            // 
            ClearAnimalListButton.Location = new Point(564, 258);
            ClearAnimalListButton.Name = "ClearAnimalListButton";
            ClearAnimalListButton.Size = new Size(94, 29);
            ClearAnimalListButton.TabIndex = 11;
            ClearAnimalListButton.Text = "Clear";
            ClearAnimalListButton.UseVisualStyleBackColor = true;
            ClearAnimalListButton.Click += ClearAnimalListButton_Click;
            // 
            // ClearWagon
            // 
            ClearWagon.Location = new Point(54, 398);
            ClearWagon.Name = "ClearWagon";
            ClearWagon.Size = new Size(94, 29);
            ClearWagon.TabIndex = 12;
            ClearWagon.Text = "Clear";
            ClearWagon.UseVisualStyleBackColor = true;
            ClearWagon.Click += ClearWagon_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 450);
            Controls.Add(ClearWagon);
            Controls.Add(ClearAnimalListButton);
            Controls.Add(label3);
            Controls.Add(WagensTxt);
            Controls.Add(CalculateAnimal);
            Controls.Add(label2);
            Controls.Add(AnimalListTxt);
            Controls.Add(AddAnimal);
            Controls.Add(comboBoxDiet);
            Controls.Add(Diet);
            Controls.Add(comboBoxSize);
            Controls.Add(Size);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Size;
        private ComboBox comboBoxSize;
        private Label Diet;
        private ComboBox comboBoxDiet;
        private Button AddAnimal;
        private TextBox AnimalListTxt;
        private Label label2;
        private Button CalculateAnimal;
        private TextBox WagensTxt;
        private Label label3;
        private Button ClearAnimalListButton;
        private Button ClearWagon;
    }
}
