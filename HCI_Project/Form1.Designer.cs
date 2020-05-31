namespace HCI_Project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnRerun = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnPaste = new System.Windows.Forms.Button();
            this.BtnUndo = new System.Windows.Forms.Button();
            this.BtnNewFile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.컨트롤CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fdFont = new System.Windows.Forms.FontDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnCut = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.BtnCopy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnItalic = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnReduction = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.BtnStrikethrough = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnUnder = new System.Windows.Forms.Button();
            this.fdcolor = new System.Windows.Forms.ColorDialog();
            this.BtnFont = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEnlargement = new System.Windows.Forms.Button();
            this.fdbrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnFind = new System.Windows.Forms.Button();
            this.BtnFindAndChange = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextEdit = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SearchStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRerun
            // 
            this.BtnRerun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnRerun.FlatAppearance.BorderSize = 0;
            this.BtnRerun.Image = ((System.Drawing.Image)(resources.GetObject("BtnRerun.Image")));
            this.BtnRerun.Location = new System.Drawing.Point(151, 128);
            this.BtnRerun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnRerun.Name = "BtnRerun";
            this.BtnRerun.Size = new System.Drawing.Size(35, 39);
            this.BtnRerun.TabIndex = 0;
            this.toolTip1.SetToolTip(this.BtnRerun, "다시실행");
            this.BtnRerun.UseVisualStyleBackColor = false;
            this.BtnRerun.Click += new System.EventHandler(this.BtnRerun_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnOpen.FlatAppearance.BorderSize = 0;
            this.BtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("BtnOpen.Image")));
            this.BtnOpen.Location = new System.Drawing.Point(151, 42);
            this.BtnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(35, 39);
            this.BtnOpen.TabIndex = 3;
            this.toolTip1.SetToolTip(this.BtnOpen, "불러오기");
            this.BtnOpen.UseVisualStyleBackColor = false;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnPaste
            // 
            this.BtnPaste.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnPaste.FlatAppearance.BorderSize = 0;
            this.BtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("BtnPaste.Image")));
            this.BtnPaste.Location = new System.Drawing.Point(75, 0);
            this.BtnPaste.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPaste.Name = "BtnPaste";
            this.BtnPaste.Size = new System.Drawing.Size(69, 62);
            this.BtnPaste.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnPaste, "붙여넣기");
            this.BtnPaste.UseVisualStyleBackColor = false;
            this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // BtnUndo
            // 
            this.BtnUndo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnUndo.FlatAppearance.BorderSize = 0;
            this.BtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("BtnUndo.Image")));
            this.BtnUndo.Location = new System.Drawing.Point(151, 85);
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(35, 39);
            this.BtnUndo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnUndo, "실행취소");
            this.BtnUndo.UseVisualStyleBackColor = false;
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnNewFile
            // 
            this.BtnNewFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnNewFile.FlatAppearance.BorderSize = 0;
            this.BtnNewFile.Image = ((System.Drawing.Image)(resources.GetObject("BtnNewFile.Image")));
            this.BtnNewFile.Location = new System.Drawing.Point(151, 1);
            this.BtnNewFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNewFile.Name = "BtnNewFile";
            this.BtnNewFile.Size = new System.Drawing.Size(35, 35);
            this.BtnNewFile.TabIndex = 7;
            this.toolTip1.SetToolTip(this.BtnNewFile, "새파일");
            this.BtnNewFile.UseVisualStyleBackColor = false;
            this.BtnNewFile.Click += new System.EventHandler(this.BtnNewFile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.홈ToolStripMenuItem,
            this.ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.컨트롤CToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(911, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 홈ToolStripMenuItem
            // 
            this.홈ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.홈ToolStripMenuItem.Name = "홈ToolStripMenuItem";
            this.홈ToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.홈ToolStripMenuItem.Text = "  홈    I";
            this.홈ToolStripMenuItem.Click += new System.EventHandler(this.홈ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.다른이름으로저ToolStripMenuItem});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.ToolStripMenuItem.Text = "파일(&F)";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // 다른이름으로저ToolStripMenuItem
            // 
            this.다른이름으로저ToolStripMenuItem.Name = "다른이름으로저ToolStripMenuItem";
            this.다른이름으로저ToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.다른이름으로저ToolStripMenuItem.Text = "다른이름으로 저장";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripSeparator3,
            this.잘라내기TToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.찾기ToolStripMenuItem,
            this.다음찾기ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.편집ToolStripMenuItem.Text = "편집(&E)";
            this.편집ToolStripMenuItem.Click += new System.EventHandler(this.편집ToolStripMenuItem_Click);
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.실행취소UToolStripMenuItem.Text = "실행취소(&U)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(208, 6);
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(&T)";
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // 찾기ToolStripMenuItem
            // 
            this.찾기ToolStripMenuItem.Name = "찾기ToolStripMenuItem";
            this.찾기ToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.찾기ToolStripMenuItem.Text = "찾기";
            // 
            // 다음찾기ToolStripMenuItem
            // 
            this.다음찾기ToolStripMenuItem.Name = "다음찾기ToolStripMenuItem";
            this.다음찾기ToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.다음찾기ToolStripMenuItem.Text = "바꾸기";
            // 
            // 컨트롤CToolStripMenuItem
            // 
            this.컨트롤CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.컨트롤CToolStripMenuItem.Name = "컨트롤CToolStripMenuItem";
            this.컨트롤CToolStripMenuItem.Size = new System.Drawing.Size(70, 22);
            this.컨트롤CToolStripMenuItem.Text = "서식(&O)";
            this.컨트롤CToolStripMenuItem.Click += new System.EventHandler(this.컨트롤CToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 31);
            this.toolStripComboBox1.Text = "글꼴";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.도움말ToolStripMenuItem.Text = "도움말(&H)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.BtnCut);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.BtnCopy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnRerun);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnPaste);
            this.panel1.Controls.Add(this.BtnUndo);
            this.panel1.Controls.Add(this.BtnOpen);
            this.panel1.Controls.Add(this.BtnNewFile);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 170);
            this.panel1.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(193, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 22);
            this.label11.TabIndex = 29;
            this.label11.Text = "새 파일";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCut
            // 
            this.BtnCut.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCut.FlatAppearance.BorderSize = 0;
            this.BtnCut.Image = ((System.Drawing.Image)(resources.GetObject("BtnCut.Image")));
            this.BtnCut.Location = new System.Drawing.Point(6, 85);
            this.BtnCut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCut.Name = "BtnCut";
            this.BtnCut.Size = new System.Drawing.Size(69, 62);
            this.BtnCut.TabIndex = 28;
            this.toolTip1.SetToolTip(this.BtnCut, "오려두기");
            this.BtnCut.UseVisualStyleBackColor = false;
            this.BtnCut.Click += new System.EventHandler(this.BtnCut_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(6, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 22);
            this.label10.TabIndex = 27;
            this.label10.Text = "오려두기";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCopy
            // 
            this.BtnCopy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCopy.FlatAppearance.BorderSize = 0;
            this.BtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("BtnCopy.Image")));
            this.BtnCopy.Location = new System.Drawing.Point(75, 85);
            this.BtnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.Size = new System.Drawing.Size(69, 62);
            this.BtnCopy.TabIndex = 26;
            this.toolTip1.SetToolTip(this.BtnCopy, "복사하기");
            this.BtnCopy.UseVisualStyleBackColor = false;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(75, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "붙여넣기";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(193, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "다시 실행";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(193, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "실행 취소";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(193, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "불러오기";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(75, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "복사하기";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "파일저장";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.Location = new System.Drawing.Point(6, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(69, 62);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.toolTip1.SetToolTip(this.BtnSave, "파일저장");
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnItalic.FlatAppearance.BorderSize = 0;
            this.BtnItalic.Image = ((System.Drawing.Image)(resources.GetObject("BtnItalic.Image")));
            this.BtnItalic.Location = new System.Drawing.Point(39, 44);
            this.BtnItalic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(29, 31);
            this.BtnItalic.TabIndex = 16;
            this.toolTip1.SetToolTip(this.BtnItalic, "글자 기울게");
            this.BtnItalic.UseVisualStyleBackColor = false;
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnColor.FlatAppearance.BorderSize = 0;
            this.BtnColor.Image = ((System.Drawing.Image)(resources.GetObject("BtnColor.Image")));
            this.BtnColor.Location = new System.Drawing.Point(145, 44);
            this.BtnColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(29, 31);
            this.BtnColor.TabIndex = 18;
            this.toolTip1.SetToolTip(this.BtnColor, "글자 색");
            this.BtnColor.UseVisualStyleBackColor = false;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnReduction
            // 
            this.BtnReduction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnReduction.FlatAppearance.BorderSize = 0;
            this.BtnReduction.Image = ((System.Drawing.Image)(resources.GetObject("BtnReduction.Image")));
            this.BtnReduction.Location = new System.Drawing.Point(110, 5);
            this.BtnReduction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnReduction.Name = "BtnReduction";
            this.BtnReduction.Size = new System.Drawing.Size(29, 31);
            this.BtnReduction.TabIndex = 14;
            this.toolTip1.SetToolTip(this.BtnReduction, "글자 축소");
            this.BtnReduction.UseVisualStyleBackColor = false;
            this.BtnReduction.Click += new System.EventHandler(this.BtnReduction_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Location = new System.Drawing.Point(270, 111);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 91);
            this.panel4.TabIndex = 23;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.Image = ((System.Drawing.Image)(resources.GetObject("button18.Image")));
            this.button18.Location = new System.Drawing.Point(3, 4);
            this.button18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(29, 31);
            this.button18.TabIndex = 19;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(38, 4);
            this.button15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(29, 31);
            this.button15.TabIndex = 16;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.Location = new System.Drawing.Point(73, 4);
            this.button17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(29, 31);
            this.button17.TabIndex = 18;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // BtnStrikethrough
            // 
            this.BtnStrikethrough.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnStrikethrough.FlatAppearance.BorderSize = 0;
            this.BtnStrikethrough.Image = ((System.Drawing.Image)(resources.GetObject("BtnStrikethrough.Image")));
            this.BtnStrikethrough.Location = new System.Drawing.Point(110, 44);
            this.BtnStrikethrough.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStrikethrough.Name = "BtnStrikethrough";
            this.BtnStrikethrough.Size = new System.Drawing.Size(29, 31);
            this.BtnStrikethrough.TabIndex = 17;
            this.toolTip1.SetToolTip(this.BtnStrikethrough, "글자 취소선");
            this.BtnStrikethrough.UseVisualStyleBackColor = false;
            this.BtnStrikethrough.Click += new System.EventHandler(this.BtnStrikethrough_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBold.FlatAppearance.BorderSize = 0;
            this.BtnBold.Image = ((System.Drawing.Image)(resources.GetObject("BtnBold.Image")));
            this.BtnBold.Location = new System.Drawing.Point(3, 44);
            this.BtnBold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(29, 31);
            this.BtnBold.TabIndex = 22;
            this.toolTip1.SetToolTip(this.BtnBold, "글자 굵게");
            this.BtnBold.UseVisualStyleBackColor = false;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnUnder
            // 
            this.BtnUnder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnUnder.FlatAppearance.BorderSize = 0;
            this.BtnUnder.Image = ((System.Drawing.Image)(resources.GetObject("BtnUnder.Image")));
            this.BtnUnder.Location = new System.Drawing.Point(74, 45);
            this.BtnUnder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUnder.Name = "BtnUnder";
            this.BtnUnder.Size = new System.Drawing.Size(29, 31);
            this.BtnUnder.TabIndex = 24;
            this.toolTip1.SetToolTip(this.BtnUnder, "글자 밑줄");
            this.BtnUnder.UseVisualStyleBackColor = false;
            this.BtnUnder.Click += new System.EventHandler(this.BtnUnder_Click);
            // 
            // BtnFont
            // 
            this.BtnFont.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFont.FlatAppearance.BorderSize = 0;
            this.BtnFont.Location = new System.Drawing.Point(3, 5);
            this.BtnFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnFont.Name = "BtnFont";
            this.BtnFont.Size = new System.Drawing.Size(99, 31);
            this.BtnFont.TabIndex = 24;
            this.BtnFont.Text = "맑은고딕";
            this.BtnFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.BtnFont, "글꼴");
            this.BtnFont.UseVisualStyleBackColor = false;
            this.BtnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.BtnEnlargement);
            this.panel2.Controls.Add(this.BtnReduction);
            this.panel2.Controls.Add(this.BtnColor);
            this.panel2.Controls.Add(this.BtnItalic);
            this.panel2.Controls.Add(this.BtnStrikethrough);
            this.panel2.Controls.Add(this.BtnFont);
            this.panel2.Controls.Add(this.BtnUnder);
            this.panel2.Controls.Add(this.BtnBold);
            this.panel2.Location = new System.Drawing.Point(270, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 78);
            this.panel2.TabIndex = 24;
            // 
            // BtnEnlargement
            // 
            this.BtnEnlargement.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEnlargement.FlatAppearance.BorderSize = 0;
            this.BtnEnlargement.Image = ((System.Drawing.Image)(resources.GetObject("BtnEnlargement.Image")));
            this.BtnEnlargement.Location = new System.Drawing.Point(145, 5);
            this.BtnEnlargement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnEnlargement.Name = "BtnEnlargement";
            this.BtnEnlargement.Size = new System.Drawing.Size(29, 31);
            this.BtnEnlargement.TabIndex = 25;
            this.toolTip1.SetToolTip(this.BtnEnlargement, "글자 확대");
            this.BtnEnlargement.UseVisualStyleBackColor = false;
            this.BtnEnlargement.Click += new System.EventHandler(this.BtnEnlargement_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // BtnFind
            // 
            this.BtnFind.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFind.FlatAppearance.BorderSize = 0;
            this.BtnFind.Image = ((System.Drawing.Image)(resources.GetObject("BtnFind.Image")));
            this.BtnFind.Location = new System.Drawing.Point(12, 4);
            this.BtnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(47, 46);
            this.BtnFind.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnFind, "불러오기");
            this.BtnFind.UseVisualStyleBackColor = false;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnFindAndChange
            // 
            this.BtnFindAndChange.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnFindAndChange.FlatAppearance.BorderSize = 0;
            this.BtnFindAndChange.Image = ((System.Drawing.Image)(resources.GetObject("BtnFindAndChange.Image")));
            this.BtnFindAndChange.Location = new System.Drawing.Point(13, 58);
            this.BtnFindAndChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnFindAndChange.Name = "BtnFindAndChange";
            this.BtnFindAndChange.Size = new System.Drawing.Size(46, 45);
            this.BtnFindAndChange.TabIndex = 5;
            this.toolTip1.SetToolTip(this.BtnFindAndChange, "불러오기");
            this.BtnFindAndChange.UseVisualStyleBackColor = false;
            this.BtnFindAndChange.Click += new System.EventHandler(this.BtnFindAndChange_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(609, 2);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Search.Multiline = true;
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(167, 24);
            this.Search.TabIndex = 25;
            this.Search.Text = "검색";
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextEdit
            // 
            this.TextEdit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TextEdit.Location = new System.Drawing.Point(0, 201);
            this.TextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextEdit.Name = "TextEdit";
            this.TextEdit.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.TextEdit.Size = new System.Drawing.Size(914, 499);
            this.TextEdit.TabIndex = 26;
            this.TextEdit.Text = "";
            this.TextEdit.TextChanged += new System.EventHandler(this.TextEdit_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.BtnFindAndChange);
            this.panel3.Controls.Add(this.BtnFind);
            this.panel3.Location = new System.Drawing.Point(466, 32);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 170);
            this.panel3.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(65, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 22);
            this.label13.TabIndex = 31;
            this.label13.Text = "바꾸기";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(65, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 30;
            this.label12.Text = "찾기";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // SearchStatus
            // 
            this.SearchStatus.AutoSize = true;
            this.SearchStatus.Location = new System.Drawing.Point(783, 7);
            this.SearchStatus.Name = "SearchStatus";
            this.SearchStatus.Size = new System.Drawing.Size(73, 15);
            this.SearchStatus.TabIndex = 31;
            this.SearchStatus.Text = "| No_data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(911, 714);
            this.Controls.Add(this.SearchStatus);
            this.Controls.Add(this.TextEdit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "TEXT EDITOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRerun;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnPaste;
        private System.Windows.Forms.Button BtnUndo;
        private System.Windows.Forms.Button BtnNewFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 컨트롤CToolStripMenuItem;
        private System.Windows.Forms.FontDialog fdFont;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnItalic;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnReduction;
        private System.Windows.Forms.FlowLayoutPanel panel4;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button BtnStrikethrough;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnUnder;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnCopy;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog fdcolor;
        private System.Windows.Forms.Button BtnFont;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnCut;
        private System.Windows.Forms.FolderBrowserDialog fdbrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.RichTextBox TextEdit;
        private System.Windows.Forms.Button BtnEnlargement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnFindAndChange;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.ToolStripMenuItem 홈ToolStripMenuItem;
        private System.Windows.Forms.Label SearchStatus;
    }
}

