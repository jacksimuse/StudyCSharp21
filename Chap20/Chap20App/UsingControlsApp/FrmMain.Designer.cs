
namespace UsingControlsApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.CboFonts = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TrbHandle = new System.Windows.Forms.TrackBar();
            this.PrbDisplay = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.BtnModaless = new System.Windows.Forms.Button();
            this.BtnModal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TrvDummy = new System.Windows.Forms.TreeView();
            this.LsvDummy = new System.Windows.Forms.ListView();
            this.BtnAddRoot = new System.Windows.Forms.Button();
            this.BtnAddChild = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtResult);
            this.groupBox3.Controls.Add(this.ChkItalic);
            this.groupBox3.Controls.Add(this.CboFonts);
            this.groupBox3.Controls.Add(this.Label1);
            this.groupBox3.Controls.Add(this.ChkBold);
            this.groupBox3.Location = new System.Drawing.Point(10, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 109);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ComboBox, CheckBox, TextBox";
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(21, 62);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(340, 21);
            this.TxtResult.TabIndex = 5;
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkItalic.Location = new System.Drawing.Point(302, 28);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(60, 16);
            this.ChkItalic.TabIndex = 4;
            this.ChkItalic.Text = "이텔리";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // CboFonts
            // 
            this.CboFonts.FormattingEnabled = true;
            this.CboFonts.Location = new System.Drawing.Point(62, 24);
            this.CboFonts.Name = "CboFonts";
            this.CboFonts.Size = new System.Drawing.Size(175, 20);
            this.CboFonts.TabIndex = 2;
            this.CboFonts.SelectedIndexChanged += new System.EventHandler(this.CboFont_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(37, 12);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Font :";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkBold.Location = new System.Drawing.Point(248, 28);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(50, 16);
            this.ChkBold.TabIndex = 1;
            this.ChkBold.Text = "굵게";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.Chkbold_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TrbHandle);
            this.groupBox1.Controls.Add(this.PrbDisplay);
            this.groupBox1.Location = new System.Drawing.Point(10, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TrackBar & ProgressBar";
            // 
            // TrbHandle
            // 
            this.TrbHandle.Location = new System.Drawing.Point(21, 21);
            this.TrbHandle.Maximum = 20;
            this.TrbHandle.Name = "TrbHandle";
            this.TrbHandle.Size = new System.Drawing.Size(340, 45);
            this.TrbHandle.TabIndex = 1;
            this.TrbHandle.Scroll += new System.EventHandler(this.TrbHandle_Scroll);
            // 
            // PrbDisplay
            // 
            this.PrbDisplay.Location = new System.Drawing.Point(21, 71);
            this.PrbDisplay.Maximum = 20;
            this.PrbDisplay.Name = "PrbDisplay";
            this.PrbDisplay.Size = new System.Drawing.Size(340, 23);
            this.PrbDisplay.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnMsgBox);
            this.groupBox2.Controls.Add(this.BtnModaless);
            this.groupBox2.Controls.Add(this.BtnModal);
            this.groupBox2.Location = new System.Drawing.Point(10, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 94);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Moda, Modaless,";
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(261, 30);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(99, 30);
            this.BtnMsgBox.TabIndex = 2;
            this.BtnMsgBox.Text = "MessageBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // BtnModaless
            // 
            this.BtnModaless.Location = new System.Drawing.Point(141, 30);
            this.BtnModaless.Name = "BtnModaless";
            this.BtnModaless.Size = new System.Drawing.Size(99, 30);
            this.BtnModaless.TabIndex = 1;
            this.BtnModaless.Text = "Modaless";
            this.BtnModaless.UseVisualStyleBackColor = true;
            this.BtnModaless.Click += new System.EventHandler(this.BtnModaless_Click);
            // 
            // BtnModal
            // 
            this.BtnModal.Location = new System.Drawing.Point(21, 30);
            this.BtnModal.Name = "BtnModal";
            this.BtnModal.Size = new System.Drawing.Size(99, 30);
            this.BtnModal.TabIndex = 0;
            this.BtnModal.Text = "Modal";
            this.BtnModal.UseVisualStyleBackColor = true;
            this.BtnModal.Click += new System.EventHandler(this.BtnModal_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnAddChild);
            this.groupBox4.Controls.Add(this.BtnAddRoot);
            this.groupBox4.Controls.Add(this.LsvDummy);
            this.groupBox4.Controls.Add(this.TrvDummy);
            this.groupBox4.Location = new System.Drawing.Point(10, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 216);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "TreeView && ListView";
            // 
            // TrvDummy
            // 
            this.TrvDummy.Location = new System.Drawing.Point(0, 19);
            this.TrvDummy.Name = "TrvDummy";
            this.TrvDummy.Size = new System.Drawing.Size(184, 162);
            this.TrvDummy.TabIndex = 0;
            // 
            // LsvDummy
            // 
            this.LsvDummy.HideSelection = false;
            this.LsvDummy.Location = new System.Drawing.Point(186, 20);
            this.LsvDummy.Name = "LsvDummy";
            this.LsvDummy.Size = new System.Drawing.Size(184, 161);
            this.LsvDummy.TabIndex = 1;
            this.LsvDummy.UseCompatibleStateImageBehavior = false;
            this.LsvDummy.View = System.Windows.Forms.View.Details;
            // 
            // BtnAddRoot
            // 
            this.BtnAddRoot.Location = new System.Drawing.Point(0, 187);
            this.BtnAddRoot.Name = "BtnAddRoot";
            this.BtnAddRoot.Size = new System.Drawing.Size(89, 23);
            this.BtnAddRoot.TabIndex = 2;
            this.BtnAddRoot.Text = "루트추가";
            this.BtnAddRoot.UseVisualStyleBackColor = true;
            this.BtnAddRoot.Click += new System.EventHandler(this.BtnAddRoot_Click);
            // 
            // BtnAddChild
            // 
            this.BtnAddChild.Location = new System.Drawing.Point(95, 187);
            this.BtnAddChild.Name = "BtnAddChild";
            this.BtnAddChild.Size = new System.Drawing.Size(89, 23);
            this.BtnAddChild.TabIndex = 3;
            this.BtnAddChild.Text = "자식추가";
            this.BtnAddChild.UseVisualStyleBackColor = true;
            this.BtnAddChild.Click += new System.EventHandler(this.BtnAddChild_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 585);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Control App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CboFonts;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar TrbHandle;
        private System.Windows.Forms.ProgressBar PrbDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.Button BtnModaless;
        private System.Windows.Forms.Button BtnModal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnAddChild;
        private System.Windows.Forms.Button BtnAddRoot;
        private System.Windows.Forms.ListView LsvDummy;
        private System.Windows.Forms.TreeView TrvDummy;
    }
}
