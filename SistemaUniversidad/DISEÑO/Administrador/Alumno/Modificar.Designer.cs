﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    partial class Modificar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private List<Student> listaModificable = new List<Student>();
        //private List<Student> listaAlumnoGenerico = new List<Student>();
        private int indice;
        private int carrera;
        private string pass;
        string previousCarnet;

        //private void mostrar(){
        //
        //    foreach(Student x in listaModificable) {
        //        txtNombres.Text = x.getNombres();
        //        txrtPrimerApellido.Text = x.getPrimerApellido();
        //        txtSegundoApellido.Text = x.getSegundoApellido();
        //        cmbCarreras.Text = x.getCarrera(); ;
        //        txtCarnet.Text = x.getCarnet();
        //        txtDocumentoIdentidad.Text = x.getDocumentoIdentidad();
        //        txtDireccion.Text = x.getDireccion();
        //        txtTelefono.Text = x.getTelefono();
        //        txtCelular.Text = x.getCelular();
        //        txtCorreo.Text = x.getCorreo();
        //        txtFechaInscripcion.Text = x.getFechaInscripcion();
        //        cmbNacionalidad.Text = x.getNacionalidad();
        //        cmbEstadoCivil.Text = x.getEstadoCivil();
        //        previousCarnet = x.getCarnet();
        //
        //        if (x.getSexo() == "Masculino") {
        //            rbtnMasculino.Checked = true;
        //            rbtnFemenino.Checked = false;
        //        } else {
        //            rbtnMasculino.Checked = false;
        //            rbtnFemenino.Checked = true;
        //        }
        //    }
        //}
        //
        //public void setDetalles(List<Student> listaRecibida) {
        //    this.listaModificable = listaRecibida;
        //}

        public void setResive(int indice, int carrera){
            this.indice = indice;
            this.carrera = carrera;
        }

        //void SaveToDatabase() {
        //
        //    MySqlConnection connection = GenerateConnection.Connection();
        //    MySqlCommand query = new MySqlCommand();
        //    query.Connection = connection;
        //
        //    foreach (Student x in listaAlumnoGenerico) {
        //        query.CommandText = "UPDATE Alumnos SET " +
        //            "Nombres = '"+x.getNombres()+"', " +
        //            "PrimerApellido = '"+x.getPrimerApellido()+"', " +
        //            "SegundoApellido = '"+x.getSegundoApellido()+"', " +
        //            "NombreCarrera = '"+x.getCarrera()+"', " +
        //            "Carnet = '"+x.getCarnet()+"', " +
        //            "Clave = '"+x.getPasswrd()+"', " +
        //            "Matricula = '"+x.getMatricula().ToString()+"', " +
        //            "FechaDeNacimiento = '"+x.getFechaNacimiento()+"', " +
        //            "DocumentoDeIdentidad = '"+x.getDocumentoIdentidad()+"', " +
        //            "Sexo = '"+x.getSexo()+"', " +
        //            "Direccion = '"+x.getDireccion()+"', " +
        //            "Telefono = '"+x.getTelefono()+"', " +
        //            "Celular = '"+x.getCelular()+"', " +
        //            "Correo = '"+x.getCorreo()+"', " +
        //            "FechaInscripcion = '"+x.getFechaInscripcion()+"', " +
        //            "Nacionalidad = '"+x.getNacionalidad()+"', " +
        //            "EstadoCivil = '"+x.getEstadoCivil()+"' " +
        //            "WHERE Carnet = '"+x.getCarnet()+"'";
        //        query.ExecuteNonQuery();
        //    }
        //    MessageBox.Show("EL REGISTRO HA SIDO ACTUALIZADO CON EXITO", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    connection.Close();
        //}

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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblNoObli = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbNacionalidad = new System.Windows.Forms.ComboBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.lblCarreras = new System.Windows.Forms.Label();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txrtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtFechaInscripcion = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dtPCalendarioNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblDocumentoIdentidad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDocumentoIdentidad = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.btnReturnToMainForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(713, 543);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 39);
            this.btnLimpiar.TabIndex = 63;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblNoObli
            // 
            this.lblNoObli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoObli.AutoSize = true;
            this.lblNoObli.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoObli.ForeColor = System.Drawing.Color.Maroon;
            this.lblNoObli.Location = new System.Drawing.Point(168, 341);
            this.lblNoObli.Name = "lblNoObli";
            this.lblNoObli.Size = new System.Drawing.Size(104, 16);
            this.lblNoObli.TabIndex = 62;
            this.lblNoObli.Text = "NO OBLIGATORIO";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(346, 543);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 39);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbNacionalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(330, 461);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(129, 29);
            this.cmbNacionalidad.TabIndex = 61;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarnet.Enabled = false;
            this.txtCarnet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarnet.Location = new System.Drawing.Point(723, 79);
            this.txtCarnet.MaxLength = 7;
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(100, 27);
            this.txtCarnet.TabIndex = 33;
            // 
            // lblCarnet
            // 
            this.lblCarnet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarnet.Location = new System.Drawing.Point(719, 43);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(70, 21);
            this.lblCarnet.TabIndex = 32;
            this.lblCarnet.Text = "Carnet:";
            // 
            // lblCarreras
            // 
            this.lblCarreras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCarreras.AutoSize = true;
            this.lblCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarreras.Location = new System.Drawing.Point(719, 419);
            this.lblCarreras.Name = "lblCarreras";
            this.lblCarreras.Size = new System.Drawing.Size(70, 21);
            this.lblCarreras.TabIndex = 34;
            this.lblCarreras.Text = "Carrera";
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCarreras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(723, 461);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(305, 29);
            this.cmbCarreras.TabIndex = 35;
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(147, 43);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(125, 21);
            this.lblPrimerApellido.TabIndex = 38;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(326, 43);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(148, 21);
            this.lblSegundoApellido.TabIndex = 36;
            this.lblSegundoApellido.Text = "Segundo Apellido";
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(500, 43);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(79, 21);
            this.lblNombres.TabIndex = 37;
            this.lblNombres.Text = "Nombres";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(504, 461);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(153, 29);
            this.cmbEstadoCivil.TabIndex = 60;
            // 
            // txrtPrimerApellido
            // 
            this.txrtPrimerApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txrtPrimerApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txrtPrimerApellido.Location = new System.Drawing.Point(151, 79);
            this.txrtPrimerApellido.Name = "txrtPrimerApellido";
            this.txrtPrimerApellido.Size = new System.Drawing.Size(132, 27);
            this.txrtPrimerApellido.TabIndex = 39;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSegundoApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(330, 79);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(135, 27);
            this.txtSegundoApellido.TabIndex = 40;
            // 
            // txtFechaInscripcion
            // 
            this.txtFechaInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFechaInscripcion.Enabled = false;
            this.txtFechaInscripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInscripcion.Location = new System.Drawing.Point(151, 463);
            this.txtFechaInscripcion.Name = "txtFechaInscripcion";
            this.txtFechaInscripcion.Size = new System.Drawing.Size(142, 27);
            this.txtFechaInscripcion.TabIndex = 59;
            // 
            // txtNombres
            // 
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(504, 79);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(185, 27);
            this.txtNombres.TabIndex = 41;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(723, 313);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(201, 27);
            this.txtCorreo.TabIndex = 58;
            this.txtCorreo.Tag = "";
            // 
            // dtPCalendarioNacimiento
            // 
            this.dtPCalendarioNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPCalendarioNacimiento.CustomFormat = "dd-mm-yyyy";
            this.dtPCalendarioNacimiento.Enabled = false;
            this.dtPCalendarioNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPCalendarioNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPCalendarioNacimiento.Location = new System.Drawing.Point(150, 189);
            this.dtPCalendarioNacimiento.Name = "dtPCalendarioNacimiento";
            this.dtPCalendarioNacimiento.Size = new System.Drawing.Size(131, 27);
            this.dtPCalendarioNacimiento.TabIndex = 42;
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(330, 313);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(139, 27);
            this.txtCelular.TabIndex = 57;
            this.txtCelular.Tag = "";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(146, 152);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(152, 21);
            this.lblFechaNacimiento.TabIndex = 43;
            this.lblFechaNacimiento.Text = "Fecha nacimiento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(151, 313);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(131, 27);
            this.txtTelefono.TabIndex = 56;
            this.txtTelefono.Tag = "";
            // 
            // lblDocumentoIdentidad
            // 
            this.lblDocumentoIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumentoIdentidad.AutoSize = true;
            this.lblDocumentoIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoIdentidad.Location = new System.Drawing.Point(325, 152);
            this.lblDocumentoIdentidad.Name = "lblDocumentoIdentidad";
            this.lblDocumentoIdentidad.Size = new System.Drawing.Size(38, 21);
            this.lblDocumentoIdentidad.TabIndex = 44;
            this.lblDocumentoIdentidad.Text = "DUI";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(516, 313);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(164, 27);
            this.txtDireccion.TabIndex = 55;
            // 
            // txtDocumentoIdentidad
            // 
            this.txtDocumentoIdentidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentoIdentidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoIdentidad.Location = new System.Drawing.Point(329, 191);
            this.txtDocumentoIdentidad.Name = "txtDocumentoIdentidad";
            this.txtDocumentoIdentidad.Size = new System.Drawing.Size(139, 27);
            this.txtDocumentoIdentidad.TabIndex = 45;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(719, 274);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 21);
            this.lblCorreo.TabIndex = 52;
            this.lblCorreo.Text = "Correo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(515, 193);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(106, 25);
            this.rbtnMasculino.TabIndex = 46;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.Location = new System.Drawing.Point(512, 419);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(97, 21);
            this.lblEstadoCivil.TabIndex = 49;
            this.lblEstadoCivil.Text = "Estado civil";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(627, 193);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(104, 25);
            this.rbtnFemenino.TabIndex = 47;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacionalidad.Location = new System.Drawing.Point(326, 419);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(116, 21);
            this.lblNacionalidad.TabIndex = 48;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(512, 274);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 21);
            this.lblDireccion.TabIndex = 50;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInscripcion.Location = new System.Drawing.Point(147, 419);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(146, 21);
            this.lblFechaInscripcion.TabIndex = 51;
            this.lblFechaInscripcion.Text = "Fecha Inscripción";
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(147, 274);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(76, 21);
            this.lblTelefono.TabIndex = 54;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCelular
            // 
            this.lblCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(326, 274);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(65, 21);
            this.lblCelular.TabIndex = 53;
            this.lblCelular.Text = "Celular";
            // 
            // btnReturnToMainForm
            // 
            this.btnReturnToMainForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainForm.Location = new System.Drawing.Point(907, 12);
            this.btnReturnToMainForm.Name = "btnReturnToMainForm";
            this.btnReturnToMainForm.Size = new System.Drawing.Size(48, 35);
            this.btnReturnToMainForm.TabIndex = 65;
            this.btnReturnToMainForm.Text = "X";
            this.btnReturnToMainForm.UseVisualStyleBackColor = true;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 686);
            this.Controls.Add(this.btnReturnToMainForm);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblNoObli);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbNacionalidad);
            this.Controls.Add(this.txtCarnet);
            this.Controls.Add(this.lblCarnet);
            this.Controls.Add(this.lblCarreras);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.cmbEstadoCivil);
            this.Controls.Add(this.txrtPrimerApellido);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtFechaInscripcion);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.dtPCalendarioNacimiento);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblDocumentoIdentidad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDocumentoIdentidad);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblFechaInscripcion);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCelular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLimpiar;
        private Label lblNoObli;
        private Button btnGuardar;
        private ComboBox cmbNacionalidad;
        private TextBox txtCarnet;
        private Label lblCarnet;
        private Label lblCarreras;
        private ComboBox cmbCarreras;
        private Label lblPrimerApellido;
        private Label lblSegundoApellido;
        private Label lblNombres;
        private ComboBox cmbEstadoCivil;
        private TextBox txrtPrimerApellido;
        private TextBox txtSegundoApellido;
        private TextBox txtFechaInscripcion;
        private TextBox txtNombres;
        private TextBox txtCorreo;
        private DateTimePicker dtPCalendarioNacimiento;
        private TextBox txtCelular;
        private Label lblFechaNacimiento;
        private TextBox txtTelefono;
        private Label lblDocumentoIdentidad;
        private TextBox txtDireccion;
        private TextBox txtDocumentoIdentidad;
        private Label lblCorreo;
        private RadioButton rbtnMasculino;
        private Label lblEstadoCivil;
        private RadioButton rbtnFemenino;
        private Label lblNacionalidad;
        private Label lblDireccion;
        private Label lblFechaInscripcion;
        private Label lblTelefono;
        private Label lblCelular;
        private Button btnReturnToMainForm;
    }
}