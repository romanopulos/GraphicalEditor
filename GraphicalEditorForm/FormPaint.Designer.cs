namespace GraphicalEditorForm
{
    partial class FormPaint
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
            this.panelTool = new System.Windows.Forms.Panel();
            this.btnLine = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.picColor = new System.Windows.Forms.Button();
            this.panelFigure = new System.Windows.Forms.Panel();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelIo = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.btnInvert = new System.Windows.Forms.Button();
            this.panelTool.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelIo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTool
            // 
            this.panelTool.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTool.Controls.Add(this.btnLine);
            this.panelTool.Controls.Add(this.btn_rect);
            this.panelTool.Controls.Add(this.btnEllipse);
            this.panelTool.Controls.Add(this.btnEraser);
            this.panelTool.Controls.Add(this.btnPencil);
            this.panelTool.Controls.Add(this.btnFill);
            this.panelTool.Controls.Add(this.btnColor);
            this.panelTool.Controls.Add(this.picColor);
            this.panelTool.Controls.Add(this.panelFigure);
            this.panelTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTool.Location = new System.Drawing.Point(0, 0);
            this.panelTool.Name = "panelTool";
            this.panelTool.Size = new System.Drawing.Size(1282, 114);
            this.panelTool.TabIndex = 1;
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLine.Image = global::GraphicalEditorForm.Properties.Resources.line;
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLine.Location = new System.Drawing.Point(562, 12);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(77, 66);
            this.btnLine.TabIndex = 7;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_rect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rect.Image = global::GraphicalEditorForm.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(479, 12);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(77, 66);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEllipse.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEllipse.Image = global::GraphicalEditorForm.Properties.Resources.circle;
            this.btnEllipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEllipse.Location = new System.Drawing.Point(396, 12);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(77, 66);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEraser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEraser.Image = global::GraphicalEditorForm.Properties.Resources.eraser;
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEraser.Location = new System.Drawing.Point(313, 12);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(77, 66);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPencil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPencil.Image = global::GraphicalEditorForm.Properties.Resources.pencil;
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPencil.Location = new System.Drawing.Point(230, 12);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(77, 66);
            this.btnPencil.TabIndex = 3;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnFill
            // 
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFill.Image = global::GraphicalEditorForm.Properties.Resources.bucket;
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFill.Location = new System.Drawing.Point(147, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(77, 66);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnColor
            // 
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnColor.Image = global::GraphicalEditorForm.Properties.Resources.color;
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnColor.Location = new System.Drawing.Point(64, 12);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(77, 66);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Font = new System.Drawing.Font("Times New Roman", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.picColor.Location = new System.Drawing.Point(19, 24);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(32, 35);
            this.picColor.TabIndex = 0;
            this.picColor.UseVisualStyleBackColor = false;
            // 
            // panelFigure
            // 
            this.panelFigure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelFigure.Location = new System.Drawing.Point(57, 3);
            this.panelFigure.Name = "panelFigure";
            this.panelFigure.Size = new System.Drawing.Size(587, 86);
            this.panelFigure.TabIndex = 4;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelResult.Controls.Add(this.panelIo);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResult.Location = new System.Drawing.Point(0, 710);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1282, 52);
            this.panelResult.TabIndex = 2;
            // 
            // panelIo
            // 
            this.panelIo.BackColor = System.Drawing.Color.Turquoise;
            this.panelIo.Controls.Add(this.btnLoad);
            this.panelIo.Controls.Add(this.btnInvert);
            this.panelIo.Controls.Add(this.btnClear);
            this.panelIo.Controls.Add(this.btnSave);
            this.panelIo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelIo.Location = new System.Drawing.Point(791, 0);
            this.panelIo.Name = "panelIo";
            this.panelIo.Size = new System.Drawing.Size(491, 52);
            this.panelIo.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Cyan;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Location = new System.Drawing.Point(142, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 29);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DeepPink;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(256, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 29);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(28, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.BackColor = System.Drawing.Color.White;
            this.pictureBoxPaint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPaint.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(1282, 762);
            this.pictureBoxPaint.TabIndex = 3;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // btnInvert
            // 
            this.btnInvert.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInvert.Location = new System.Drawing.Point(370, 16);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(108, 29);
            this.btnInvert.TabIndex = 0;
            this.btnInvert.Text = "Invert image";
            this.btnInvert.UseVisualStyleBackColor = false;
            // 
            // FormPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 762);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelTool);
            this.Controls.Add(this.pictureBoxPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alternative Paint";
            this.panelTool.ResumeLayout(false);
            this.panelResult.ResumeLayout(false);
            this.panelIo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTool;
        private Panel panelResult;
        private PictureBox pictureBoxPaint;
        private Button picColor;
        private Button btnColor;
        private Button btnFill;
        private Button btnPencil;
        private Button btnEraser;
        private Button btnEllipse;
        private Button btn_rect;
        private Button btnLine;
        private Panel panelFigure;
        private Panel panelIo;
        private Button btnLoad;
        private Button btnClear;
        private Button btnSave;
        private Button btnInvert;
    }
}