namespace RecipesWinForms
{
    partial class frmDataMaintenence
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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSave = new Button();
            pnlOptionButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredient = new RadioButton();
            optMeasurement = new RadioButton();
            optCourse = new RadioButton();
            gData = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            pnlOptionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(btnSave, 1, 1);
            tableLayoutPanel1.Controls.Add(pnlOptionButtons, 0, 0);
            tableLayoutPanel1.Controls.Add(gData, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(707, 509);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Right;
            btnSave.AutoSize = true;
            btnSave.Location = new Point(556, 457);
            btnSave.Margin = new Padding(3, 10, 3, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlOptionButtons
            // 
            pnlOptionButtons.BackColor = SystemColors.ControlDark;
            pnlOptionButtons.Controls.Add(optUsers);
            pnlOptionButtons.Controls.Add(optCuisines);
            pnlOptionButtons.Controls.Add(optIngredient);
            pnlOptionButtons.Controls.Add(optMeasurement);
            pnlOptionButtons.Controls.Add(optCourse);
            pnlOptionButtons.Dock = DockStyle.Fill;
            pnlOptionButtons.FlowDirection = FlowDirection.TopDown;
            pnlOptionButtons.Location = new Point(3, 3);
            pnlOptionButtons.Name = "pnlOptionButtons";
            pnlOptionButtons.Size = new Size(206, 441);
            pnlOptionButtons.TabIndex = 1;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Location = new Point(3, 3);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(66, 25);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.AutoSize = true;
            optCuisines.Location = new Point(3, 34);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(85, 25);
            optCuisines.TabIndex = 1;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            optIngredient.AutoSize = true;
            optIngredient.Location = new Point(3, 65);
            optIngredient.Name = "optIngredient";
            optIngredient.Size = new Size(106, 25);
            optIngredient.TabIndex = 2;
            optIngredient.Text = "Ingredients";
            optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            optMeasurement.AutoSize = true;
            optMeasurement.Location = new Point(3, 96);
            optMeasurement.Name = "optMeasurement";
            optMeasurement.Size = new Size(129, 25);
            optMeasurement.TabIndex = 3;
            optMeasurement.Text = "Measurements";
            optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourse
            // 
            optCourse.AutoSize = true;
            optCourse.Location = new Point(3, 127);
            optCourse.Name = "optCourse";
            optCourse.Size = new Size(83, 25);
            optCourse.TabIndex = 4;
            optCourse.Text = "Courses";
            optCourse.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.BackgroundColor = Color.White;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(215, 3);
            gData.Name = "gData";
            gData.RowTemplate.Height = 25;
            gData.Size = new Size(489, 441);
            gData.TabIndex = 2;
            // 
            // frmDataMaintenence
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(707, 509);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDataMaintenence";
            RightToLeft = RightToLeft.No;
            Text = "Data Maintenence";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlOptionButtons.ResumeLayout(false);
            pnlOptionButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private FlowLayoutPanel pnlOptionButtons;
        private DataGridView gData;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private RadioButton optCourse;
    }
}