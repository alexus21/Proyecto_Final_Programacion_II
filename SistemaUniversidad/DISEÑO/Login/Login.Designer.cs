﻿namespace SistemaUniversidad.DISEÑO.Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBoxDatosLogin = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.imgIcono = new System.Windows.Forms.PictureBox();
            this.pnlContAcceder = new System.Windows.Forms.Panel();
            this.groupBoxImg = new System.Windows.Forms.GroupBox();
            this.imgLogIn = new System.Windows.Forms.PictureBox();
            this.dragControlPnlAcceedr = new SistemaUniversidad.LOGICA.DragControl();
            this.dragControlImgAcceder = new SistemaUniversidad.LOGICA.DragControl();
            this.groupBoxDatosLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).BeginInit();
            this.pnlContAcceder.SuspendLayout();
            this.groupBoxImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDatosLogin
            // 
            this.groupBoxDatosLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxDatosLogin.Controls.Add(this.BtnCancelar);
            this.groupBoxDatosLogin.Controls.Add(this.BtnAcceder);
            this.groupBoxDatosLogin.Controls.Add(this.lblClave);
            this.groupBoxDatosLogin.Controls.Add(this.lblCorreo);
            this.groupBoxDatosLogin.Controls.Add(this.txtClave);
            this.groupBoxDatosLogin.Controls.Add(this.txtCorreo);
            this.groupBoxDatosLogin.Controls.Add(this.imgUser);
            this.groupBoxDatosLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosLogin.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDatosLogin.Location = new System.Drawing.Point(367, 22);
            this.groupBoxDatosLogin.Name = "groupBoxDatosLogin";
            this.groupBoxDatosLogin.Size = new System.Drawing.Size(368, 417);
            this.groupBoxDatosLogin.TabIndex = 1;
            this.groupBoxDatosLogin.TabStop = false;
            this.groupBoxDatosLogin.Text = "Acceder";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Location = new System.Drawing.Point(200, 343);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAcceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcceder.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceder.ForeColor = System.Drawing.Color.Black;
            this.BtnAcceder.Location = new System.Drawing.Point(96, 343);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(75, 23);
            this.BtnAcceder.TabIndex = 7;
            this.BtnAcceder.Text = "Acceder";
            this.BtnAcceder.UseVisualStyleBackColor = true;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.Black;
            this.lblClave.Location = new System.Drawing.Point(6, 303);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(88, 17);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(24, 263);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(57, 17);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Carnet:";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(96, 300);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(179, 23);
            this.txtClave.TabIndex = 4;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(96, 260);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(179, 23);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorreo_KeyPress);
            // 
            // imgUser
            // 
            this.imgUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(117, 82);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(129, 130);
            this.imgUser.TabIndex = 0;
            this.imgUser.TabStop = false;
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.pnlSuperior.Controls.Add(this.btnMinimizar);
            this.pnlSuperior.Controls.Add(this.btnCerrar);
            this.pnlSuperior.Controls.Add(this.imgIcono);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(767, 35);
            this.pnlSuperior.TabIndex = 2;
            this.pnlSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(115)))), ((int)(((byte)(164)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(680, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 35);
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(722, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 35);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // imgIcono
            // 
            this.imgIcono.Image = ((System.Drawing.Image)(resources.GetObject("imgIcono.Image")));
            this.imgIcono.Location = new System.Drawing.Point(12, 6);
            this.imgIcono.Name = "imgIcono";
            this.imgIcono.Size = new System.Drawing.Size(20, 20);
            this.imgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIcono.TabIndex = 0;
            this.imgIcono.TabStop = false;
            // 
            // pnlContAcceder
            // 
            this.pnlContAcceder.BackColor = System.Drawing.SystemColors.Control;
            this.pnlContAcceder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContAcceder.Controls.Add(this.groupBoxImg);
            this.pnlContAcceder.Controls.Add(this.groupBoxDatosLogin);
            this.pnlContAcceder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContAcceder.Location = new System.Drawing.Point(0, 35);
            this.pnlContAcceder.Name = "pnlContAcceder";
            this.pnlContAcceder.Size = new System.Drawing.Size(767, 467);
            this.pnlContAcceder.TabIndex = 3;
            // 
            // groupBoxImg
            // 
            this.groupBoxImg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxImg.Controls.Add(this.imgLogIn);
            this.groupBoxImg.Location = new System.Drawing.Point(27, 22);
            this.groupBoxImg.Name = "groupBoxImg";
            this.groupBoxImg.Size = new System.Drawing.Size(334, 417);
            this.groupBoxImg.TabIndex = 0;
            this.groupBoxImg.TabStop = false;
            // 
            // imgLogIn
            // 
            this.imgLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogIn.Image = ((System.Drawing.Image)(resources.GetObject("imgLogIn.Image")));
            this.imgLogIn.Location = new System.Drawing.Point(35, 82);
            this.imgLogIn.Name = "imgLogIn";
            this.imgLogIn.Size = new System.Drawing.Size(254, 252);
            this.imgLogIn.TabIndex = 0;
            this.imgLogIn.TabStop = false;
            // 
            // dragControlPnlAcceedr
            // 
            this.dragControlPnlAcceedr.SelectControl = this.pnlSuperior;
            // 
            // dragControlImgAcceder
            // 
            this.dragControlImgAcceder.SelectControl = this.imgIcono;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 502);
            this.Controls.Add(this.pnlContAcceder);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(946, 698);
            this.MinimumSize = new System.Drawing.Size(746, 498);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.groupBoxDatosLogin.ResumeLayout(false);
            this.groupBoxDatosLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgIcono)).EndInit();
            this.pnlContAcceder.ResumeLayout(false);
            this.groupBoxImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDatosLogin;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox imgIcono;
        private System.Windows.Forms.Panel pnlContAcceder;
        private LOGICA.DragControl dragControlPnlAcceedr;
        private LOGICA.DragControl dragControlImgAcceder;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.GroupBox groupBoxImg;
        private System.Windows.Forms.PictureBox imgLogIn;
    }
}