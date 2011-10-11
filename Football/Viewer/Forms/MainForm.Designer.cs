namespace Viewer.Forms
{
    partial class MainForm
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
            this.m_btnStart = new System.Windows.Forms.Button();
            this.m_btnStop = new System.Windows.Forms.Button();
            this.m_btnPause = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.m_statusStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this._groupBoxViewerSettings = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.m_tabListView = new System.Windows.Forms.TabControl();
            this.m_tabTopView = new System.Windows.Forms.TabPage();
            this.m_imgTopView = new System.Windows.Forms.PictureBox();
            this.m_tabSideView = new System.Windows.Forms.TabPage();
            this.m_imgSideView = new System.Windows.Forms.PictureBox();
            this.m_tabData = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.m_lblDataSecondTeamNameValue = new System.Windows.Forms.Label();
            this.m_lblDataSecondTeamScoreValue = new System.Windows.Forms.Label();
            this.m_lblDataSecondTeamPlayersCountValue = new System.Windows.Forms.Label();
            this.m_lblDataSecondTeamScore = new System.Windows.Forms.Label();
            this.m_lblDataSecondTeamPlayersCount = new System.Windows.Forms.Label();
            this.m_lblDataSecondTeamName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_lblDataFirstTeamPlayersCountValue = new System.Windows.Forms.Label();
            this.m_lblDataFirstTeamNameValue = new System.Windows.Forms.Label();
            this.m_lblDataFirstTeamScoreValue = new System.Windows.Forms.Label();
            this.m_lblDataFirstTeamScore = new System.Windows.Forms.Label();
            this.m_lblDataFirstTeamPlayersCount = new System.Windows.Forms.Label();
            this.m_lblDataFirstTeamName = new System.Windows.Forms.Label();
            this.m_groupGame = new System.Windows.Forms.GroupBox();
            this.m_lblDataGameTimeValue = new System.Windows.Forms.Label();
            this.m_lblDataGameStatusValue = new System.Windows.Forms.Label();
            this.m_lblDataGameStatus = new System.Windows.Forms.Label();
            this.m_lblDataGameTime = new System.Windows.Forms.Label();
            this.m_groupDataBall = new System.Windows.Forms.GroupBox();
            this.m_lblDataBallWzValue = new System.Windows.Forms.Label();
            this.m_lblDataBallWyValue = new System.Windows.Forms.Label();
            this.m_lblDataBallWxValue = new System.Windows.Forms.Label();
            this.m_lblDataBallWz = new System.Windows.Forms.Label();
            this.m_lblDataBallWy = new System.Windows.Forms.Label();
            this.m_lblDataBallWx = new System.Windows.Forms.Label();
            this.m_lblDataBallVzValue = new System.Windows.Forms.Label();
            this.m_lblDataBallVyValue = new System.Windows.Forms.Label();
            this.m_lblDataBallVxValue = new System.Windows.Forms.Label();
            this.m_lblDataBallVz = new System.Windows.Forms.Label();
            this.m_lblDataBallVy = new System.Windows.Forms.Label();
            this.m_lblDataBallVx = new System.Windows.Forms.Label();
            this.m_lblDataBallZValue = new System.Windows.Forms.Label();
            this.m_lblDataBallYValue = new System.Windows.Forms.Label();
            this.m_lblDataBallXValue = new System.Windows.Forms.Label();
            this.m_lblDataBallZ = new System.Windows.Forms.Label();
            this.m_lblDataBallY = new System.Windows.Forms.Label();
            this.m_lblDataBallX = new System.Windows.Forms.Label();
            this.m_tabLog = new System.Windows.Forms.TabPage();
            this.m_btnClearLog = new System.Windows.Forms.Button();
            this.m_btnSaveLog = new System.Windows.Forms.Button();
            this.m_textLog = new System.Windows.Forms.TextBox();
            this._groupBoxActions = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.m_tabListView.SuspendLayout();
            this.m_tabTopView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_imgTopView)).BeginInit();
            this.m_tabSideView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_imgSideView)).BeginInit();
            this.m_tabData.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.m_groupGame.SuspendLayout();
            this.m_groupDataBall.SuspendLayout();
            this.m_tabLog.SuspendLayout();
            this._groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnStart
            // 
            this.m_btnStart.Location = new System.Drawing.Point(6, 48);
            this.m_btnStart.Name = "m_btnStart";
            this.m_btnStart.Size = new System.Drawing.Size(75, 23);
            this.m_btnStart.TabIndex = 0;
            this.m_btnStart.Text = "Start";
            this.m_btnStart.UseVisualStyleBackColor = true;
            // 
            // m_btnStop
            // 
            this.m_btnStop.Location = new System.Drawing.Point(87, 48);
            this.m_btnStop.Name = "m_btnStop";
            this.m_btnStop.Size = new System.Drawing.Size(75, 23);
            this.m_btnStop.TabIndex = 1;
            this.m_btnStop.Text = "Stop";
            this.m_btnStop.UseVisualStyleBackColor = true;
            // 
            // m_btnPause
            // 
            this.m_btnPause.Location = new System.Drawing.Point(168, 48);
            this.m_btnPause.Name = "m_btnPause";
            this.m_btnPause.Size = new System.Drawing.Size(75, 23);
            this.m_btnPause.TabIndex = 2;
            this.m_btnPause.Text = "Pause";
            this.m_btnPause.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_statusStatus,
            this.m_statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(792, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // m_statusStatus
            // 
            this.m_statusStatus.Name = "m_statusStatus";
            this.m_statusStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // m_statusTime
            // 
            this.m_statusTime.Name = "m_statusTime";
            this.m_statusTime.Size = new System.Drawing.Size(0, 17);
            // 
            // _groupBoxViewerSettings
            // 
            this._groupBoxViewerSettings.Location = new System.Drawing.Point(12, 12);
            this._groupBoxViewerSettings.Name = "_groupBoxViewerSettings";
            this._groupBoxViewerSettings.Size = new System.Drawing.Size(441, 80);
            this._groupBoxViewerSettings.TabIndex = 5;
            this._groupBoxViewerSettings.TabStop = false;
            this._groupBoxViewerSettings.Text = "Viewer settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "New game...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // m_tabListView
            // 
            this.m_tabListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_tabListView.Controls.Add(this.m_tabTopView);
            this.m_tabListView.Controls.Add(this.m_tabSideView);
            this.m_tabListView.Controls.Add(this.m_tabData);
            this.m_tabListView.Controls.Add(this.m_tabLog);
            this.m_tabListView.Location = new System.Drawing.Point(12, 98);
            this.m_tabListView.Name = "m_tabListView";
            this.m_tabListView.SelectedIndex = 0;
            this.m_tabListView.Size = new System.Drawing.Size(768, 500);
            this.m_tabListView.TabIndex = 6;
            // 
            // m_tabTopView
            // 
            this.m_tabTopView.Controls.Add(this.m_imgTopView);
            this.m_tabTopView.Location = new System.Drawing.Point(4, 22);
            this.m_tabTopView.Name = "m_tabTopView";
            this.m_tabTopView.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabTopView.Size = new System.Drawing.Size(760, 474);
            this.m_tabTopView.TabIndex = 0;
            this.m_tabTopView.Text = "Top view";
            this.m_tabTopView.UseVisualStyleBackColor = true;
            // 
            // m_imgTopView
            // 
            this.m_imgTopView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_imgTopView.InitialImage = null;
            this.m_imgTopView.Location = new System.Drawing.Point(3, 3);
            this.m_imgTopView.Name = "m_imgTopView";
            this.m_imgTopView.Size = new System.Drawing.Size(754, 468);
            this.m_imgTopView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_imgTopView.TabIndex = 0;
            this.m_imgTopView.TabStop = false;
            // 
            // m_tabSideView
            // 
            this.m_tabSideView.Controls.Add(this.m_imgSideView);
            this.m_tabSideView.Location = new System.Drawing.Point(4, 22);
            this.m_tabSideView.Name = "m_tabSideView";
            this.m_tabSideView.Padding = new System.Windows.Forms.Padding(3);
            this.m_tabSideView.Size = new System.Drawing.Size(760, 474);
            this.m_tabSideView.TabIndex = 1;
            this.m_tabSideView.Text = "Side view";
            this.m_tabSideView.UseVisualStyleBackColor = true;
            // 
            // m_imgSideView
            // 
            this.m_imgSideView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_imgSideView.Location = new System.Drawing.Point(3, 3);
            this.m_imgSideView.Name = "m_imgSideView";
            this.m_imgSideView.Size = new System.Drawing.Size(754, 468);
            this.m_imgSideView.TabIndex = 0;
            this.m_imgSideView.TabStop = false;
            // 
            // m_tabData
            // 
            this.m_tabData.Controls.Add(this.groupBox3);
            this.m_tabData.Controls.Add(this.groupBox2);
            this.m_tabData.Controls.Add(this.m_groupGame);
            this.m_tabData.Controls.Add(this.m_groupDataBall);
            this.m_tabData.Location = new System.Drawing.Point(4, 22);
            this.m_tabData.Name = "m_tabData";
            this.m_tabData.Size = new System.Drawing.Size(760, 474);
            this.m_tabData.TabIndex = 2;
            this.m_tabData.Text = "Data";
            this.m_tabData.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.m_lblDataSecondTeamNameValue);
            this.groupBox3.Controls.Add(this.m_lblDataSecondTeamScoreValue);
            this.groupBox3.Controls.Add(this.m_lblDataSecondTeamPlayersCountValue);
            this.groupBox3.Controls.Add(this.m_lblDataSecondTeamScore);
            this.groupBox3.Controls.Add(this.m_lblDataSecondTeamPlayersCount);
            this.groupBox3.Controls.Add(this.m_lblDataSecondTeamName);
            this.groupBox3.Location = new System.Drawing.Point(383, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Second Team";
            // 
            // m_lblDataSecondTeamNameValue
            // 
            this.m_lblDataSecondTeamNameValue.AutoSize = true;
            this.m_lblDataSecondTeamNameValue.Location = new System.Drawing.Point(86, 16);
            this.m_lblDataSecondTeamNameValue.Name = "m_lblDataSecondTeamNameValue";
            this.m_lblDataSecondTeamNameValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataSecondTeamNameValue.TabIndex = 5;
            this.m_lblDataSecondTeamNameValue.Text = "label12";
            // 
            // m_lblDataSecondTeamScoreValue
            // 
            this.m_lblDataSecondTeamScoreValue.AutoSize = true;
            this.m_lblDataSecondTeamScoreValue.Location = new System.Drawing.Point(86, 62);
            this.m_lblDataSecondTeamScoreValue.Name = "m_lblDataSecondTeamScoreValue";
            this.m_lblDataSecondTeamScoreValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataSecondTeamScoreValue.TabIndex = 4;
            this.m_lblDataSecondTeamScoreValue.Text = "label11";
            // 
            // m_lblDataSecondTeamPlayersCountValue
            // 
            this.m_lblDataSecondTeamPlayersCountValue.AutoSize = true;
            this.m_lblDataSecondTeamPlayersCountValue.Location = new System.Drawing.Point(86, 38);
            this.m_lblDataSecondTeamPlayersCountValue.Name = "m_lblDataSecondTeamPlayersCountValue";
            this.m_lblDataSecondTeamPlayersCountValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataSecondTeamPlayersCountValue.TabIndex = 3;
            this.m_lblDataSecondTeamPlayersCountValue.Text = "label10";
            // 
            // m_lblDataSecondTeamScore
            // 
            this.m_lblDataSecondTeamScore.AutoSize = true;
            this.m_lblDataSecondTeamScore.Location = new System.Drawing.Point(6, 62);
            this.m_lblDataSecondTeamScore.Name = "m_lblDataSecondTeamScore";
            this.m_lblDataSecondTeamScore.Size = new System.Drawing.Size(38, 13);
            this.m_lblDataSecondTeamScore.TabIndex = 2;
            this.m_lblDataSecondTeamScore.Text = "Score:";
            // 
            // m_lblDataSecondTeamPlayersCount
            // 
            this.m_lblDataSecondTeamPlayersCount.AutoSize = true;
            this.m_lblDataSecondTeamPlayersCount.Location = new System.Drawing.Point(6, 38);
            this.m_lblDataSecondTeamPlayersCount.Name = "m_lblDataSecondTeamPlayersCount";
            this.m_lblDataSecondTeamPlayersCount.Size = new System.Drawing.Size(74, 13);
            this.m_lblDataSecondTeamPlayersCount.TabIndex = 1;
            this.m_lblDataSecondTeamPlayersCount.Text = "Players count:";
            // 
            // m_lblDataSecondTeamName
            // 
            this.m_lblDataSecondTeamName.AutoSize = true;
            this.m_lblDataSecondTeamName.Location = new System.Drawing.Point(6, 16);
            this.m_lblDataSecondTeamName.Name = "m_lblDataSecondTeamName";
            this.m_lblDataSecondTeamName.Size = new System.Drawing.Size(38, 13);
            this.m_lblDataSecondTeamName.TabIndex = 0;
            this.m_lblDataSecondTeamName.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_lblDataFirstTeamPlayersCountValue);
            this.groupBox2.Controls.Add(this.m_lblDataFirstTeamNameValue);
            this.groupBox2.Controls.Add(this.m_lblDataFirstTeamScoreValue);
            this.groupBox2.Controls.Add(this.m_lblDataFirstTeamScore);
            this.groupBox2.Controls.Add(this.m_lblDataFirstTeamPlayersCount);
            this.groupBox2.Controls.Add(this.m_lblDataFirstTeamName);
            this.groupBox2.Location = new System.Drawing.Point(5, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First Team";
            // 
            // m_lblDataFirstTeamPlayersCountValue
            // 
            this.m_lblDataFirstTeamPlayersCountValue.AutoSize = true;
            this.m_lblDataFirstTeamPlayersCountValue.Location = new System.Drawing.Point(86, 38);
            this.m_lblDataFirstTeamPlayersCountValue.Name = "m_lblDataFirstTeamPlayersCountValue";
            this.m_lblDataFirstTeamPlayersCountValue.Size = new System.Drawing.Size(35, 13);
            this.m_lblDataFirstTeamPlayersCountValue.TabIndex = 5;
            this.m_lblDataFirstTeamPlayersCountValue.Text = "label9";
            // 
            // m_lblDataFirstTeamNameValue
            // 
            this.m_lblDataFirstTeamNameValue.AutoSize = true;
            this.m_lblDataFirstTeamNameValue.Location = new System.Drawing.Point(86, 16);
            this.m_lblDataFirstTeamNameValue.Name = "m_lblDataFirstTeamNameValue";
            this.m_lblDataFirstTeamNameValue.Size = new System.Drawing.Size(35, 13);
            this.m_lblDataFirstTeamNameValue.TabIndex = 4;
            this.m_lblDataFirstTeamNameValue.Text = "label8";
            // 
            // m_lblDataFirstTeamScoreValue
            // 
            this.m_lblDataFirstTeamScoreValue.AutoSize = true;
            this.m_lblDataFirstTeamScoreValue.Location = new System.Drawing.Point(86, 62);
            this.m_lblDataFirstTeamScoreValue.Name = "m_lblDataFirstTeamScoreValue";
            this.m_lblDataFirstTeamScoreValue.Size = new System.Drawing.Size(35, 13);
            this.m_lblDataFirstTeamScoreValue.TabIndex = 3;
            this.m_lblDataFirstTeamScoreValue.Text = "label7";
            // 
            // m_lblDataFirstTeamScore
            // 
            this.m_lblDataFirstTeamScore.AutoSize = true;
            this.m_lblDataFirstTeamScore.Location = new System.Drawing.Point(6, 62);
            this.m_lblDataFirstTeamScore.Name = "m_lblDataFirstTeamScore";
            this.m_lblDataFirstTeamScore.Size = new System.Drawing.Size(38, 13);
            this.m_lblDataFirstTeamScore.TabIndex = 2;
            this.m_lblDataFirstTeamScore.Text = "Score:";
            // 
            // m_lblDataFirstTeamPlayersCount
            // 
            this.m_lblDataFirstTeamPlayersCount.AutoSize = true;
            this.m_lblDataFirstTeamPlayersCount.Location = new System.Drawing.Point(6, 38);
            this.m_lblDataFirstTeamPlayersCount.Name = "m_lblDataFirstTeamPlayersCount";
            this.m_lblDataFirstTeamPlayersCount.Size = new System.Drawing.Size(74, 13);
            this.m_lblDataFirstTeamPlayersCount.TabIndex = 1;
            this.m_lblDataFirstTeamPlayersCount.Text = "Players count:";
            // 
            // m_lblDataFirstTeamName
            // 
            this.m_lblDataFirstTeamName.AutoSize = true;
            this.m_lblDataFirstTeamName.Location = new System.Drawing.Point(6, 16);
            this.m_lblDataFirstTeamName.Name = "m_lblDataFirstTeamName";
            this.m_lblDataFirstTeamName.Size = new System.Drawing.Size(38, 13);
            this.m_lblDataFirstTeamName.TabIndex = 0;
            this.m_lblDataFirstTeamName.Text = "Name:";
            // 
            // m_groupGame
            // 
            this.m_groupGame.Controls.Add(this.m_lblDataGameTimeValue);
            this.m_groupGame.Controls.Add(this.m_lblDataGameStatusValue);
            this.m_groupGame.Controls.Add(this.m_lblDataGameStatus);
            this.m_groupGame.Controls.Add(this.m_lblDataGameTime);
            this.m_groupGame.Location = new System.Drawing.Point(5, 3);
            this.m_groupGame.Name = "m_groupGame";
            this.m_groupGame.Size = new System.Drawing.Size(372, 85);
            this.m_groupGame.TabIndex = 1;
            this.m_groupGame.TabStop = false;
            this.m_groupGame.Text = "Game";
            // 
            // m_lblDataGameTimeValue
            // 
            this.m_lblDataGameTimeValue.AutoSize = true;
            this.m_lblDataGameTimeValue.Location = new System.Drawing.Point(52, 38);
            this.m_lblDataGameTimeValue.Name = "m_lblDataGameTimeValue";
            this.m_lblDataGameTimeValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataGameTimeValue.TabIndex = 3;
            this.m_lblDataGameTimeValue.Text = "label14";
            // 
            // m_lblDataGameStatusValue
            // 
            this.m_lblDataGameStatusValue.AutoSize = true;
            this.m_lblDataGameStatusValue.Location = new System.Drawing.Point(52, 16);
            this.m_lblDataGameStatusValue.Name = "m_lblDataGameStatusValue";
            this.m_lblDataGameStatusValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataGameStatusValue.TabIndex = 2;
            this.m_lblDataGameStatusValue.Text = "label13";
            // 
            // m_lblDataGameStatus
            // 
            this.m_lblDataGameStatus.AutoSize = true;
            this.m_lblDataGameStatus.Location = new System.Drawing.Point(6, 16);
            this.m_lblDataGameStatus.Name = "m_lblDataGameStatus";
            this.m_lblDataGameStatus.Size = new System.Drawing.Size(40, 13);
            this.m_lblDataGameStatus.TabIndex = 1;
            this.m_lblDataGameStatus.Text = "Status:";
            // 
            // m_lblDataGameTime
            // 
            this.m_lblDataGameTime.AutoSize = true;
            this.m_lblDataGameTime.Location = new System.Drawing.Point(6, 38);
            this.m_lblDataGameTime.Name = "m_lblDataGameTime";
            this.m_lblDataGameTime.Size = new System.Drawing.Size(33, 13);
            this.m_lblDataGameTime.TabIndex = 0;
            this.m_lblDataGameTime.Text = "Time:";
            // 
            // m_groupDataBall
            // 
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallWzValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallWyValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallWxValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallWz);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallWy);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallWx);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallVzValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallVyValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallVxValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallVz);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallVy);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallVx);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallZValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallYValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallXValue);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallZ);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallY);
            this.m_groupDataBall.Controls.Add(this.m_lblDataBallX);
            this.m_groupDataBall.Location = new System.Drawing.Point(383, 3);
            this.m_groupDataBall.Name = "m_groupDataBall";
            this.m_groupDataBall.Size = new System.Drawing.Size(390, 85);
            this.m_groupDataBall.TabIndex = 0;
            this.m_groupDataBall.TabStop = false;
            this.m_groupDataBall.Text = "Ball";
            // 
            // m_lblDataBallWzValue
            // 
            this.m_lblDataBallWzValue.AutoSize = true;
            this.m_lblDataBallWzValue.Location = new System.Drawing.Point(339, 60);
            this.m_lblDataBallWzValue.Name = "m_lblDataBallWzValue";
            this.m_lblDataBallWzValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataBallWzValue.TabIndex = 17;
            this.m_lblDataBallWzValue.Text = "label18";
            // 
            // m_lblDataBallWyValue
            // 
            this.m_lblDataBallWyValue.AutoSize = true;
            this.m_lblDataBallWyValue.Location = new System.Drawing.Point(339, 38);
            this.m_lblDataBallWyValue.Name = "m_lblDataBallWyValue";
            this.m_lblDataBallWyValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataBallWyValue.TabIndex = 16;
            this.m_lblDataBallWyValue.Text = "label17";
            // 
            // m_lblDataBallWxValue
            // 
            this.m_lblDataBallWxValue.AutoSize = true;
            this.m_lblDataBallWxValue.Location = new System.Drawing.Point(339, 16);
            this.m_lblDataBallWxValue.Name = "m_lblDataBallWxValue";
            this.m_lblDataBallWxValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataBallWxValue.TabIndex = 15;
            this.m_lblDataBallWxValue.Text = "label16";
            // 
            // m_lblDataBallWz
            // 
            this.m_lblDataBallWz.AutoSize = true;
            this.m_lblDataBallWz.Location = new System.Drawing.Point(278, 60);
            this.m_lblDataBallWz.Name = "m_lblDataBallWz";
            this.m_lblDataBallWz.Size = new System.Drawing.Size(55, 13);
            this.m_lblDataBallWz.TabIndex = 14;
            this.m_lblDataBallWz.Text = "Ωz: (r./s.):";
            // 
            // m_lblDataBallWy
            // 
            this.m_lblDataBallWy.AutoSize = true;
            this.m_lblDataBallWy.Location = new System.Drawing.Point(278, 38);
            this.m_lblDataBallWy.Name = "m_lblDataBallWy";
            this.m_lblDataBallWy.Size = new System.Drawing.Size(55, 13);
            this.m_lblDataBallWy.TabIndex = 13;
            this.m_lblDataBallWy.Text = "Ωy: (r./s.):";
            // 
            // m_lblDataBallWx
            // 
            this.m_lblDataBallWx.AutoSize = true;
            this.m_lblDataBallWx.Location = new System.Drawing.Point(278, 16);
            this.m_lblDataBallWx.Name = "m_lblDataBallWx";
            this.m_lblDataBallWx.Size = new System.Drawing.Size(55, 13);
            this.m_lblDataBallWx.TabIndex = 12;
            this.m_lblDataBallWx.Text = "Ωx: (r./s.):";
            // 
            // m_lblDataBallVzValue
            // 
            this.m_lblDataBallVzValue.AutoSize = true;
            this.m_lblDataBallVzValue.Location = new System.Drawing.Point(193, 60);
            this.m_lblDataBallVzValue.Name = "m_lblDataBallVzValue";
            this.m_lblDataBallVzValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataBallVzValue.TabIndex = 11;
            this.m_lblDataBallVzValue.Text = "label12";
            // 
            // m_lblDataBallVyValue
            // 
            this.m_lblDataBallVyValue.AutoSize = true;
            this.m_lblDataBallVyValue.Location = new System.Drawing.Point(193, 38);
            this.m_lblDataBallVyValue.Name = "m_lblDataBallVyValue";
            this.m_lblDataBallVyValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataBallVyValue.TabIndex = 10;
            this.m_lblDataBallVyValue.Text = "label11";
            // 
            // m_lblDataBallVxValue
            // 
            this.m_lblDataBallVxValue.AutoSize = true;
            this.m_lblDataBallVxValue.Location = new System.Drawing.Point(193, 16);
            this.m_lblDataBallVxValue.Name = "m_lblDataBallVxValue";
            this.m_lblDataBallVxValue.Size = new System.Drawing.Size(41, 13);
            this.m_lblDataBallVxValue.TabIndex = 9;
            this.m_lblDataBallVxValue.Text = "label10";
            // 
            // m_lblDataBallVz
            // 
            this.m_lblDataBallVz.AutoSize = true;
            this.m_lblDataBallVz.Location = new System.Drawing.Point(132, 60);
            this.m_lblDataBallVz.Name = "m_lblDataBallVz";
            this.m_lblDataBallVz.Size = new System.Drawing.Size(55, 13);
            this.m_lblDataBallVz.TabIndex = 8;
            this.m_lblDataBallVz.Text = "Vz (m./s.):";
            // 
            // m_lblDataBallVy
            // 
            this.m_lblDataBallVy.AutoSize = true;
            this.m_lblDataBallVy.Location = new System.Drawing.Point(132, 38);
            this.m_lblDataBallVy.Name = "m_lblDataBallVy";
            this.m_lblDataBallVy.Size = new System.Drawing.Size(55, 13);
            this.m_lblDataBallVy.TabIndex = 7;
            this.m_lblDataBallVy.Text = "Vy (m./s.):";
            // 
            // m_lblDataBallVx
            // 
            this.m_lblDataBallVx.AutoSize = true;
            this.m_lblDataBallVx.Location = new System.Drawing.Point(132, 16);
            this.m_lblDataBallVx.Name = "m_lblDataBallVx";
            this.m_lblDataBallVx.Size = new System.Drawing.Size(55, 13);
            this.m_lblDataBallVx.TabIndex = 6;
            this.m_lblDataBallVx.Text = "Vx (m./s.):";
            // 
            // m_lblDataBallZValue
            // 
            this.m_lblDataBallZValue.AutoSize = true;
            this.m_lblDataBallZValue.Location = new System.Drawing.Point(49, 60);
            this.m_lblDataBallZValue.Name = "m_lblDataBallZValue";
            this.m_lblDataBallZValue.Size = new System.Drawing.Size(35, 13);
            this.m_lblDataBallZValue.TabIndex = 5;
            this.m_lblDataBallZValue.Text = "label6";
            // 
            // m_lblDataBallYValue
            // 
            this.m_lblDataBallYValue.AutoSize = true;
            this.m_lblDataBallYValue.Location = new System.Drawing.Point(49, 38);
            this.m_lblDataBallYValue.Name = "m_lblDataBallYValue";
            this.m_lblDataBallYValue.Size = new System.Drawing.Size(35, 13);
            this.m_lblDataBallYValue.TabIndex = 4;
            this.m_lblDataBallYValue.Text = "label5";
            // 
            // m_lblDataBallXValue
            // 
            this.m_lblDataBallXValue.AutoSize = true;
            this.m_lblDataBallXValue.Location = new System.Drawing.Point(49, 16);
            this.m_lblDataBallXValue.Name = "m_lblDataBallXValue";
            this.m_lblDataBallXValue.Size = new System.Drawing.Size(35, 13);
            this.m_lblDataBallXValue.TabIndex = 3;
            this.m_lblDataBallXValue.Text = "label4";
            // 
            // m_lblDataBallZ
            // 
            this.m_lblDataBallZ.AutoSize = true;
            this.m_lblDataBallZ.Location = new System.Drawing.Point(6, 60);
            this.m_lblDataBallZ.Name = "m_lblDataBallZ";
            this.m_lblDataBallZ.Size = new System.Drawing.Size(37, 13);
            this.m_lblDataBallZ.TabIndex = 2;
            this.m_lblDataBallZ.Text = "Z (m.):";
            // 
            // m_lblDataBallY
            // 
            this.m_lblDataBallY.AutoSize = true;
            this.m_lblDataBallY.Location = new System.Drawing.Point(6, 38);
            this.m_lblDataBallY.Name = "m_lblDataBallY";
            this.m_lblDataBallY.Size = new System.Drawing.Size(37, 13);
            this.m_lblDataBallY.TabIndex = 1;
            this.m_lblDataBallY.Text = "Y (m.):";
            // 
            // m_lblDataBallX
            // 
            this.m_lblDataBallX.AutoSize = true;
            this.m_lblDataBallX.Location = new System.Drawing.Point(6, 16);
            this.m_lblDataBallX.Name = "m_lblDataBallX";
            this.m_lblDataBallX.Size = new System.Drawing.Size(37, 13);
            this.m_lblDataBallX.TabIndex = 0;
            this.m_lblDataBallX.Text = "X (m.):";
            // 
            // m_tabLog
            // 
            this.m_tabLog.Controls.Add(this.m_btnClearLog);
            this.m_tabLog.Controls.Add(this.m_btnSaveLog);
            this.m_tabLog.Controls.Add(this.m_textLog);
            this.m_tabLog.Location = new System.Drawing.Point(4, 22);
            this.m_tabLog.Name = "m_tabLog";
            this.m_tabLog.Size = new System.Drawing.Size(760, 474);
            this.m_tabLog.TabIndex = 3;
            this.m_tabLog.Text = "Log";
            this.m_tabLog.UseVisualStyleBackColor = true;
            // 
            // m_btnClearLog
            // 
            this.m_btnClearLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnClearLog.Location = new System.Drawing.Point(601, 355);
            this.m_btnClearLog.Name = "m_btnClearLog";
            this.m_btnClearLog.Size = new System.Drawing.Size(75, 23);
            this.m_btnClearLog.TabIndex = 2;
            this.m_btnClearLog.Text = "Clear";
            this.m_btnClearLog.UseVisualStyleBackColor = true;
            // 
            // m_btnSaveLog
            // 
            this.m_btnSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.m_btnSaveLog.Location = new System.Drawing.Point(682, 355);
            this.m_btnSaveLog.Name = "m_btnSaveLog";
            this.m_btnSaveLog.Size = new System.Drawing.Size(75, 23);
            this.m_btnSaveLog.TabIndex = 1;
            this.m_btnSaveLog.Text = "Save";
            this.m_btnSaveLog.UseVisualStyleBackColor = true;
            // 
            // m_textLog
            // 
            this.m_textLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_textLog.Location = new System.Drawing.Point(0, 0);
            this.m_textLog.Multiline = true;
            this.m_textLog.Name = "m_textLog";
            this.m_textLog.ReadOnly = true;
            this.m_textLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.m_textLog.Size = new System.Drawing.Size(760, 346);
            this.m_textLog.TabIndex = 0;
            // 
            // _groupBoxActions
            // 
            this._groupBoxActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._groupBoxActions.Controls.Add(this.button1);
            this._groupBoxActions.Controls.Add(this.m_btnStart);
            this._groupBoxActions.Controls.Add(this.m_btnStop);
            this._groupBoxActions.Controls.Add(this.m_btnPause);
            this._groupBoxActions.Location = new System.Drawing.Point(459, 11);
            this._groupBoxActions.Name = "_groupBoxActions";
            this._groupBoxActions.Size = new System.Drawing.Size(321, 81);
            this._groupBoxActions.TabIndex = 7;
            this._groupBoxActions.TabStop = false;
            this._groupBoxActions.Text = "Action";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 623);
            this.Controls.Add(this._groupBoxActions);
            this.Controls.Add(this.m_tabListView);
            this.Controls.Add(this._groupBoxViewerSettings);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Football";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.m_tabListView.ResumeLayout(false);
            this.m_tabTopView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_imgTopView)).EndInit();
            this.m_tabSideView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_imgSideView)).EndInit();
            this.m_tabData.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.m_groupGame.ResumeLayout(false);
            this.m_groupGame.PerformLayout();
            this.m_groupDataBall.ResumeLayout(false);
            this.m_groupDataBall.PerformLayout();
            this.m_tabLog.ResumeLayout(false);
            this.m_tabLog.PerformLayout();
            this._groupBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnStart;
        private System.Windows.Forms.Button m_btnStop;
        private System.Windows.Forms.Button m_btnPause;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel m_statusStatus;
        private System.Windows.Forms.GroupBox _groupBoxViewerSettings;
        private System.Windows.Forms.TabControl m_tabListView;
        private System.Windows.Forms.TabPage m_tabTopView;
        private System.Windows.Forms.TabPage m_tabSideView;
        private System.Windows.Forms.PictureBox m_imgTopView;
        private System.Windows.Forms.PictureBox m_imgSideView;
        private System.Windows.Forms.ToolStripStatusLabel m_statusTime;
        private System.Windows.Forms.TabPage m_tabData;
        private System.Windows.Forms.TabPage m_tabLog;
        private System.Windows.Forms.TextBox m_textLog;
        private System.Windows.Forms.Button m_btnClearLog;
        private System.Windows.Forms.Button m_btnSaveLog;
        private System.Windows.Forms.GroupBox m_groupDataBall;
        private System.Windows.Forms.GroupBox m_groupGame;
        private System.Windows.Forms.Label m_lblDataGameTime;
        private System.Windows.Forms.Label m_lblDataBallZ;
        private System.Windows.Forms.Label m_lblDataBallY;
        private System.Windows.Forms.Label m_lblDataBallX;
        private System.Windows.Forms.Label m_lblDataBallVx;
        private System.Windows.Forms.Label m_lblDataBallZValue;
        private System.Windows.Forms.Label m_lblDataBallYValue;
        private System.Windows.Forms.Label m_lblDataBallXValue;
        private System.Windows.Forms.Label m_lblDataBallVz;
        private System.Windows.Forms.Label m_lblDataBallVy;
        private System.Windows.Forms.Label m_lblDataBallWz;
        private System.Windows.Forms.Label m_lblDataBallWy;
        private System.Windows.Forms.Label m_lblDataBallWx;
        private System.Windows.Forms.Label m_lblDataBallVzValue;
        private System.Windows.Forms.Label m_lblDataBallVyValue;
        private System.Windows.Forms.Label m_lblDataBallVxValue;
        private System.Windows.Forms.Label m_lblDataBallWzValue;
        private System.Windows.Forms.Label m_lblDataBallWyValue;
        private System.Windows.Forms.Label m_lblDataBallWxValue;
        private System.Windows.Forms.Label m_lblDataGameStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label m_lblDataSecondTeamScore;
        private System.Windows.Forms.Label m_lblDataSecondTeamPlayersCount;
        private System.Windows.Forms.Label m_lblDataSecondTeamName;
        private System.Windows.Forms.Label m_lblDataFirstTeamScore;
        private System.Windows.Forms.Label m_lblDataFirstTeamPlayersCount;
        private System.Windows.Forms.Label m_lblDataFirstTeamName;
        private System.Windows.Forms.Label m_lblDataSecondTeamNameValue;
        private System.Windows.Forms.Label m_lblDataSecondTeamScoreValue;
        private System.Windows.Forms.Label m_lblDataSecondTeamPlayersCountValue;
        private System.Windows.Forms.Label m_lblDataFirstTeamPlayersCountValue;
        private System.Windows.Forms.Label m_lblDataFirstTeamNameValue;
        private System.Windows.Forms.Label m_lblDataFirstTeamScoreValue;
        private System.Windows.Forms.Label m_lblDataGameTimeValue;
        private System.Windows.Forms.Label m_lblDataGameStatusValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox _groupBoxActions;
    }
}