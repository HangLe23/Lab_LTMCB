
namespace Lab6
{
    partial class FileDownload
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.lsvList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Aqua;
            this.btnDownload.Font = new System.Drawing.Font(".TMC-Ong Do", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(333, 397);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(187, 49);
            this.btnDownload.TabIndex = 2;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsvList
            // 
            this.lsvList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvList.HideSelection = false;
            this.lsvList.Location = new System.Drawing.Point(18, 51);
            this.lsvList.Name = "lsvList";
            this.lsvList.Size = new System.Drawing.Size(770, 317);
            this.lsvList.TabIndex = 4;
            this.lsvList.UseCompatibleStateImageBehavior = false;
            this.lsvList.View = System.Windows.Forms.View.List;
            this.lsvList.SelectedIndexChanged += new System.EventHandler(this.lsvDanhsach_SelectedIndexChanged);
            // 
            // FileDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.lsvList);
            this.Controls.Add(this.btnDownload);
            this.Name = "FileDownload";
            this.Text = "FileDownload";
            this.Load += new System.EventHandler(this.FileDownload_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ListView lsvList;
    }
}