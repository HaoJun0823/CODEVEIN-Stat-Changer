namespace CODEVEINStatChanger
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.TableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Label_Path = new System.Windows.Forms.Label();
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.FlowLayoutPanel_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanel_Extra = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_About = new System.Windows.Forms.Button();
            this.TableLayoutPanel_Main.SuspendLayout();
            this.FlowLayoutPanel_Extra.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel_Main
            // 
            this.TableLayoutPanel_Main.ColumnCount = 1;
            this.TableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanel_Main.Controls.Add(this.Label_Path, 0, 0);
            this.TableLayoutPanel_Main.Controls.Add(this.Button_OpenFile, 0, 1);
            this.TableLayoutPanel_Main.Controls.Add(this.FlowLayoutPanel_Main, 0, 2);
            this.TableLayoutPanel_Main.Controls.Add(this.FlowLayoutPanel_Extra, 0, 3);
            this.TableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel_Main.Name = "TableLayoutPanel_Main";
            this.TableLayoutPanel_Main.RowCount = 4;
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel_Main.Size = new System.Drawing.Size(384, 461);
            this.TableLayoutPanel_Main.TabIndex = 0;
            // 
            // Label_Path
            // 
            this.Label_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Path.Font = new System.Drawing.Font("宋体", 15F);
            this.Label_Path.Location = new System.Drawing.Point(3, 0);
            this.Label_Path.Name = "Label_Path";
            this.Label_Path.Size = new System.Drawing.Size(378, 46);
            this.Label_Path.TabIndex = 0;
            this.Label_Path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_OpenFile.Font = new System.Drawing.Font("宋体", 15F);
            this.Button_OpenFile.Location = new System.Drawing.Point(3, 49);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(378, 40);
            this.Button_OpenFile.TabIndex = 1;
            this.Button_OpenFile.Text = "Open";
            this.Button_OpenFile.UseVisualStyleBackColor = true;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // FlowLayoutPanel_Main
            // 
            this.FlowLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_Main.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowLayoutPanel_Main.Location = new System.Drawing.Point(3, 95);
            this.FlowLayoutPanel_Main.Name = "FlowLayoutPanel_Main";
            this.FlowLayoutPanel_Main.Size = new System.Drawing.Size(378, 270);
            this.FlowLayoutPanel_Main.TabIndex = 2;
            // 
            // FlowLayoutPanel_Extra
            // 
            this.FlowLayoutPanel_Extra.Controls.Add(this.Button_Save);
            this.FlowLayoutPanel_Extra.Controls.Add(this.Button_About);
            this.FlowLayoutPanel_Extra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanel_Extra.Location = new System.Drawing.Point(3, 371);
            this.FlowLayoutPanel_Extra.Name = "FlowLayoutPanel_Extra";
            this.FlowLayoutPanel_Extra.Size = new System.Drawing.Size(378, 87);
            this.FlowLayoutPanel_Extra.TabIndex = 3;
            // 
            // Button_Save
            // 
            this.Button_Save.Font = new System.Drawing.Font("宋体", 15F);
            this.Button_Save.Location = new System.Drawing.Point(3, 3);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(150, 75);
            this.Button_Save.TabIndex = 0;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_About
            // 
            this.Button_About.Font = new System.Drawing.Font("宋体", 15F);
            this.Button_About.Location = new System.Drawing.Point(159, 3);
            this.Button_About.Name = "Button_About";
            this.Button_About.Size = new System.Drawing.Size(150, 75);
            this.Button_About.TabIndex = 1;
            this.Button_About.Text = "About";
            this.Button_About.UseVisualStyleBackColor = true;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.TableLayoutPanel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODEVEIN Stat Changer";
            this.TableLayoutPanel_Main.ResumeLayout(false);
            this.FlowLayoutPanel_Extra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel_Main;
        private System.Windows.Forms.Label Label_Path;
        private System.Windows.Forms.Button Button_OpenFile;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Main;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Extra;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_About;
    }
}

