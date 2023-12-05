namespace RecipesWinForms
{
    partial class frmSpecificRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSpecificRecipe));
            tblMain = new TableLayoutPanel();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            lblBlankSpace = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tblRecipeDetails = new TableLayoutPanel();
            lblRecipeName = new Label();
            lblCuisine = new Label();
            lblNumberOfCalories = new Label();
            lblCurrentStatus = new Label();
            lblStatusDates = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDateDrafted = new TextBox();
            txtDatePublished = new TextBox();
            txtDateArchived = new TextBox();
            txtRecipeName = new TextBox();
            txtCalories = new TextBox();
            txtCurrentStatus = new TextBox();
            lstCuisineTypeName = new ComboBox();
            lblAuthor = new Label();
            lstUserName = new ComboBox();
            tbRecipeIngredientsAndSteps = new TabControl();
            tabPage1 = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredient = new Button();
            gIngredient = new DataGridView();
            tabPage2 = new TabPage();
            tblSteps = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            tblRecipeDetails.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbRecipeIngredientsAndSteps.SuspendLayout();
            tabPage1.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredient).BeginInit();
            tabPage2.SuspendLayout();
            tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(tsMain, 0, 0);
            tblMain.Controls.Add(tblRecipeDetails, 0, 1);
            tblMain.Controls.Add(tbRecipeIngredientsAndSteps, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(722, 478);
            tblMain.TabIndex = 0;
            // 
            // tsMain
            // 
            tsMain.Dock = DockStyle.Fill;
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator4, lblBlankSpace, toolStripSeparator2, btnChangeStatus, toolStripSeparator3 });
            tsMain.Location = new Point(3, 3);
            tsMain.Margin = new Padding(3);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(716, 28);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 25);
            btnSave.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(58, 25);
            btnDelete.Text = "&Delete";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 28);
            // 
            // lblBlankSpace
            // 
            lblBlankSpace.Name = "lblBlankSpace";
            lblBlankSpace.Size = new Size(205, 25);
            lblBlankSpace.Text = "                                                                  ";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangeStatus.Image = (Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(113, 25);
            btnChangeStatus.Text = "&Change Status";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 28);
            // 
            // tblRecipeDetails
            // 
            tblRecipeDetails.ColumnCount = 2;
            tblRecipeDetails.ColumnStyles.Add(new ColumnStyle());
            tblRecipeDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblRecipeDetails.Controls.Add(lblRecipeName, 0, 0);
            tblRecipeDetails.Controls.Add(lblCuisine, 0, 2);
            tblRecipeDetails.Controls.Add(lblNumberOfCalories, 0, 3);
            tblRecipeDetails.Controls.Add(lblCurrentStatus, 0, 4);
            tblRecipeDetails.Controls.Add(lblStatusDates, 0, 6);
            tblRecipeDetails.Controls.Add(tblStatusDates, 1, 5);
            tblRecipeDetails.Controls.Add(txtRecipeName, 1, 0);
            tblRecipeDetails.Controls.Add(txtCalories, 1, 3);
            tblRecipeDetails.Controls.Add(txtCurrentStatus, 1, 4);
            tblRecipeDetails.Controls.Add(lstCuisineTypeName, 1, 2);
            tblRecipeDetails.Controls.Add(lblAuthor, 0, 1);
            tblRecipeDetails.Controls.Add(lstUserName, 1, 1);
            tblRecipeDetails.Dock = DockStyle.Fill;
            tblRecipeDetails.Location = new Point(3, 37);
            tblRecipeDetails.Name = "tblRecipeDetails";
            tblRecipeDetails.RowCount = 7;
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblRecipeDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblRecipeDetails.Size = new Size(716, 216);
            tblRecipeDetails.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.Anchor = AnchorStyles.Left;
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 4);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(97, 21);
            lblRecipeName.TabIndex = 2;
            lblRecipeName.Text = "&Recipe Name";
            // 
            // lblCuisine
            // 
            lblCuisine.Anchor = AnchorStyles.Left;
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 64);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(60, 21);
            lblCuisine.TabIndex = 6;
            lblCuisine.Text = "&Cuisine";
            // 
            // lblNumberOfCalories
            // 
            lblNumberOfCalories.Anchor = AnchorStyles.Left;
            lblNumberOfCalories.AutoSize = true;
            lblNumberOfCalories.Location = new Point(3, 94);
            lblNumberOfCalories.Name = "lblNumberOfCalories";
            lblNumberOfCalories.Size = new Size(142, 21);
            lblNumberOfCalories.TabIndex = 8;
            lblNumberOfCalories.Text = "&Number Of Calories";
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.Anchor = AnchorStyles.Left;
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Location = new Point(3, 124);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(111, 21);
            lblCurrentStatus.TabIndex = 10;
            lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            lblStatusDates.Anchor = AnchorStyles.Left;
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 187);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(97, 21);
            lblStatusDates.TabIndex = 1;
            lblStatusDates.Text = "Status Dates";
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblPublished, 1, 0);
            tblStatusDates.Controls.Add(lblArchived, 2, 0);
            tblStatusDates.Controls.Add(txtDateDrafted, 0, 1);
            tblStatusDates.Controls.Add(txtDatePublished, 1, 1);
            tblStatusDates.Controls.Add(txtDateArchived, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(151, 153);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblRecipeDetails.SetRowSpan(tblStatusDates, 2);
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusDates.Size = new Size(562, 60);
            tblStatusDates.TabIndex = 0;
            // 
            // lblDrafted
            // 
            lblDrafted.Anchor = AnchorStyles.Bottom;
            lblDrafted.AutoSize = true;
            lblDrafted.Location = new Point(62, 9);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(62, 21);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            // 
            // lblPublished
            // 
            lblPublished.Anchor = AnchorStyles.Bottom;
            lblPublished.AutoSize = true;
            lblPublished.Location = new Point(241, 9);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(78, 21);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            // 
            // lblArchived
            // 
            lblArchived.Anchor = AnchorStyles.Bottom;
            lblArchived.AutoSize = true;
            lblArchived.Location = new Point(433, 9);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(70, 21);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            // 
            // txtDateDrafted
            // 
            txtDateDrafted.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateDrafted.BackColor = Color.Gainsboro;
            txtDateDrafted.BorderStyle = BorderStyle.FixedSingle;
            txtDateDrafted.Enabled = false;
            txtDateDrafted.ForeColor = SystemColors.InfoText;
            txtDateDrafted.Location = new Point(3, 33);
            txtDateDrafted.Name = "txtDateDrafted";
            txtDateDrafted.Size = new Size(181, 28);
            txtDateDrafted.TabIndex = 3;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDatePublished.BackColor = Color.Gainsboro;
            txtDatePublished.BorderStyle = BorderStyle.FixedSingle;
            txtDatePublished.Enabled = false;
            txtDatePublished.ForeColor = SystemColors.InfoText;
            txtDatePublished.Location = new Point(190, 33);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(181, 28);
            txtDatePublished.TabIndex = 4;
            // 
            // txtDateArchived
            // 
            txtDateArchived.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtDateArchived.BackColor = Color.Gainsboro;
            txtDateArchived.BorderStyle = BorderStyle.FixedSingle;
            txtDateArchived.Enabled = false;
            txtDateArchived.ForeColor = SystemColors.InfoText;
            txtDateArchived.Location = new Point(377, 33);
            txtDateArchived.Name = "txtDateArchived";
            txtDateArchived.Size = new Size(182, 28);
            txtDateArchived.TabIndex = 5;
            // 
            // txtRecipeName
            // 
            txtRecipeName.BorderStyle = BorderStyle.FixedSingle;
            txtRecipeName.Dock = DockStyle.Left;
            txtRecipeName.Location = new Point(151, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(163, 28);
            txtRecipeName.TabIndex = 3;
            // 
            // txtCalories
            // 
            txtCalories.BorderStyle = BorderStyle.FixedSingle;
            txtCalories.Dock = DockStyle.Left;
            txtCalories.Location = new Point(151, 93);
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(163, 28);
            txtCalories.TabIndex = 9;
            // 
            // txtCurrentStatus
            // 
            txtCurrentStatus.BackColor = Color.Gainsboro;
            txtCurrentStatus.BorderStyle = BorderStyle.FixedSingle;
            txtCurrentStatus.Dock = DockStyle.Left;
            txtCurrentStatus.Enabled = false;
            txtCurrentStatus.ForeColor = SystemColors.InfoText;
            txtCurrentStatus.Location = new Point(151, 123);
            txtCurrentStatus.Name = "txtCurrentStatus";
            txtCurrentStatus.Size = new Size(163, 28);
            txtCurrentStatus.TabIndex = 11;
            // 
            // lstCuisineTypeName
            // 
            lstCuisineTypeName.Anchor = AnchorStyles.Left;
            lstCuisineTypeName.FormattingEnabled = true;
            lstCuisineTypeName.Location = new Point(151, 63);
            lstCuisineTypeName.Name = "lstCuisineTypeName";
            lstCuisineTypeName.Size = new Size(163, 29);
            lstCuisineTypeName.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.Anchor = AnchorStyles.Left;
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(3, 34);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(58, 21);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "&Author";
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(151, 33);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(163, 29);
            lstUserName.TabIndex = 5;
            // 
            // tbRecipeIngredientsAndSteps
            // 
            tbRecipeIngredientsAndSteps.Controls.Add(tabPage1);
            tbRecipeIngredientsAndSteps.Controls.Add(tabPage2);
            tbRecipeIngredientsAndSteps.Dock = DockStyle.Fill;
            tbRecipeIngredientsAndSteps.Location = new Point(3, 259);
            tbRecipeIngredientsAndSteps.Name = "tbRecipeIngredientsAndSteps";
            tbRecipeIngredientsAndSteps.SelectedIndex = 0;
            tbRecipeIngredientsAndSteps.Size = new Size(716, 216);
            tbRecipeIngredientsAndSteps.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblIngredients);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(708, 182);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingredients";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblIngredients.Controls.Add(btnSaveIngredient, 0, 0);
            tblIngredients.Controls.Add(gIngredient, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.Size = new Size(702, 176);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.AutoSize = true;
            btnSaveIngredient.Location = new Point(3, 3);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(75, 31);
            btnSaveIngredient.TabIndex = 0;
            btnSaveIngredient.Text = "Save";
            btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // gIngredient
            // 
            gIngredient.BackgroundColor = Color.White;
            gIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredient.Dock = DockStyle.Fill;
            gIngredient.Location = new Point(3, 40);
            gIngredient.Name = "gIngredient";
            gIngredient.RowTemplate.Height = 25;
            gIngredient.Size = new Size(696, 150);
            gIngredient.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblSteps);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(708, 188);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Steps";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            tblSteps.ColumnCount = 1;
            tblSteps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSteps.Controls.Add(btnSaveSteps, 0, 0);
            tblSteps.Controls.Add(gSteps, 0, 1);
            tblSteps.Dock = DockStyle.Fill;
            tblSteps.Location = new Point(3, 3);
            tblSteps.Name = "tblSteps";
            tblSteps.RowCount = 2;
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.RowStyles.Add(new RowStyle());
            tblSteps.Size = new Size(702, 182);
            tblSteps.TabIndex = 1;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(75, 31);
            btnSaveSteps.TabIndex = 0;
            btnSaveSteps.Text = "Save";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.BackgroundColor = Color.White;
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 40);
            gSteps.Name = "gSteps";
            gSteps.RowTemplate.Height = 25;
            gSteps.Size = new Size(696, 150);
            gSteps.TabIndex = 1;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(194, 150);
            dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // frmSpecificRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(722, 478);
            Controls.Add(tblMain);
            Font = new Font("Assistant SemiBold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSpecificRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tblRecipeDetails.ResumeLayout(false);
            tblRecipeDetails.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbRecipeIngredientsAndSteps.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredient).EndInit();
            tabPage2.ResumeLayout(false);
            tblSteps.ResumeLayout(false);
            tblSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ToolStrip tsMain;
        private TableLayoutPanel tblRecipeDetails;
        private TabControl tbRecipeIngredientsAndSteps;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredient;
        private DataGridView gIngredient;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
        private Button button1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripLabel lblBlankSpace;
        private ToolStripButton btnChangeStatus;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private Label lblRecipeName;
        private Label lblCuisine;
        private Label lblNumberOfCalories;
        private Label lblCurrentStatus;
        private TableLayoutPanel tblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDateDrafted;
        private TextBox txtDatePublished;
        private TextBox txtDateArchived;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private TextBox txtCurrentStatus;
        private ComboBox lstCuisineTypeName;
        private Label lblStatusDates;
        private Label lblAuthor;
        private ComboBox lstUserName;
    }
}