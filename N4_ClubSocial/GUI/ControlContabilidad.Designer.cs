namespace N4_ClubSocial.GUI
{
    partial class ControlContabilidad
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxOpcion1 = new System.Windows.Forms.GroupBox();
            this.gbxOpcion2 = new System.Windows.Forms.GroupBox();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.gbxOpcion1.SuspendLayout();
            this.gbxOpcion2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpcion1
            // 
            this.gbxOpcion1.Controls.Add(this.btnOpcion1);
            this.gbxOpcion1.Location = new System.Drawing.Point(4, 4);
            this.gbxOpcion1.Name = "gbxOpcion1";
            this.gbxOpcion1.Size = new System.Drawing.Size(303, 91);
            this.gbxOpcion1.TabIndex = 0;
            this.gbxOpcion1.TabStop = false;
            this.gbxOpcion1.Text = "groupBox1";
            // 
            // gbxOpcion2
            // 
            this.gbxOpcion2.Controls.Add(this.btnOpcion2);
            this.gbxOpcion2.Location = new System.Drawing.Point(4, 101);
            this.gbxOpcion2.Name = "gbxOpcion2";
            this.gbxOpcion2.Size = new System.Drawing.Size(303, 91);
            this.gbxOpcion2.TabIndex = 1;
            this.gbxOpcion2.TabStop = false;
            this.gbxOpcion2.Text = "groupBox2";
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(87, 38);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(135, 23);
            this.btnOpcion1.TabIndex = 0;
            this.btnOpcion1.Text = "button1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(87, 42);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(135, 23);
            this.btnOpcion2.TabIndex = 0;
            this.btnOpcion2.Text = "button2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            // 
            // ControlContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxOpcion2);
            this.Controls.Add(this.gbxOpcion1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlContabilidad";
            this.Size = new System.Drawing.Size(310, 345);
            this.gbxOpcion1.ResumeLayout(false);
            this.gbxOpcion2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOpcion1;
        private System.Windows.Forms.GroupBox gbxOpcion2;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
    }
}
