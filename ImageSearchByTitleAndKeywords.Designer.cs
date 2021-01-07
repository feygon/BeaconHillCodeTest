using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeaconHill_Coding_Test
{
    partial class ImageSearchByTitleAndKeywords
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SlideTitleLabel = new System.Windows.Forms.Label();
            this.SlideTextLabel = new System.Windows.Forms.Label();
            this.SlideTextRTBox = new System.Windows.Forms.RichTextBox();
            this.BoldButton = new System.Windows.Forms.Button();
            this.ImageSearchLabel = new System.Windows.Forms.Label();
            this.PicPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectPic0 = new System.Windows.Forms.CheckBox();
            this.SelectPic1 = new System.Windows.Forms.CheckBox();
            this.SelectPic2 = new System.Windows.Forms.CheckBox();
            this.SelectPic3 = new System.Windows.Forms.CheckBox();
            this.SelectPic4 = new System.Windows.Forms.CheckBox();
            this.SelectPic5 = new System.Windows.Forms.CheckBox();
            this.SelectPic6 = new System.Windows.Forms.CheckBox();
            this.SelectPic7 = new System.Windows.Forms.CheckBox();
            this.SelectPic8 = new System.Windows.Forms.CheckBox();
            this.pic0 = new System.Windows.Forms.PictureBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.ThreeImagesLabel = new System.Windows.Forms.Label();
            this.ScrollingImagePanel = new System.Windows.Forms.Panel();
            this.SearchButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SelectImagesBtn = new System.Windows.Forms.Button();
            this.PicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            this.ScrollingImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleTextBox.Location = new System.Drawing.Point(12, 29);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(581, 20);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Text = "Title";
            // 
            // SlideTitleLabel
            // 
            this.SlideTitleLabel.AutoSize = true;
            this.SlideTitleLabel.Location = new System.Drawing.Point(13, 13);
            this.SlideTitleLabel.Name = "SlideTitleLabel";
            this.SlideTitleLabel.Size = new System.Drawing.Size(56, 13);
            this.SlideTitleLabel.TabIndex = 1;
            this.SlideTitleLabel.Text = "Slide Title:";
            // 
            // SlideTextLabel
            // 
            this.SlideTextLabel.AutoSize = true;
            this.SlideTextLabel.Location = new System.Drawing.Point(16, 56);
            this.SlideTextLabel.Name = "SlideTextLabel";
            this.SlideTextLabel.Size = new System.Drawing.Size(54, 13);
            this.SlideTextLabel.TabIndex = 2;
            this.SlideTextLabel.Text = "SlideText:";
            // 
            // SlideTextRTBox
            // 
            this.SlideTextRTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SlideTextRTBox.Location = new System.Drawing.Point(12, 73);
            this.SlideTextRTBox.Name = "SlideTextRTBox";
            this.SlideTextRTBox.Size = new System.Drawing.Size(406, 101);
            this.SlideTextRTBox.TabIndex = 3;
            this.SlideTextRTBox.Text = "Slide Text";
            // 
            // BoldButton
            // 
            this.BoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoldButton.Location = new System.Drawing.Point(424, 73);
            this.BoldButton.Name = "BoldButton";
            this.BoldButton.Size = new System.Drawing.Size(40, 40);
            this.BoldButton.TabIndex = 4;
            this.BoldButton.Text = "B";
            this.BoldButton.UseVisualStyleBackColor = true;
            this.BoldButton.Click += new System.EventHandler(this.BoldButton_Click);
            // 
            // ImageSearchLabel
            // 
            this.ImageSearchLabel.AutoSize = true;
            this.ImageSearchLabel.Location = new System.Drawing.Point(13, 177);
            this.ImageSearchLabel.Name = "ImageSearchLabel";
            this.ImageSearchLabel.Size = new System.Drawing.Size(368, 13);
            this.ImageSearchLabel.TabIndex = 5;
            this.ImageSearchLabel.Text = "Title and Bold keywords will be searched for relevant images on Google(TM).";
            // 
            // PicPanel
            // 
            this.PicPanel.ColumnCount = 6;
            this.PicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.PicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.PicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PicPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.PicPanel.Controls.Add(this.SelectPic0, 0, 0);
            this.PicPanel.Controls.Add(this.SelectPic1, 2, 0);
            this.PicPanel.Controls.Add(this.SelectPic2, 4, 0);
            this.PicPanel.Controls.Add(this.SelectPic3, 0, 2);
            this.PicPanel.Controls.Add(this.SelectPic4, 2, 2);
            this.PicPanel.Controls.Add(this.SelectPic5, 4, 2);
            this.PicPanel.Controls.Add(this.SelectPic6, 0, 4);
            this.PicPanel.Controls.Add(this.SelectPic7, 2, 4);
            this.PicPanel.Controls.Add(this.SelectPic8, 4, 4);
            this.PicPanel.Controls.Add(this.pic0, 1, 1);
            this.PicPanel.Controls.Add(this.pic1, 3, 1);
            this.PicPanel.Controls.Add(this.pic2, 5, 1);
            this.PicPanel.Controls.Add(this.pic3, 1, 3);
            this.PicPanel.Controls.Add(this.pic4, 3, 3);
            this.PicPanel.Controls.Add(this.pic5, 5, 3);
            this.PicPanel.Controls.Add(this.pic6, 1, 5);
            this.PicPanel.Controls.Add(this.pic7, 3, 5);
            this.PicPanel.Controls.Add(this.pic8, 5, 5);
            this.PicPanel.Location = new System.Drawing.Point(3, 3);
            this.PicPanel.MinimumSize = new System.Drawing.Size(460, 240);
            this.PicPanel.Name = "PicPanel";
            this.PicPanel.RowCount = 6;
            this.PicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.PicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.PicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PicPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.PicPanel.Size = new System.Drawing.Size(656, 656);
            this.PicPanel.TabIndex = 6;
            this.PicPanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PicPanel_Scroll);
            // 
            // SelectPic0
            // 
            this.SelectPic0.AutoSize = true;
            this.SelectPic0.Location = new System.Drawing.Point(3, 3);
            this.SelectPic0.Name = "SelectPic0";
            this.SelectPic0.Size = new System.Drawing.Size(14, 14);
            this.SelectPic0.TabIndex = 11;
            this.SelectPic0.UseVisualStyleBackColor = true;
            this.SelectPic0.CheckedChanged += new System.EventHandler(this.SelectPic0_CheckedChanged);
            // 
            // SelectPic1
            // 
            this.SelectPic1.AutoSize = true;
            this.SelectPic1.Location = new System.Drawing.Point(215, 3);
            this.SelectPic1.Name = "SelectPic1";
            this.SelectPic1.Size = new System.Drawing.Size(14, 14);
            this.SelectPic1.TabIndex = 12;
            this.SelectPic1.UseVisualStyleBackColor = true;
            this.SelectPic1.CheckedChanged += new System.EventHandler(this.SelectPic1_CheckedChanged);
            // 
            // SelectPic2
            // 
            this.SelectPic2.AutoSize = true;
            this.SelectPic2.Location = new System.Drawing.Point(427, 3);
            this.SelectPic2.Name = "SelectPic2";
            this.SelectPic2.Size = new System.Drawing.Size(14, 14);
            this.SelectPic2.TabIndex = 13;
            this.SelectPic2.UseVisualStyleBackColor = true;
            this.SelectPic2.CheckedChanged += new System.EventHandler(this.SelectPic2_CheckedChanged);
            // 
            // SelectPic3
            // 
            this.SelectPic3.AutoSize = true;
            this.SelectPic3.Location = new System.Drawing.Point(3, 215);
            this.SelectPic3.Name = "SelectPic3";
            this.SelectPic3.Size = new System.Drawing.Size(14, 14);
            this.SelectPic3.TabIndex = 14;
            this.SelectPic3.UseVisualStyleBackColor = true;
            this.SelectPic3.CheckedChanged += new System.EventHandler(this.SelectPic3_CheckedChanged);
            // 
            // SelectPic4
            // 
            this.SelectPic4.AutoSize = true;
            this.SelectPic4.Location = new System.Drawing.Point(215, 215);
            this.SelectPic4.Name = "SelectPic4";
            this.SelectPic4.Size = new System.Drawing.Size(14, 14);
            this.SelectPic4.TabIndex = 15;
            this.SelectPic4.UseVisualStyleBackColor = true;
            this.SelectPic4.CheckedChanged += new System.EventHandler(this.SelectPic4_CheckedChanged);
            // 
            // SelectPic5
            // 
            this.SelectPic5.AutoSize = true;
            this.SelectPic5.Location = new System.Drawing.Point(427, 215);
            this.SelectPic5.Name = "SelectPic5";
            this.SelectPic5.Size = new System.Drawing.Size(14, 14);
            this.SelectPic5.TabIndex = 16;
            this.SelectPic5.UseVisualStyleBackColor = true;
            this.SelectPic5.CheckedChanged += new System.EventHandler(this.SelectPic5_CheckedChanged);
            // 
            // SelectPic6
            // 
            this.SelectPic6.AutoSize = true;
            this.SelectPic6.Location = new System.Drawing.Point(3, 427);
            this.SelectPic6.Name = "SelectPic6";
            this.SelectPic6.Size = new System.Drawing.Size(14, 14);
            this.SelectPic6.TabIndex = 17;
            this.SelectPic6.UseVisualStyleBackColor = true;
            this.SelectPic6.CheckedChanged += new System.EventHandler(this.SelectPic6_CheckedChanged);
            // 
            // SelectPic7
            // 
            this.SelectPic7.AutoSize = true;
            this.SelectPic7.Location = new System.Drawing.Point(215, 427);
            this.SelectPic7.Name = "SelectPic7";
            this.SelectPic7.Size = new System.Drawing.Size(14, 14);
            this.SelectPic7.TabIndex = 18;
            this.SelectPic7.UseVisualStyleBackColor = true;
            this.SelectPic7.CheckedChanged += new System.EventHandler(this.SelectPic7_CheckedChanged);
            // 
            // SelectPic8
            // 
            this.SelectPic8.AutoSize = true;
            this.SelectPic8.Location = new System.Drawing.Point(427, 427);
            this.SelectPic8.Name = "SelectPic8";
            this.SelectPic8.Size = new System.Drawing.Size(14, 14);
            this.SelectPic8.TabIndex = 19;
            this.SelectPic8.UseVisualStyleBackColor = true;
            this.SelectPic8.CheckedChanged += new System.EventHandler(this.SelectPic8_CheckedChanged);
            // 
            // pic0
            // 
            this.pic0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic0.Location = new System.Drawing.Point(23, 23);
            this.pic0.Name = "pic0";
            this.pic0.Size = new System.Drawing.Size(186, 186);
            this.pic0.TabIndex = 20;
            this.pic0.TabStop = false;
            // 
            // pic1
            // 
            this.pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic1.Location = new System.Drawing.Point(235, 23);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(186, 186);
            this.pic1.TabIndex = 21;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic2.Location = new System.Drawing.Point(447, 23);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(206, 186);
            this.pic2.TabIndex = 22;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic3.Location = new System.Drawing.Point(23, 235);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(186, 186);
            this.pic3.TabIndex = 23;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic4.Location = new System.Drawing.Point(235, 235);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(186, 186);
            this.pic4.TabIndex = 24;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic5.Location = new System.Drawing.Point(447, 235);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(206, 186);
            this.pic5.TabIndex = 25;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic6.Location = new System.Drawing.Point(23, 447);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(186, 206);
            this.pic6.TabIndex = 26;
            this.pic6.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic7.Location = new System.Drawing.Point(235, 447);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(186, 206);
            this.pic7.TabIndex = 27;
            this.pic7.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic8.Location = new System.Drawing.Point(447, 447);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(206, 206);
            this.pic8.TabIndex = 28;
            this.pic8.TabStop = false;
            // 
            // ThreeImagesLabel
            // 
            this.ThreeImagesLabel.AutoSize = true;
            this.ThreeImagesLabel.Location = new System.Drawing.Point(16, 201);
            this.ThreeImagesLabel.Name = "ThreeImagesLabel";
            this.ThreeImagesLabel.Size = new System.Drawing.Size(176, 13);
            this.ThreeImagesLabel.TabIndex = 7;
            this.ThreeImagesLabel.Text = "Please select up to 3 images below:";
            // 
            // ScrollingImagePanel
            // 
            this.ScrollingImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ScrollingImagePanel.AutoScroll = true;
            this.ScrollingImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScrollingImagePanel.Controls.Add(this.PicPanel);
            this.ScrollingImagePanel.Location = new System.Drawing.Point(12, 217);
            this.ScrollingImagePanel.MaximumSize = new System.Drawing.Size(699, 696);
            this.ScrollingImagePanel.MinimumSize = new System.Drawing.Size(699, 300);
            this.ScrollingImagePanel.Name = "ScrollingImagePanel";
            this.ScrollingImagePanel.Size = new System.Drawing.Size(699, 450);
            this.ScrollingImagePanel.TabIndex = 30;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(425, 120);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(123, 54);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // SelectImagesBtn
            // 
            this.SelectImagesBtn.Location = new System.Drawing.Point(623, 177);
            this.SelectImagesBtn.Name = "SelectImagesBtn";
            this.SelectImagesBtn.Size = new System.Drawing.Size(88, 37);
            this.SelectImagesBtn.TabIndex = 32;
            this.SelectImagesBtn.Text = "Select Images";
            this.SelectImagesBtn.UseVisualStyleBackColor = true;
            this.SelectImagesBtn.Click += new System.EventHandler(this.SelectImagesBtn_Click);
            // 
            // ImageSearchByTitleAndKeywords
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(724, 689);
            this.Controls.Add(this.SelectImagesBtn);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ScrollingImagePanel);
            this.Controls.Add(this.ThreeImagesLabel);
            this.Controls.Add(this.ImageSearchLabel);
            this.Controls.Add(this.BoldButton);
            this.Controls.Add(this.SlideTextRTBox);
            this.Controls.Add(this.SlideTextLabel);
            this.Controls.Add(this.SlideTitleLabel);
            this.Controls.Add(this.TitleTextBox);
            this.MaximumSize = new System.Drawing.Size(740, 4000);
            this.MinimumSize = new System.Drawing.Size(740, 640);
            this.Name = "ImageSearchByTitleAndKeywords";
            this.PicPanel.ResumeLayout(false);
            this.PicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            this.ScrollingImagePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
            pics = new List<(CheckBox check, PictureBox pic, int index)>()
            {
                (SelectPic0, pic0, 0),
                (SelectPic1, pic1, 1),
                (SelectPic2, pic2, 2),
                (SelectPic3, pic3, 3),
                (SelectPic4, pic4, 4),
                (SelectPic5, pic5, 5),
                (SelectPic6, pic6, 6),
                (SelectPic7, pic7, 7),
                (SelectPic8, pic8, 8),
            };
        }

        private void PicPanel_Scroll(object sender, ScrollEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Components
        
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label SlideTitleLabel;
        private System.Windows.Forms.Label SlideTextLabel;
        private System.Windows.Forms.RichTextBox SlideTextRTBox;
        private System.Windows.Forms.Button BoldButton;
        private System.Windows.Forms.Label ImageSearchLabel;
        private System.Windows.Forms.TableLayoutPanel PicPanel;
        private System.Windows.Forms.CheckBox SelectPic0;
        private System.Windows.Forms.CheckBox SelectPic1;
        private System.Windows.Forms.CheckBox SelectPic2;
        private System.Windows.Forms.CheckBox SelectPic3;
        private System.Windows.Forms.CheckBox SelectPic4;
        private System.Windows.Forms.CheckBox SelectPic5;
        private System.Windows.Forms.CheckBox SelectPic6;
        private System.Windows.Forms.CheckBox SelectPic7;
        private System.Windows.Forms.CheckBox SelectPic8;
        private System.Windows.Forms.PictureBox pic0;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.Label ThreeImagesLabel;
        #endregion
        private System.Windows.Forms.Panel ScrollingImagePanel;
        private Button SearchButton;
        private ImageList imageList1;
        private Button SelectImagesBtn;
}
}

