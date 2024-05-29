namespace MensajesAppForms
{
    partial class Form1
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
            lstMensajes = new ListBox();
            txtAgregar = new TextBox();
            btnAgregar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstMensajes
            // 
            lstMensajes.FormattingEnabled = true;
            lstMensajes.ItemHeight = 25;
            lstMensajes.Location = new Point(12, 71);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(776, 354);
            lstMensajes.TabIndex = 0;
            lstMensajes.SelectedIndexChanged += lstMensajes_SelectedIndexChanged;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(12, 15);
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(550, 31);
            txtAgregar.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(568, 13);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(686, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnAgregar);
            Controls.Add(txtAgregar);
            Controls.Add(lstMensajes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMensajes;
        private TextBox txtAgregar;
        private Button btnAgregar;
        private Button button1;
    }
}
