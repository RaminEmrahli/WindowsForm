namespace ScreenPainter
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tSButtonCursor = new System.Windows.Forms.ToolStripButton();
            this.tSButtonZoom = new System.Windows.Forms.ToolStripButton();
            this.tSButtonBack = new System.Windows.Forms.ToolStripButton();
            this.tSButtonReturn = new System.Windows.Forms.ToolStripButton();
            this.tSButtonScreenShoot = new System.Windows.Forms.ToolStripButton();
            this.tSButtonPen = new System.Windows.Forms.ToolStripButton();
            this.tSButtonLine = new System.Windows.Forms.ToolStripButton();
            this.tSButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.tSButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.tSButtonColors = new System.Windows.Forms.ToolStripButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSButtonCursor,
            this.tSButtonZoom,
            this.tSButtonBack,
            this.tSButtonReturn,
            this.tSButtonScreenShoot,
            this.tSButtonPen,
            this.tSButtonLine,
            this.tSButtonRectangle,
            this.tSButtonEllipse,
            this.tSButtonColors});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(437, 46);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tSButtonCursor
            // 
            this.tSButtonCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonCursor.Image = global::ScreenPainter.Properties.Resources.icons8_cursor_32;
            this.tSButtonCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonCursor.Name = "tSButtonCursor";
            this.tSButtonCursor.Size = new System.Drawing.Size(36, 42);
            this.tSButtonCursor.Text = "Cursor";
            // 
            // tSButtonZoom
            // 
            this.tSButtonZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonZoom.Image = global::ScreenPainter.Properties.Resources.icons8_zoom_to_extents_32;
            this.tSButtonZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonZoom.Name = "tSButtonZoom";
            this.tSButtonZoom.Size = new System.Drawing.Size(36, 42);
            this.tSButtonZoom.Text = "Zoom";
            // 
            // tSButtonBack
            // 
            this.tSButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonBack.Image = global::ScreenPainter.Properties.Resources.icons8_up_left_32;
            this.tSButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonBack.Name = "tSButtonBack";
            this.tSButtonBack.Size = new System.Drawing.Size(36, 42);
            this.tSButtonBack.Text = "Go Back";
            // 
            // tSButtonReturn
            // 
            this.tSButtonReturn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonReturn.Image = global::ScreenPainter.Properties.Resources.icons8_up_right_32;
            this.tSButtonReturn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonReturn.Name = "tSButtonReturn";
            this.tSButtonReturn.Size = new System.Drawing.Size(36, 42);
            this.tSButtonReturn.Text = "Go Forward";
            // 
            // tSButtonScreenShoot
            // 
            this.tSButtonScreenShoot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonScreenShoot.Image = global::ScreenPainter.Properties.Resources.icons8_cut_32;
            this.tSButtonScreenShoot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonScreenShoot.Name = "tSButtonScreenShoot";
            this.tSButtonScreenShoot.Size = new System.Drawing.Size(36, 42);
            this.tSButtonScreenShoot.Text = "PrintScreen";
            // 
            // tSButtonPen
            // 
            this.tSButtonPen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonPen.Image = global::ScreenPainter.Properties.Resources.icons8_ball_point_pen_641;
            this.tSButtonPen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonPen.Name = "tSButtonPen";
            this.tSButtonPen.Size = new System.Drawing.Size(36, 42);
            this.tSButtonPen.Text = "Pen";
            // 
            // tSButtonLine
            // 
            this.tSButtonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonLine.Image = global::ScreenPainter.Properties.Resources.icons8_line_32;
            this.tSButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonLine.Name = "tSButtonLine";
            this.tSButtonLine.Size = new System.Drawing.Size(36, 42);
            this.tSButtonLine.Text = "Line";
            // 
            // tSButtonRectangle
            // 
            this.tSButtonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonRectangle.Image = global::ScreenPainter.Properties.Resources.icons8_rectangular_32;
            this.tSButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonRectangle.Name = "tSButtonRectangle";
            this.tSButtonRectangle.Size = new System.Drawing.Size(36, 42);
            this.tSButtonRectangle.Text = "Rectangular";
            // 
            // tSButtonEllipse
            // 
            this.tSButtonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonEllipse.Image = global::ScreenPainter.Properties.Resources.icons8_oval_32;
            this.tSButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonEllipse.Name = "tSButtonEllipse";
            this.tSButtonEllipse.Size = new System.Drawing.Size(36, 42);
            this.tSButtonEllipse.Text = "Ellipse";
            // 
            // tSButtonColors
            // 
            this.tSButtonColors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tSButtonColors.Image = global::ScreenPainter.Properties.Resources.icons8_color_swatch_32;
            this.tSButtonColors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSButtonColors.Name = "tSButtonColors";
            this.tSButtonColors.Size = new System.Drawing.Size(36, 42);
            this.tSButtonColors.Text = "Select Color";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(373, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 29);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(437, 46);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PickPick WhiteBoard";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tSButtonCursor;
        private System.Windows.Forms.ToolStripButton tSButtonZoom;
        private System.Windows.Forms.ToolStripButton tSButtonBack;
        private System.Windows.Forms.ToolStripButton tSButtonReturn;
        private System.Windows.Forms.ToolStripButton tSButtonScreenShoot;
        private System.Windows.Forms.ToolStripButton tSButtonPen;
        private System.Windows.Forms.ToolStripButton tSButtonLine;
        private System.Windows.Forms.ToolStripButton tSButtonRectangle;
        private System.Windows.Forms.ToolStripButton tSButtonEllipse;
        private System.Windows.Forms.ToolStripButton tSButtonColors;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

