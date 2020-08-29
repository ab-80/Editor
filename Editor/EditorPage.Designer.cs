namespace Editor
{
    partial class EditorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorPage));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.newLabel = new System.Windows.Forms.ToolStripLabel();
            this.openLabel = new System.Windows.Forms.ToolStripLabel();
            this.saveLabel = new System.Windows.Forms.ToolStripLabel();
            this.spaceLabel = new System.Windows.Forms.ToolStripLabel();
            this.cutLabel = new System.Windows.Forms.ToolStripLabel();
            this.copyLabel = new System.Windows.Forms.ToolStripLabel();
            this.pasteLabel = new System.Windows.Forms.ToolStripLabel();
            this.spaceLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.undoLabel = new System.Windows.Forms.ToolStripLabel();
            this.redoLabel = new System.Windows.Forms.ToolStripLabel();
            this.selectAllLabel = new System.Windows.Forms.ToolStripLabel();
            this.runLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSelectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripRun = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newLabel,
            this.openLabel,
            this.saveLabel,
            this.spaceLabel,
            this.cutLabel,
            this.copyLabel,
            this.pasteLabel,
            this.spaceLabel2,
            this.undoLabel,
            this.redoLabel,
            this.selectAllLabel,
            this.runLabel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1408, 38);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // newLabel
            // 
            this.newLabel.ForeColor = System.Drawing.Color.White;
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(63, 44);
            this.newLabel.Text = "New";
            this.newLabel.Click += new System.EventHandler(this.newLabel_Click);
            // 
            // openLabel
            // 
            this.openLabel.ForeColor = System.Drawing.Color.White;
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(81, 44);
            this.openLabel.Text = " Open";
            this.openLabel.Click += new System.EventHandler(this.openLabel_Click);
            // 
            // saveLabel
            // 
            this.saveLabel.ForeColor = System.Drawing.Color.White;
            this.saveLabel.Name = "saveLabel";
            this.saveLabel.Size = new System.Drawing.Size(72, 44);
            this.saveLabel.Text = " Save";
            this.saveLabel.Click += new System.EventHandler(this.saveLabel_Click);
            // 
            // spaceLabel
            // 
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(29, 44);
            this.spaceLabel.Text = "  ";
            // 
            // cutLabel
            // 
            this.cutLabel.ForeColor = System.Drawing.Color.White;
            this.cutLabel.Name = "cutLabel";
            this.cutLabel.Size = new System.Drawing.Size(52, 44);
            this.cutLabel.Text = "Cut";
            this.cutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cutLabel.Click += new System.EventHandler(this.cutLabel_Click);
            // 
            // copyLabel
            // 
            this.copyLabel.ForeColor = System.Drawing.Color.White;
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(77, 44);
            this.copyLabel.Text = " Copy";
            this.copyLabel.Click += new System.EventHandler(this.copyLabel_Click);
            // 
            // pasteLabel
            // 
            this.pasteLabel.ForeColor = System.Drawing.Color.White;
            this.pasteLabel.Name = "pasteLabel";
            this.pasteLabel.Size = new System.Drawing.Size(77, 44);
            this.pasteLabel.Text = " Paste";
            this.pasteLabel.Click += new System.EventHandler(this.pasteLabel_Click);
            // 
            // spaceLabel2
            // 
            this.spaceLabel2.BackColor = System.Drawing.Color.Black;
            this.spaceLabel2.Name = "spaceLabel2";
            this.spaceLabel2.Size = new System.Drawing.Size(22, 44);
            this.spaceLabel2.Text = " ";
            // 
            // undoLabel
            // 
            this.undoLabel.ForeColor = System.Drawing.Color.White;
            this.undoLabel.Name = "undoLabel";
            this.undoLabel.Size = new System.Drawing.Size(73, 44);
            this.undoLabel.Text = "Undo";
            this.undoLabel.Click += new System.EventHandler(this.undoLabel_Click);
            // 
            // redoLabel
            // 
            this.redoLabel.ForeColor = System.Drawing.Color.White;
            this.redoLabel.Name = "redoLabel";
            this.redoLabel.Size = new System.Drawing.Size(69, 44);
            this.redoLabel.Text = "Redo";
            this.redoLabel.Click += new System.EventHandler(this.redoLabel_Click);
            // 
            // selectAllLabel
            // 
            this.selectAllLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.selectAllLabel.ForeColor = System.Drawing.Color.White;
            this.selectAllLabel.Name = "selectAllLabel";
            this.selectAllLabel.Size = new System.Drawing.Size(113, 44);
            this.selectAllLabel.Text = "Select All";
            this.selectAllLabel.Click += new System.EventHandler(this.selectAllLabel_Click);
            // 
            // runLabel
            // 
            this.runLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.runLabel.ForeColor = System.Drawing.Color.White;
            this.runLabel.Name = "runLabel";
            this.runLabel.Size = new System.Drawing.Size(154, 44);
            this.runLabel.Text = "Run Program";
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.DimGray;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSave,
            this.toolStripSeparator1,
            this.toolStripCut,
            this.toolStripCopy,
            this.toolStripPaste,
            this.toolStripSeparator2,
            this.toolStripUndo,
            this.toolStripRedo,
            this.toolStripSelectAll,
            this.toolStripRun});
            this.toolStrip3.Location = new System.Drawing.Point(0, 38);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1408, 42);
            this.toolStrip3.TabIndex = 5;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(46, 36);
            this.toolStripNew.Text = "&New";
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.Size = new System.Drawing.Size(46, 44);
            this.toolStripOpen.Text = "&Open";
            // 
            // toolStripSave
            // 
            this.toolStripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.Size = new System.Drawing.Size(46, 36);
            this.toolStripSave.Text = "&Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripCut
            // 
            this.toolStripCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCut.Image")));
            this.toolStripCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCut.Name = "toolStripCut";
            this.toolStripCut.Size = new System.Drawing.Size(46, 44);
            this.toolStripCut.Text = "C&ut";
            // 
            // toolStripCopy
            // 
            this.toolStripCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopy.Image")));
            this.toolStripCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopy.Name = "toolStripCopy";
            this.toolStripCopy.Size = new System.Drawing.Size(46, 44);
            this.toolStripCopy.Text = "&Copy";
            // 
            // toolStripPaste
            // 
            this.toolStripPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPaste.Image")));
            this.toolStripPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPaste.Name = "toolStripPaste";
            this.toolStripPaste.Size = new System.Drawing.Size(46, 44);
            this.toolStripPaste.Text = "&Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripUndo
            // 
            this.toolStripUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUndo.Image")));
            this.toolStripUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUndo.Name = "toolStripUndo";
            this.toolStripUndo.Size = new System.Drawing.Size(46, 44);
            this.toolStripUndo.Text = "&Undo";
            // 
            // toolStripRedo
            // 
            this.toolStripRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRedo.Image")));
            this.toolStripRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRedo.Name = "toolStripRedo";
            this.toolStripRedo.Size = new System.Drawing.Size(46, 44);
            this.toolStripRedo.Text = "&Redo";
            // 
            // toolStripSelectAll
            // 
            this.toolStripSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSelectAll.Image")));
            this.toolStripSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSelectAll.Name = "toolStripSelectAll";
            this.toolStripSelectAll.Size = new System.Drawing.Size(46, 44);
            this.toolStripSelectAll.Text = "&SelectAll";
            // 
            // toolStripRun
            // 
            this.toolStripRun.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRun.Image")));
            this.toolStripRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRun.Name = "toolStripRun";
            this.toolStripRun.Size = new System.Drawing.Size(46, 44);
            this.toolStripRun.Text = "&Run";
            this.toolStripRun.Click += new System.EventHandler(this.toolStripRun_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1408, 1134);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.DimGray;
            this.outputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.outputBox.ForeColor = System.Drawing.Color.White;
            this.outputBox.FormattingEnabled = true;
            this.outputBox.ItemHeight = 32;
            this.outputBox.Location = new System.Drawing.Point(0, 1082);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1408, 132);
            this.outputBox.TabIndex = 7;
            // 
            // EditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1408, 1214);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip2);
            this.Name = "EditorPage";
            this.Text = "Editor";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel newLabel;
        private System.Windows.Forms.ToolStripLabel openLabel;
        private System.Windows.Forms.ToolStripLabel saveLabel;
        private System.Windows.Forms.ToolStripLabel cutLabel;
        private System.Windows.Forms.ToolStripLabel copyLabel;
        private System.Windows.Forms.ToolStripLabel pasteLabel;
        private System.Windows.Forms.ToolStripLabel undoLabel;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripOpen;
        private System.Windows.Forms.ToolStripButton toolStripSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripCut;
        private System.Windows.Forms.ToolStripButton toolStripCopy;
        private System.Windows.Forms.ToolStripButton toolStripPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripUndo;
        private System.Windows.Forms.ToolStripButton toolStripRedo;
        private System.Windows.Forms.ToolStripButton toolStripSelectAll;
        private System.Windows.Forms.ToolStripButton toolStripRun;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripLabel redoLabel;
        private System.Windows.Forms.ToolStripLabel selectAllLabel;
        private System.Windows.Forms.ToolStripLabel spaceLabel;
        private System.Windows.Forms.ToolStripLabel runLabel;
        private System.Windows.Forms.ToolStripLabel spaceLabel2;
        private System.Windows.Forms.ListBox outputBox;
    }
}

