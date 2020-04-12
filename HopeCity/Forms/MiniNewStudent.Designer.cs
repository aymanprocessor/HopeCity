namespace HopeCity.Forms
{
    partial class MiniNewStudent
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniNewStudent));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.nationality = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.txtNationalId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNational = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbGender = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnCancel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.txtDOB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.NID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // nationality
            // 
            resources.ApplyResources(this.nationality, "nationality");
            this.nationality.ForeColor = System.Drawing.Color.Navy;
            this.nationality.Name = "nationality";
            // 
            // gender
            // 
            resources.ApplyResources(this.gender, "gender");
            this.gender.ForeColor = System.Drawing.Color.Navy;
            this.gender.Name = "gender";
            // 
            // dob
            // 
            resources.ApplyResources(this.dob, "dob");
            this.dob.ForeColor = System.Drawing.Color.Navy;
            this.dob.Name = "dob";
            // 
            // fullName
            // 
            resources.ApplyResources(this.fullName, "fullName");
            this.fullName.ForeColor = System.Drawing.Color.Navy;
            this.fullName.Name = "fullName";
            // 
            // txtNationalId
            // 
            this.txtNationalId.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtNationalId.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtNationalId.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtNationalId.BorderThickness = 1;
            this.txtNationalId.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtNationalId, "txtNationalId");
            this.txtNationalId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNationalId.isPassword = false;
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNational
            // 
            this.txtNational.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtNational.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtNational.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtNational.BorderThickness = 1;
            this.txtNational.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtNational, "txtNational");
            this.txtNational.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNational.isPassword = false;
            this.txtNational.Name = "txtNational";
            this.txtNational.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtName.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtName.BorderThickness = 1;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.isPassword = false;
            this.txtName.Name = "txtName";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGender.BorderRadius = 2;
            this.cbGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbGender.DisabledColor = System.Drawing.Color.Navy;
            resources.ApplyResources(this.cbGender, "cbGender");
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbGender.Items = new string[] {
        "ذكر",
        "انثي"};
            this.cbGender.Name = "cbGender";
            this.cbGender.NomalColor = System.Drawing.Color.WhiteSmoke;
            this.cbGender.onHoverColor = System.Drawing.Color.White;
            this.cbGender.selectedIndex = -1;
            this.cbGender.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // btnCancel
            // 
            this.btnCancel.AllowToggling = false;
            this.btnCancel.AnimationSpeed = 200;
            this.btnCancel.AutoGenerateColors = false;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Dot;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.ButtonTextMarginLeft = 0;
            this.btnCancel.ColorContrastOnClick = 45;
            this.btnCancel.ColorContrastOnHover = 45;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancel.CustomizableEdges = borderEdges1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnCancel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.IconMarginLeft = 11;
            this.btnCancel.IconPadding = 10;
            this.btnCancel.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.IdleBorderRadius = 3;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.IdleIconLeftImage = null;
            this.btnCancel.IdleIconRightImage = null;
            this.btnCancel.IndicateFocus = false;
            this.btnCancel.Name = "btnCancel";
            stateProperties1.BorderColor = System.Drawing.Color.Red;
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.Red;
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnCancel.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnCancel.OnPressedState = stateProperties2;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.TextMarginLeft = 0;
            this.btnCancel.UseDefaultRadiusAndThickness = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AllowToggling = false;
            this.btnAdd.AnimationSpeed = 200;
            this.btnAdd.AutoGenerateColors = false;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackColor1 = System.Drawing.Color.LimeGreen;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.ButtonTextMarginLeft = 0;
            this.btnAdd.ColorContrastOnClick = 45;
            this.btnAdd.ColorContrastOnHover = 45;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAdd.CustomizableEdges = borderEdges2;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.IconMarginLeft = 11;
            this.btnAdd.IconPadding = 10;
            this.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.IdleBorderColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.IdleBorderRadius = 3;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.IdleIconLeftImage = null;
            this.btnAdd.IdleIconRightImage = null;
            this.btnAdd.IndicateFocus = false;
            this.btnAdd.Name = "btnAdd";
            stateProperties3.BorderColor = System.Drawing.Color.Lime;
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.Lime;
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnAdd.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.LimeGreen;
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.LimeGreen;
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnAdd.OnPressedState = stateProperties4;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.TextMarginLeft = 0;
            this.btnAdd.UseDefaultRadiusAndThickness = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HopeCity.Properties.Resources.add_student;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // picCancel
            // 
            resources.ApplyResources(this.picCancel, "picCancel");
            this.picCancel.Name = "picCancel";
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
            // 
            // txtDOB
            // 
            this.txtDOB.BorderColorFocused = System.Drawing.Color.RoyalBlue;
            this.txtDOB.BorderColorIdle = System.Drawing.Color.Navy;
            this.txtDOB.BorderColorMouseHover = System.Drawing.Color.RoyalBlue;
            this.txtDOB.BorderThickness = 1;
            this.txtDOB.Cursor = System.Windows.Forms.Cursors.IBeam;
            resources.ApplyResources(this.txtDOB, "txtDOB");
            this.txtDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDOB.isPassword = false;
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NID
            // 
            resources.ApplyResources(this.NID, "NID");
            this.NID.ForeColor = System.Drawing.Color.Navy;
            this.NID.Name = "NID";
            // 
            // MiniNewStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.NID);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picCancel);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNational);
            this.Controls.Add(this.txtNationalId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniNewStudent";
            this.Load += new System.EventHandler(this.MiniNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label nationality;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNationalId;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNational;
        private Bunifu.Framework.UI.BunifuDropdown cbGender;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDOB;
        private System.Windows.Forms.Label NID;
    }
}