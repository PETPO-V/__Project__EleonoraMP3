namespace EleonoraMP3
{
    partial class mainWindow
    {
        private System.ComponentModel.IContainer components = null;


        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation2 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonHeaderExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSide = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuButton3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.buttonExplorePoint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.buttonWorkingZone = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel4 = new Bunifu.UI.WinForms.BunifuPanel();
            this.centreWindow = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.songTimer = new System.Windows.Forms.Label();
            this.songSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.buttonPreviousWorkingZone = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonNextWorkingZone = new Bunifu.UI.WinForms.BunifuImageButton();
            this.artistLabelCenter = new System.Windows.Forms.Label();
            this.songLabelCenter = new System.Windows.Forms.Label();
            this.buttonPlayWorkingZone = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEject = new Bunifu.UI.WinForms.BunifuImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bunifuPanel5 = new Bunifu.UI.WinForms.BunifuPanel();
            this.sideWindow = new Bunifu.UI.WinForms.BunifuPages();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.songTimerSide = new System.Windows.Forms.Label();
            this.songSliderSide = new Bunifu.UI.WinForms.BunifuHSlider();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.headerDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.sideDock = new Bunifu.UI.WinForms.BunifuFormDock();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.bunifuPanel4.SuspendLayout();
            this.centreWindow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.bunifuPanel5.SuspendLayout();
            this.sideWindow.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 14;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(11, 10);
            this.bunifuPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.bunifuPictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPictureBox1, "");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "АННЕТТА";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHeader.BorderRadius = 4;
            this.panelHeader.BorderThickness = 4;
            this.panelHeader.Controls.Add(this.label5);
            this.panelHeader.Controls.Add(this.buttonHeaderExit);
            this.panelHeader.Controls.Add(this.label4);
            this.panelHeader.Controls.Add(this.bunifuPictureBox1);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Location = new System.Drawing.Point(-2, -1);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShowBorders = true;
            this.panelHeader.Size = new System.Drawing.Size(760, 53);
            this.panelHeader.TabIndex = 4;
            this.bunifuToolTip1.SetToolTip(this.panelHeader, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelHeader, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelHeader, "");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(570, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "ПОКИНУТЬ ТЕРМИНАЛ";
            this.bunifuToolTip1.SetToolTip(this.label5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label5, "");
            // 
            // buttonHeaderExit
            // 
            this.buttonHeaderExit.ActiveImage = null;
            this.buttonHeaderExit.AllowAnimations = true;
            this.buttonHeaderExit.AllowBuffering = false;
            this.buttonHeaderExit.AllowToggling = false;
            this.buttonHeaderExit.AllowZooming = false;
            this.buttonHeaderExit.AllowZoomingOnFocus = false;
            this.buttonHeaderExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonHeaderExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonHeaderExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonHeaderExit.ErrorImage")));
            this.buttonHeaderExit.FadeWhenInactive = true;
            this.buttonHeaderExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonHeaderExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonHeaderExit.Image")));
            this.buttonHeaderExit.ImageActive = null;
            this.buttonHeaderExit.ImageLocation = null;
            this.buttonHeaderExit.ImageMargin = 0;
            this.buttonHeaderExit.ImageSize = new System.Drawing.Size(30, 32);
            this.buttonHeaderExit.ImageZoomSize = new System.Drawing.Size(30, 32);
            this.buttonHeaderExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonHeaderExit.InitialImage")));
            this.buttonHeaderExit.Location = new System.Drawing.Point(718, 11);
            this.buttonHeaderExit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHeaderExit.Name = "buttonHeaderExit";
            this.buttonHeaderExit.Rotation = 0;
            this.buttonHeaderExit.ShowActiveImage = true;
            this.buttonHeaderExit.ShowCursorChanges = true;
            this.buttonHeaderExit.ShowImageBorders = false;
            this.buttonHeaderExit.ShowSizeMarkers = false;
            this.buttonHeaderExit.Size = new System.Drawing.Size(30, 32);
            this.buttonHeaderExit.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.buttonHeaderExit, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonHeaderExit, null);
            this.buttonHeaderExit.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.buttonHeaderExit, "");
            this.buttonHeaderExit.WaitOnLoad = false;
            this.buttonHeaderExit.Zoom = 0;
            this.buttonHeaderExit.ZoomSpeed = 10;
            this.buttonHeaderExit.Click += new System.EventHandler(this.buttonHeaderExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Molot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(300, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "БСВВ Настройщик. СССР. 1954";
            this.bunifuToolTip1.SetToolTip(this.label4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label4, "");
            // 
            // panelSide
            // 
            this.panelSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSide.BackgroundColor = System.Drawing.Color.Transparent;
            this.panelSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSide.BackgroundImage")));
            this.panelSide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSide.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelSide.BorderRadius = 4;
            this.panelSide.BorderThickness = 4;
            this.panelSide.Controls.Add(this.bunifuButton3);
            this.panelSide.Controls.Add(this.buttonExplorePoint);
            this.panelSide.Controls.Add(this.buttonWorkingZone);
            this.panelSide.Location = new System.Drawing.Point(-2, 57);
            this.panelSide.Margin = new System.Windows.Forms.Padding(2);
            this.panelSide.Name = "panelSide";
            this.panelSide.ShowBorders = true;
            this.panelSide.Size = new System.Drawing.Size(209, 368);
            this.panelSide.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panelSide, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panelSide, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panelSide, "");
            // 
            // bunifuButton3
            // 
            this.bunifuButton3.AllowAnimations = true;
            this.bunifuButton3.AllowMouseEffects = true;
            this.bunifuButton3.AllowToggling = false;
            this.bunifuButton3.AnimationSpeed = 200;
            this.bunifuButton3.AutoGenerateColors = false;
            this.bunifuButton3.AutoRoundBorders = false;
            this.bunifuButton3.AutoSizeLeftIcon = false;
            this.bunifuButton3.AutoSizeRightIcon = true;
            this.bunifuButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackColor1 = System.Drawing.Color.Transparent;
            this.bunifuButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton3.BackgroundImage")));
            this.bunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.ButtonText = "   АУДИОСЕРВАНТ";
            this.bunifuButton3.ButtonTextMarginLeft = 0;
            this.bunifuButton3.ColorContrastOnClick = 45;
            this.bunifuButton3.ColorContrastOnHover = 45;
            this.bunifuButton3.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton3.CustomizableEdges = borderEdges1;
            this.bunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton3.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton3.IconMarginLeft = 11;
            this.bunifuButton3.IconPadding = 10;
            this.bunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton3.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton3.IconSize = 25;
            this.bunifuButton3.IdleBorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.IdleBorderRadius = 1;
            this.bunifuButton3.IdleBorderThickness = 1;
            this.bunifuButton3.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.IdleIconLeftImage = null;
            this.bunifuButton3.IdleIconRightImage = null;
            this.bunifuButton3.IndicateFocus = false;
            this.bunifuButton3.Location = new System.Drawing.Point(2, 155);
            this.bunifuButton3.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuButton3.Name = "bunifuButton3";
            this.bunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton3.OnDisabledState.BorderRadius = 1;
            this.bunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnDisabledState.BorderThickness = 1;
            this.bunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton3.OnDisabledState.IconLeftImage = null;
            this.bunifuButton3.OnDisabledState.IconRightImage = null;
            this.bunifuButton3.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.onHoverState.BorderRadius = 1;
            this.bunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.onHoverState.BorderThickness = 1;
            this.bunifuButton3.onHoverState.FillColor = System.Drawing.Color.DarkRed;
            this.bunifuButton3.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.onHoverState.IconLeftImage = null;
            this.bunifuButton3.onHoverState.IconRightImage = null;
            this.bunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.OnIdleState.BorderRadius = 1;
            this.bunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnIdleState.BorderThickness = 1;
            this.bunifuButton3.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnIdleState.IconLeftImage = null;
            this.bunifuButton3.OnIdleState.IconRightImage = null;
            this.bunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuButton3.OnPressedState.BorderRadius = 1;
            this.bunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton3.OnPressedState.BorderThickness = 1;
            this.bunifuButton3.OnPressedState.FillColor = System.Drawing.Color.DarkRed;
            this.bunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton3.OnPressedState.IconLeftImage = null;
            this.bunifuButton3.OnPressedState.IconRightImage = null;
            this.bunifuButton3.Size = new System.Drawing.Size(202, 53);
            this.bunifuButton3.TabIndex = 2;
            this.bunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton3.TextMarginLeft = 0;
            this.bunifuButton3.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.bunifuButton3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuButton3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuButton3, "");
            this.bunifuButton3.UseDefaultRadiusAndThickness = true;
            this.bunifuButton3.Click += new System.EventHandler(this.bunifuButton3_Click);
            // 
            // buttonExplorePoint
            // 
            this.buttonExplorePoint.AllowAnimations = true;
            this.buttonExplorePoint.AllowMouseEffects = true;
            this.buttonExplorePoint.AllowToggling = false;
            this.buttonExplorePoint.AnimationSpeed = 200;
            this.buttonExplorePoint.AutoGenerateColors = false;
            this.buttonExplorePoint.AutoRoundBorders = false;
            this.buttonExplorePoint.AutoSizeLeftIcon = false;
            this.buttonExplorePoint.AutoSizeRightIcon = true;
            this.buttonExplorePoint.BackColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.BackColor1 = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExplorePoint.BackgroundImage")));
            this.buttonExplorePoint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonExplorePoint.ButtonText = "   ОБЗОРНАЯ ТОЧКА";
            this.buttonExplorePoint.ButtonTextMarginLeft = 0;
            this.buttonExplorePoint.ColorContrastOnClick = 45;
            this.buttonExplorePoint.ColorContrastOnHover = 45;
            this.buttonExplorePoint.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.buttonExplorePoint.CustomizableEdges = borderEdges2;
            this.buttonExplorePoint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonExplorePoint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonExplorePoint.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonExplorePoint.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonExplorePoint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonExplorePoint.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExplorePoint.ForeColor = System.Drawing.Color.White;
            this.buttonExplorePoint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExplorePoint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonExplorePoint.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonExplorePoint.IconMarginLeft = 11;
            this.buttonExplorePoint.IconPadding = 10;
            this.buttonExplorePoint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExplorePoint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonExplorePoint.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonExplorePoint.IconSize = 25;
            this.buttonExplorePoint.IdleBorderColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.IdleBorderRadius = 1;
            this.buttonExplorePoint.IdleBorderThickness = 1;
            this.buttonExplorePoint.IdleFillColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.IdleIconLeftImage = null;
            this.buttonExplorePoint.IdleIconRightImage = null;
            this.buttonExplorePoint.IndicateFocus = false;
            this.buttonExplorePoint.Location = new System.Drawing.Point(2, 98);
            this.buttonExplorePoint.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExplorePoint.Name = "buttonExplorePoint";
            this.buttonExplorePoint.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonExplorePoint.OnDisabledState.BorderRadius = 1;
            this.buttonExplorePoint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonExplorePoint.OnDisabledState.BorderThickness = 1;
            this.buttonExplorePoint.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonExplorePoint.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonExplorePoint.OnDisabledState.IconLeftImage = null;
            this.buttonExplorePoint.OnDisabledState.IconRightImage = null;
            this.buttonExplorePoint.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.onHoverState.BorderRadius = 1;
            this.buttonExplorePoint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonExplorePoint.onHoverState.BorderThickness = 1;
            this.buttonExplorePoint.onHoverState.FillColor = System.Drawing.Color.DarkRed;
            this.buttonExplorePoint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonExplorePoint.onHoverState.IconLeftImage = null;
            this.buttonExplorePoint.onHoverState.IconRightImage = null;
            this.buttonExplorePoint.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.OnIdleState.BorderRadius = 1;
            this.buttonExplorePoint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonExplorePoint.OnIdleState.BorderThickness = 1;
            this.buttonExplorePoint.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.buttonExplorePoint.OnIdleState.IconLeftImage = null;
            this.buttonExplorePoint.OnIdleState.IconRightImage = null;
            this.buttonExplorePoint.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonExplorePoint.OnPressedState.BorderRadius = 1;
            this.buttonExplorePoint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonExplorePoint.OnPressedState.BorderThickness = 1;
            this.buttonExplorePoint.OnPressedState.FillColor = System.Drawing.Color.DarkRed;
            this.buttonExplorePoint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonExplorePoint.OnPressedState.IconLeftImage = null;
            this.buttonExplorePoint.OnPressedState.IconRightImage = null;
            this.buttonExplorePoint.Size = new System.Drawing.Size(202, 53);
            this.buttonExplorePoint.TabIndex = 1;
            this.buttonExplorePoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExplorePoint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonExplorePoint.TextMarginLeft = 0;
            this.buttonExplorePoint.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.buttonExplorePoint, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonExplorePoint, null);
            this.bunifuToolTip1.SetToolTipTitle(this.buttonExplorePoint, "");
            this.buttonExplorePoint.UseDefaultRadiusAndThickness = true;
            this.buttonExplorePoint.Click += new System.EventHandler(this.buttonExplorePoint_Click);
            // 
            // buttonWorkingZone
            // 
            this.buttonWorkingZone.AllowAnimations = true;
            this.buttonWorkingZone.AllowMouseEffects = true;
            this.buttonWorkingZone.AllowToggling = false;
            this.buttonWorkingZone.AnimationSpeed = 200;
            this.buttonWorkingZone.AutoGenerateColors = false;
            this.buttonWorkingZone.AutoRoundBorders = false;
            this.buttonWorkingZone.AutoSizeLeftIcon = false;
            this.buttonWorkingZone.AutoSizeRightIcon = true;
            this.buttonWorkingZone.BackColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.BackColor1 = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonWorkingZone.BackgroundImage")));
            this.buttonWorkingZone.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonWorkingZone.ButtonText = "   РАБОЧАЯ ЗОНА";
            this.buttonWorkingZone.ButtonTextMarginLeft = 0;
            this.buttonWorkingZone.ColorContrastOnClick = 45;
            this.buttonWorkingZone.ColorContrastOnHover = 45;
            this.buttonWorkingZone.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.buttonWorkingZone.CustomizableEdges = borderEdges3;
            this.buttonWorkingZone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonWorkingZone.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonWorkingZone.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonWorkingZone.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonWorkingZone.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.buttonWorkingZone.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWorkingZone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonWorkingZone.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorkingZone.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.buttonWorkingZone.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.buttonWorkingZone.IconMarginLeft = 11;
            this.buttonWorkingZone.IconPadding = 10;
            this.buttonWorkingZone.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWorkingZone.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.buttonWorkingZone.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.buttonWorkingZone.IconSize = 25;
            this.buttonWorkingZone.IdleBorderColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.IdleBorderRadius = 1;
            this.buttonWorkingZone.IdleBorderThickness = 1;
            this.buttonWorkingZone.IdleFillColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.IdleIconLeftImage = null;
            this.buttonWorkingZone.IdleIconRightImage = null;
            this.buttonWorkingZone.IndicateFocus = false;
            this.buttonWorkingZone.Location = new System.Drawing.Point(2, 40);
            this.buttonWorkingZone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonWorkingZone.Name = "buttonWorkingZone";
            this.buttonWorkingZone.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.buttonWorkingZone.OnDisabledState.BorderRadius = 1;
            this.buttonWorkingZone.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonWorkingZone.OnDisabledState.BorderThickness = 1;
            this.buttonWorkingZone.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.buttonWorkingZone.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.buttonWorkingZone.OnDisabledState.IconLeftImage = null;
            this.buttonWorkingZone.OnDisabledState.IconRightImage = null;
            this.buttonWorkingZone.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.onHoverState.BorderRadius = 1;
            this.buttonWorkingZone.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonWorkingZone.onHoverState.BorderThickness = 1;
            this.buttonWorkingZone.onHoverState.FillColor = System.Drawing.Color.DarkRed;
            this.buttonWorkingZone.onHoverState.ForeColor = System.Drawing.Color.White;
            this.buttonWorkingZone.onHoverState.IconLeftImage = null;
            this.buttonWorkingZone.onHoverState.IconRightImage = null;
            this.buttonWorkingZone.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.OnIdleState.BorderRadius = 1;
            this.buttonWorkingZone.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonWorkingZone.OnIdleState.BorderThickness = 1;
            this.buttonWorkingZone.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonWorkingZone.OnIdleState.IconLeftImage = null;
            this.buttonWorkingZone.OnIdleState.IconRightImage = null;
            this.buttonWorkingZone.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.buttonWorkingZone.OnPressedState.BorderRadius = 1;
            this.buttonWorkingZone.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.buttonWorkingZone.OnPressedState.BorderThickness = 1;
            this.buttonWorkingZone.OnPressedState.FillColor = System.Drawing.Color.DarkRed;
            this.buttonWorkingZone.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.buttonWorkingZone.OnPressedState.IconLeftImage = null;
            this.buttonWorkingZone.OnPressedState.IconRightImage = null;
            this.buttonWorkingZone.Size = new System.Drawing.Size(202, 53);
            this.buttonWorkingZone.TabIndex = 0;
            this.buttonWorkingZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWorkingZone.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.buttonWorkingZone.TextMarginLeft = 0;
            this.buttonWorkingZone.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.buttonWorkingZone, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonWorkingZone, null);
            this.bunifuToolTip1.SetToolTipTitle(this.buttonWorkingZone, "");
            this.buttonWorkingZone.UseDefaultRadiusAndThickness = true;
            this.buttonWorkingZone.Click += new System.EventHandler(this.buttonWorkingZone_Click);
            // 
            // bunifuPanel4
            // 
            this.bunifuPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel4.BackgroundImage")));
            this.bunifuPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuPanel4.BorderRadius = 4;
            this.bunifuPanel4.BorderThickness = 4;
            this.bunifuPanel4.Controls.Add(this.centreWindow);
            this.bunifuPanel4.Location = new System.Drawing.Point(212, 57);
            this.bunifuPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel4.Name = "bunifuPanel4";
            this.bunifuPanel4.ShowBorders = true;
            this.bunifuPanel4.Size = new System.Drawing.Size(332, 368);
            this.bunifuPanel4.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.bunifuPanel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPanel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPanel4, "");
            // 
            // centreWindow
            // 
            this.centreWindow.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.centreWindow.AllowTransitions = true;
            this.centreWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centreWindow.Controls.Add(this.tabPage1);
            this.centreWindow.Controls.Add(this.tabPage2);
            this.centreWindow.Controls.Add(this.tabPage5);
            this.centreWindow.Location = new System.Drawing.Point(10, 13);
            this.centreWindow.Margin = new System.Windows.Forms.Padding(2);
            this.centreWindow.Multiline = true;
            this.centreWindow.Name = "centreWindow";
            this.centreWindow.Page = this.tabPage1;
            this.centreWindow.PageIndex = 0;
            this.centreWindow.PageName = "tabPage1";
            this.centreWindow.PageTitle = "tabPage1";
            this.centreWindow.SelectedIndex = 0;
            this.centreWindow.Size = new System.Drawing.Size(312, 346);
            this.centreWindow.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.centreWindow, "");
            this.bunifuToolTip1.SetToolTipIcon(this.centreWindow, null);
            this.bunifuToolTip1.SetToolTipTitle(this.centreWindow, "");
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.centreWindow.Transition = animation1;
            this.centreWindow.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage1.Controls.Add(this.bunifuImageButton4);
            this.tabPage1.Controls.Add(this.player);
            this.tabPage1.Controls.Add(this.songTimer);
            this.tabPage1.Controls.Add(this.songSlider);
            this.tabPage1.Controls.Add(this.buttonPreviousWorkingZone);
            this.tabPage1.Controls.Add(this.buttonNextWorkingZone);
            this.tabPage1.Controls.Add(this.artistLabelCenter);
            this.tabPage1.Controls.Add(this.songLabelCenter);
            this.tabPage1.Controls.Add(this.buttonPlayWorkingZone);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(304, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.bunifuToolTip1.SetToolTip(this.tabPage1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage1, "");
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.ActiveImage = null;
            this.bunifuImageButton4.AllowAnimations = true;
            this.bunifuImageButton4.AllowBuffering = false;
            this.bunifuImageButton4.AllowToggling = false;
            this.bunifuImageButton4.AllowZooming = true;
            this.bunifuImageButton4.AllowZoomingOnFocus = false;
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.ErrorImage")));
            this.bunifuImageButton4.FadeWhenInactive = true;
            this.bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.ImageLocation = null;
            this.bunifuImageButton4.ImageMargin = 0;
            this.bunifuImageButton4.ImageSize = new System.Drawing.Size(69, 69);
            this.bunifuImageButton4.ImageZoomSize = new System.Drawing.Size(70, 70);
            this.bunifuImageButton4.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.InitialImage")));
            this.bunifuImageButton4.Location = new System.Drawing.Point(164, 248);
            this.bunifuImageButton4.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Rotation = 0;
            this.bunifuImageButton4.ShowActiveImage = true;
            this.bunifuImageButton4.ShowCursorChanges = true;
            this.bunifuImageButton4.ShowImageBorders = false;
            this.bunifuImageButton4.ShowSizeMarkers = false;
            this.bunifuImageButton4.Size = new System.Drawing.Size(70, 70);
            this.bunifuImageButton4.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton4, null);
            this.bunifuImageButton4.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton4, "");
            this.bunifuImageButton4.WaitOnLoad = false;
            this.bunifuImageButton4.Zoom = 0;
            this.bunifuImageButton4.ZoomSpeed = 10;
            this.bunifuImageButton4.Click += new System.EventHandler(this.bunifuImageButton4_Click_1);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(401, 0);
            this.player.Margin = new System.Windows.Forms.Padding(2);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(11, 10);
            this.player.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.player, "");
            this.bunifuToolTip1.SetToolTipIcon(this.player, null);
            this.bunifuToolTip1.SetToolTipTitle(this.player, "");
            // 
            // songTimer
            // 
            this.songTimer.AutoSize = true;
            this.songTimer.Font = new System.Drawing.Font("Molot", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songTimer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.songTimer.Location = new System.Drawing.Point(133, 234);
            this.songTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.songTimer.Name = "songTimer";
            this.songTimer.Size = new System.Drawing.Size(38, 14);
            this.songTimer.TabIndex = 13;
            this.songTimer.Text = "00:00";
            this.bunifuToolTip1.SetToolTip(this.songTimer, "");
            this.bunifuToolTip1.SetToolTipIcon(this.songTimer, null);
            this.bunifuToolTip1.SetToolTipTitle(this.songTimer, "");
            // 
            // songSlider
            // 
            this.songSlider.AllowCursorChanges = true;
            this.songSlider.AllowHomeEndKeysDetection = false;
            this.songSlider.AllowIncrementalClickMoves = true;
            this.songSlider.AllowMouseDownEffects = false;
            this.songSlider.AllowMouseHoverEffects = false;
            this.songSlider.AllowScrollingAnimations = true;
            this.songSlider.AllowScrollKeysDetection = true;
            this.songSlider.AllowScrollOptionsMenu = true;
            this.songSlider.AllowShrinkingOnFocusLost = false;
            this.songSlider.BackColor = System.Drawing.Color.Transparent;
            this.songSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songSlider.BackgroundImage")));
            this.songSlider.BindingContainer = null;
            this.songSlider.BorderRadius = 2;
            this.songSlider.BorderThickness = 1;
            this.songSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songSlider.DrawThickBorder = false;
            this.songSlider.DurationBeforeShrink = 2000;
            this.songSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.songSlider.LargeChange = 10;
            this.songSlider.Location = new System.Drawing.Point(74, 206);
            this.songSlider.Maximum = 100;
            this.songSlider.Minimum = 0;
            this.songSlider.MinimumSize = new System.Drawing.Size(0, 25);
            this.songSlider.MinimumThumbLength = 18;
            this.songSlider.Name = "songSlider";
            this.songSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.songSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.songSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.songSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songSlider.ShrinkSizeLimit = 3;
            this.songSlider.Size = new System.Drawing.Size(160, 25);
            this.songSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.songSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.songSlider.SmallChange = 1;
            this.songSlider.TabIndex = 0;
            this.songSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.songSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.songSlider.ThumbLength = 18;
            this.songSlider.ThumbMargin = 1;
            this.songSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.songSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.songSlider, "");
            this.bunifuToolTip1.SetToolTipIcon(this.songSlider, null);
            this.bunifuToolTip1.SetToolTipTitle(this.songSlider, "");
            this.songSlider.Value = 50;
            // 
            // buttonPreviousWorkingZone
            // 
            this.buttonPreviousWorkingZone.ActiveImage = null;
            this.buttonPreviousWorkingZone.AllowAnimations = true;
            this.buttonPreviousWorkingZone.AllowBuffering = false;
            this.buttonPreviousWorkingZone.AllowToggling = false;
            this.buttonPreviousWorkingZone.AllowZooming = true;
            this.buttonPreviousWorkingZone.AllowZoomingOnFocus = false;
            this.buttonPreviousWorkingZone.BackColor = System.Drawing.Color.Transparent;
            this.buttonPreviousWorkingZone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPreviousWorkingZone.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonPreviousWorkingZone.ErrorImage")));
            this.buttonPreviousWorkingZone.FadeWhenInactive = true;
            this.buttonPreviousWorkingZone.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonPreviousWorkingZone.Image = ((System.Drawing.Image)(resources.GetObject("buttonPreviousWorkingZone.Image")));
            this.buttonPreviousWorkingZone.ImageActive = null;
            this.buttonPreviousWorkingZone.ImageLocation = null;
            this.buttonPreviousWorkingZone.ImageMargin = 0;
            this.buttonPreviousWorkingZone.ImageSize = new System.Drawing.Size(44, 44);
            this.buttonPreviousWorkingZone.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.buttonPreviousWorkingZone.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonPreviousWorkingZone.InitialImage")));
            this.buttonPreviousWorkingZone.Location = new System.Drawing.Point(27, 258);
            this.buttonPreviousWorkingZone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPreviousWorkingZone.Name = "buttonPreviousWorkingZone";
            this.buttonPreviousWorkingZone.Rotation = 0;
            this.buttonPreviousWorkingZone.ShowActiveImage = true;
            this.buttonPreviousWorkingZone.ShowCursorChanges = true;
            this.buttonPreviousWorkingZone.ShowImageBorders = false;
            this.buttonPreviousWorkingZone.ShowSizeMarkers = false;
            this.buttonPreviousWorkingZone.Size = new System.Drawing.Size(45, 45);
            this.buttonPreviousWorkingZone.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.buttonPreviousWorkingZone, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonPreviousWorkingZone, null);
            this.buttonPreviousWorkingZone.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.buttonPreviousWorkingZone, "");
            this.buttonPreviousWorkingZone.WaitOnLoad = false;
            this.buttonPreviousWorkingZone.Zoom = 0;
            this.buttonPreviousWorkingZone.ZoomSpeed = 10;
            this.buttonPreviousWorkingZone.Click += new System.EventHandler(this.buttonPreviousWorkingZone_Click);
            // 
            // buttonNextWorkingZone
            // 
            this.buttonNextWorkingZone.ActiveImage = null;
            this.buttonNextWorkingZone.AllowAnimations = true;
            this.buttonNextWorkingZone.AllowBuffering = false;
            this.buttonNextWorkingZone.AllowToggling = false;
            this.buttonNextWorkingZone.AllowZooming = true;
            this.buttonNextWorkingZone.AllowZoomingOnFocus = false;
            this.buttonNextWorkingZone.BackColor = System.Drawing.Color.Transparent;
            this.buttonNextWorkingZone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonNextWorkingZone.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonNextWorkingZone.ErrorImage")));
            this.buttonNextWorkingZone.FadeWhenInactive = true;
            this.buttonNextWorkingZone.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonNextWorkingZone.Image = ((System.Drawing.Image)(resources.GetObject("buttonNextWorkingZone.Image")));
            this.buttonNextWorkingZone.ImageActive = null;
            this.buttonNextWorkingZone.ImageLocation = null;
            this.buttonNextWorkingZone.ImageMargin = 0;
            this.buttonNextWorkingZone.ImageSize = new System.Drawing.Size(44, 44);
            this.buttonNextWorkingZone.ImageZoomSize = new System.Drawing.Size(45, 45);
            this.buttonNextWorkingZone.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonNextWorkingZone.InitialImage")));
            this.buttonNextWorkingZone.Location = new System.Drawing.Point(236, 258);
            this.buttonNextWorkingZone.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNextWorkingZone.Name = "buttonNextWorkingZone";
            this.buttonNextWorkingZone.Rotation = 0;
            this.buttonNextWorkingZone.ShowActiveImage = true;
            this.buttonNextWorkingZone.ShowCursorChanges = true;
            this.buttonNextWorkingZone.ShowImageBorders = false;
            this.buttonNextWorkingZone.ShowSizeMarkers = false;
            this.buttonNextWorkingZone.Size = new System.Drawing.Size(45, 45);
            this.buttonNextWorkingZone.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.buttonNextWorkingZone, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonNextWorkingZone, null);
            this.buttonNextWorkingZone.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.buttonNextWorkingZone, "");
            this.buttonNextWorkingZone.WaitOnLoad = false;
            this.buttonNextWorkingZone.Zoom = 0;
            this.buttonNextWorkingZone.ZoomSpeed = 10;
            this.buttonNextWorkingZone.Click += new System.EventHandler(this.buttonNextWorkingZone_Click);
            // 
            // artistLabelCenter
            // 
            this.artistLabelCenter.AutoSize = true;
            this.artistLabelCenter.Font = new System.Drawing.Font("Molot", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artistLabelCenter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.artistLabelCenter.Location = new System.Drawing.Point(72, 191);
            this.artistLabelCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.artistLabelCenter.Name = "artistLabelCenter";
            this.artistLabelCenter.Size = new System.Drawing.Size(79, 12);
            this.artistLabelCenter.TabIndex = 4;
            this.artistLabelCenter.Text = "Исполнитель";
            this.bunifuToolTip1.SetToolTip(this.artistLabelCenter, "");
            this.bunifuToolTip1.SetToolTipIcon(this.artistLabelCenter, null);
            this.bunifuToolTip1.SetToolTipTitle(this.artistLabelCenter, "");
            // 
            // songLabelCenter
            // 
            this.songLabelCenter.AutoSize = true;
            this.songLabelCenter.Font = new System.Drawing.Font("Molot", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.songLabelCenter.ForeColor = System.Drawing.SystemColors.Control;
            this.songLabelCenter.Location = new System.Drawing.Point(70, 172);
            this.songLabelCenter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.songLabelCenter.Name = "songLabelCenter";
            this.songLabelCenter.Size = new System.Drawing.Size(123, 19);
            this.songLabelCenter.TabIndex = 3;
            this.songLabelCenter.Text = "АУДИОГРАММА";
            this.bunifuToolTip1.SetToolTip(this.songLabelCenter, "");
            this.bunifuToolTip1.SetToolTipIcon(this.songLabelCenter, null);
            this.bunifuToolTip1.SetToolTipTitle(this.songLabelCenter, "");
            // 
            // buttonPlayWorkingZone
            // 
            this.buttonPlayWorkingZone.ActiveImage = null;
            this.buttonPlayWorkingZone.AllowAnimations = true;
            this.buttonPlayWorkingZone.AllowBuffering = false;
            this.buttonPlayWorkingZone.AllowToggling = false;
            this.buttonPlayWorkingZone.AllowZooming = true;
            this.buttonPlayWorkingZone.AllowZoomingOnFocus = false;
            this.buttonPlayWorkingZone.BackColor = System.Drawing.Color.Transparent;
            this.buttonPlayWorkingZone.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonPlayWorkingZone.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayWorkingZone.ErrorImage")));
            this.buttonPlayWorkingZone.FadeWhenInactive = true;
            this.buttonPlayWorkingZone.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonPlayWorkingZone.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayWorkingZone.Image")));
            this.buttonPlayWorkingZone.ImageActive = null;
            this.buttonPlayWorkingZone.ImageLocation = null;
            this.buttonPlayWorkingZone.ImageMargin = 0;
            this.buttonPlayWorkingZone.ImageSize = new System.Drawing.Size(69, 69);
            this.buttonPlayWorkingZone.ImageZoomSize = new System.Drawing.Size(70, 70);
            this.buttonPlayWorkingZone.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonPlayWorkingZone.InitialImage")));
            this.buttonPlayWorkingZone.Location = new System.Drawing.Point(74, 248);
            this.buttonPlayWorkingZone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayWorkingZone.Name = "buttonPlayWorkingZone";
            this.buttonPlayWorkingZone.Rotation = 0;
            this.buttonPlayWorkingZone.ShowActiveImage = true;
            this.buttonPlayWorkingZone.ShowCursorChanges = true;
            this.buttonPlayWorkingZone.ShowImageBorders = false;
            this.buttonPlayWorkingZone.ShowSizeMarkers = false;
            this.buttonPlayWorkingZone.Size = new System.Drawing.Size(70, 70);
            this.buttonPlayWorkingZone.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.buttonPlayWorkingZone, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonPlayWorkingZone, null);
            this.buttonPlayWorkingZone.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.buttonPlayWorkingZone, "");
            this.buttonPlayWorkingZone.WaitOnLoad = false;
            this.buttonPlayWorkingZone.Zoom = 0;
            this.buttonPlayWorkingZone.ZoomSpeed = 10;
            this.buttonPlayWorkingZone.Click += new System.EventHandler(this.buttonPlayWorkingZone_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            this.pictureBox1.WaitOnLoad = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage2.Controls.Add(this.buttonEject);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(304, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.bunifuToolTip1.SetToolTip(this.tabPage2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage2, "");
            // 
            // buttonEject
            // 
            this.buttonEject.ActiveImage = null;
            this.buttonEject.AllowAnimations = true;
            this.buttonEject.AllowBuffering = false;
            this.buttonEject.AllowToggling = false;
            this.buttonEject.AllowZooming = true;
            this.buttonEject.AllowZoomingOnFocus = false;
            this.buttonEject.BackColor = System.Drawing.Color.Transparent;
            this.buttonEject.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonEject.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonEject.ErrorImage")));
            this.buttonEject.FadeWhenInactive = true;
            this.buttonEject.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonEject.Image = ((System.Drawing.Image)(resources.GetObject("buttonEject.Image")));
            this.buttonEject.ImageActive = null;
            this.buttonEject.ImageLocation = null;
            this.buttonEject.ImageMargin = 0;
            this.buttonEject.ImageSize = new System.Drawing.Size(49, 49);
            this.buttonEject.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.buttonEject.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonEject.InitialImage")));
            this.buttonEject.Location = new System.Drawing.Point(128, 268);
            this.buttonEject.Name = "buttonEject";
            this.buttonEject.Rotation = 0;
            this.buttonEject.ShowActiveImage = true;
            this.buttonEject.ShowCursorChanges = true;
            this.buttonEject.ShowImageBorders = true;
            this.buttonEject.ShowSizeMarkers = false;
            this.buttonEject.Size = new System.Drawing.Size(50, 50);
            this.buttonEject.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.buttonEject, "");
            this.bunifuToolTip1.SetToolTipIcon(this.buttonEject, null);
            this.buttonEject.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.buttonEject, "");
            this.buttonEject.WaitOnLoad = false;
            this.buttonEject.Zoom = 0;
            this.buttonEject.ZoomSpeed = 10;
            this.buttonEject.Click += new System.EventHandler(this.buttonEject_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Molot", 10.2F);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(294, 256);
            this.listBox1.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.listBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.listBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.listBox1, "");
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(304, 320);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.bunifuToolTip1.SetToolTip(this.tabPage5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage5, "");
            // 
            // bunifuPanel5
            // 
            this.bunifuPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel5.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel5.BackgroundImage")));
            this.bunifuPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuPanel5.BorderRadius = 4;
            this.bunifuPanel5.BorderThickness = 4;
            this.bunifuPanel5.Controls.Add(this.sideWindow);
            this.bunifuPanel5.Location = new System.Drawing.Point(548, 57);
            this.bunifuPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuPanel5.Name = "bunifuPanel5";
            this.bunifuPanel5.ShowBorders = true;
            this.bunifuPanel5.Size = new System.Drawing.Size(210, 368);
            this.bunifuPanel5.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.bunifuPanel5, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuPanel5, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuPanel5, "");
            // 
            // sideWindow
            // 
            this.sideWindow.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.sideWindow.AllowTransitions = true;
            this.sideWindow.Controls.Add(this.tabPage3);
            this.sideWindow.Controls.Add(this.tabPage4);
            this.sideWindow.Location = new System.Drawing.Point(9, 13);
            this.sideWindow.Margin = new System.Windows.Forms.Padding(2);
            this.sideWindow.Multiline = true;
            this.sideWindow.Name = "sideWindow";
            this.sideWindow.Page = this.tabPage4;
            this.sideWindow.PageIndex = 1;
            this.sideWindow.PageName = "tabPage4";
            this.sideWindow.PageTitle = "tabPage4";
            this.sideWindow.SelectedIndex = 0;
            this.sideWindow.Size = new System.Drawing.Size(194, 346);
            this.sideWindow.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.sideWindow, "");
            this.bunifuToolTip1.SetToolTipIcon(this.sideWindow, null);
            this.bunifuToolTip1.SetToolTipTitle(this.sideWindow, "");
            animation2.AnimateOnlyDifferences = false;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.sideWindow.Transition = animation2;
            this.sideWindow.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(186, 320);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.bunifuToolTip1.SetToolTip(this.tabPage3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage3, "");
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.ForeColor = System.Drawing.Color.White;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(11, 28);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(162, 288);
            this.listBox2.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.listBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.listBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.listBox2, "");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(38, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "РЯД АУДИОГРАММ";
            this.bunifuToolTip1.SetToolTip(this.label7, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label7, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label7, "");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(68, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.songTimerSide);
            this.tabPage4.Controls.Add(this.songSliderSide);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(186, 320);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.bunifuToolTip1.SetToolTip(this.tabPage4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.tabPage4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.tabPage4, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Molot", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(15, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ТЕКУЩАЯ АУДИОГРАММА";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // songTimerSide
            // 
            this.songTimerSide.AutoSize = true;
            this.songTimerSide.Font = new System.Drawing.Font("Molot", 12F);
            this.songTimerSide.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.songTimerSide.Location = new System.Drawing.Point(65, 284);
            this.songTimerSide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.songTimerSide.Name = "songTimerSide";
            this.songTimerSide.Size = new System.Drawing.Size(49, 19);
            this.songTimerSide.TabIndex = 14;
            this.songTimerSide.Text = "00:00";
            this.bunifuToolTip1.SetToolTip(this.songTimerSide, "");
            this.bunifuToolTip1.SetToolTipIcon(this.songTimerSide, null);
            this.bunifuToolTip1.SetToolTipTitle(this.songTimerSide, "");
            // 
            // songSliderSide
            // 
            this.songSliderSide.AllowCursorChanges = true;
            this.songSliderSide.AllowHomeEndKeysDetection = false;
            this.songSliderSide.AllowIncrementalClickMoves = true;
            this.songSliderSide.AllowMouseDownEffects = false;
            this.songSliderSide.AllowMouseHoverEffects = false;
            this.songSliderSide.AllowScrollingAnimations = true;
            this.songSliderSide.AllowScrollKeysDetection = true;
            this.songSliderSide.AllowScrollOptionsMenu = true;
            this.songSliderSide.AllowShrinkingOnFocusLost = false;
            this.songSliderSide.BackColor = System.Drawing.Color.Transparent;
            this.songSliderSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songSliderSide.BackgroundImage")));
            this.songSliderSide.BindingContainer = null;
            this.songSliderSide.BorderRadius = 2;
            this.songSliderSide.BorderThickness = 1;
            this.songSliderSide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songSliderSide.DrawThickBorder = false;
            this.songSliderSide.DurationBeforeShrink = 2000;
            this.songSliderSide.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.songSliderSide.LargeChange = 10;
            this.songSliderSide.Location = new System.Drawing.Point(24, 248);
            this.songSliderSide.Maximum = 100;
            this.songSliderSide.Minimum = 0;
            this.songSliderSide.MinimumSize = new System.Drawing.Size(0, 25);
            this.songSliderSide.MinimumThumbLength = 18;
            this.songSliderSide.Name = "songSliderSide";
            this.songSliderSide.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.songSliderSide.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.songSliderSide.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.songSliderSide.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songSliderSide.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songSliderSide.ShrinkSizeLimit = 3;
            this.songSliderSide.Size = new System.Drawing.Size(140, 25);
            this.songSliderSide.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.songSliderSide.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.songSliderSide.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.songSliderSide.SmallChange = 1;
            this.songSliderSide.TabIndex = 6;
            this.songSliderSide.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.songSliderSide.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.songSliderSide.ThumbLength = 18;
            this.songSliderSide.ThumbMargin = 1;
            this.songSliderSide.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.songSliderSide.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.bunifuToolTip1.SetToolTip(this.songSliderSide, "");
            this.bunifuToolTip1.SetToolTipIcon(this.songSliderSide, null);
            this.bunifuToolTip1.SetToolTipTitle(this.songSliderSide, "");
            this.songSliderSide.Value = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Molot", 9.8F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(22, 213);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Исполнитель";
            this.bunifuToolTip1.SetToolTip(this.label9, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label9, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label9, "");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Molot", 12.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(20, 193);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "АУДИОГРАММА";
            this.bunifuToolTip1.SetToolTip(this.label8, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label8, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label8, "");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 140);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox2, "");
            // 
            // headerDock
            // 
            this.headerDock.AllowFormDragging = true;
            this.headerDock.AllowFormDropShadow = true;
            this.headerDock.AllowFormResizing = false;
            this.headerDock.AllowHidingBottomRegion = true;
            this.headerDock.AllowOpacityChangesWhileDragging = false;
            this.headerDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.headerDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.headerDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.headerDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.headerDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.headerDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.headerDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.headerDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.headerDock.BorderOptions.RightBorder.ShowBorder = true;
            this.headerDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.headerDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.headerDock.BorderOptions.TopBorder.ShowBorder = true;
            this.headerDock.ContainerControl = this;
            this.headerDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.headerDock.DockingIndicatorsOpacity = 0.5D;
            this.headerDock.DockingOptions.DockAll = true;
            this.headerDock.DockingOptions.DockBottomLeft = true;
            this.headerDock.DockingOptions.DockBottomRight = true;
            this.headerDock.DockingOptions.DockFullScreen = true;
            this.headerDock.DockingOptions.DockLeft = true;
            this.headerDock.DockingOptions.DockRight = true;
            this.headerDock.DockingOptions.DockTopLeft = true;
            this.headerDock.DockingOptions.DockTopRight = true;
            this.headerDock.FormDraggingOpacity = 0.9D;
            this.headerDock.ParentForm = this;
            this.headerDock.ShowCursorChanges = false;
            this.headerDock.ShowDockingIndicators = false;
            this.headerDock.TitleBarOptions.AllowFormDragging = true;
            this.headerDock.TitleBarOptions.BunifuFormDock = this.headerDock;
            this.headerDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.headerDock.TitleBarOptions.TitleBarControl = this.panelHeader;
            this.headerDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // sideDock
            // 
            this.sideDock.AllowFormDragging = true;
            this.sideDock.AllowFormDropShadow = true;
            this.sideDock.AllowFormResizing = false;
            this.sideDock.AllowHidingBottomRegion = true;
            this.sideDock.AllowOpacityChangesWhileDragging = false;
            this.sideDock.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.sideDock.BorderOptions.BottomBorder.BorderThickness = 1;
            this.sideDock.BorderOptions.BottomBorder.ShowBorder = true;
            this.sideDock.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.sideDock.BorderOptions.LeftBorder.BorderThickness = 1;
            this.sideDock.BorderOptions.LeftBorder.ShowBorder = true;
            this.sideDock.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.sideDock.BorderOptions.RightBorder.BorderThickness = 1;
            this.sideDock.BorderOptions.RightBorder.ShowBorder = true;
            this.sideDock.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.sideDock.BorderOptions.TopBorder.BorderThickness = 1;
            this.sideDock.BorderOptions.TopBorder.ShowBorder = true;
            this.sideDock.ContainerControl = this;
            this.sideDock.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.sideDock.DockingIndicatorsOpacity = 0.5D;
            this.sideDock.DockingOptions.DockAll = true;
            this.sideDock.DockingOptions.DockBottomLeft = true;
            this.sideDock.DockingOptions.DockBottomRight = true;
            this.sideDock.DockingOptions.DockFullScreen = true;
            this.sideDock.DockingOptions.DockLeft = true;
            this.sideDock.DockingOptions.DockRight = true;
            this.sideDock.DockingOptions.DockTopLeft = true;
            this.sideDock.DockingOptions.DockTopRight = true;
            this.sideDock.FormDraggingOpacity = 0.9D;
            this.sideDock.ParentForm = this;
            this.sideDock.ShowCursorChanges = false;
            this.sideDock.ShowDockingIndicators = false;
            this.sideDock.TitleBarOptions.AllowFormDragging = true;
            this.sideDock.TitleBarOptions.BunifuFormDock = this.sideDock;
            this.sideDock.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.sideDock.TitleBarOptions.TitleBarControl = this.panelSide;
            this.sideDock.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(754, 427);
            this.Controls.Add(this.bunifuPanel4);
            this.Controls.Add(this.bunifuPanel5);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSide.ResumeLayout(false);
            this.bunifuPanel4.ResumeLayout(false);
            this.centreWindow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.bunifuPanel5.ResumeLayout(false);
            this.sideWindow.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }


        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPanel panelHeader;
        private Bunifu.UI.WinForms.BunifuPanel panelSide;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel4;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonWorkingZone;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton buttonExplorePoint;
        private Bunifu.UI.WinForms.BunifuPages centreWindow;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuFormDock headerDock;
        private Bunifu.UI.WinForms.BunifuFormDock sideDock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton buttonPlayWorkingZone;
        private System.Windows.Forms.Label artistLabelCenter;
        private System.Windows.Forms.Label songLabelCenter;
        private Bunifu.UI.WinForms.BunifuImageButton buttonPreviousWorkingZone;
        private Bunifu.UI.WinForms.BunifuImageButton buttonNextWorkingZone;
        private System.Windows.Forms.Label songTimer;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private Bunifu.UI.WinForms.BunifuHSlider songSlider;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuImageButton buttonHeaderExit;
        private System.Windows.Forms.Label label5;
        private Bunifu.UI.WinForms.BunifuPages sideWindow;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label songTimerSide;
        private Bunifu.UI.WinForms.BunifuHSlider songSliderSide;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.UI.WinForms.BunifuImageButton buttonEject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

