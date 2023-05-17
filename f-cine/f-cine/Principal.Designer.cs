namespace f_cine
{
    partial class Principal
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
            b_login = new Button();
            tb_sala = new TextBox();
            cb_preferencial = new ComboBox();
            cb_general = new ComboBox();
            cb_horarios = new ComboBox();
            cb_cartelera = new ComboBox();
            cb_combos = new ComboBox();
            b_comprar = new Button();
            tb_categoriap = new TextBox();
            tb_puntosp = new TextBox();
            tb_saldop = new TextBox();
            tb_duracionp = new TextBox();
            tb_generop = new TextBox();
            tb_edadm = new TextBox();
            gb_registro = new GroupBox();
            b_registro = new Button();
            tb_contrasena = new TextBox();
            label17 = new Label();
            tb_usuario = new TextBox();
            label16 = new Label();
            tb_numero = new TextBox();
            label15 = new Label();
            tb_nombre = new TextBox();
            label14 = new Label();
            label13 = new Label();
            tb_id = new TextBox();
            groupBox1 = new GroupBox();
            cb_usuario = new ComboBox();
            tb_contrasena_lg = new TextBox();
            label19 = new Label();
            label18 = new Label();
            groupBox2 = new GroupBox();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            label3 = new Label();
            b_recargar = new Button();
            cb_recarga = new ComboBox();
            b_comprar_combo = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox5 = new GroupBox();
            b_contratar = new Button();
            tb_contrasena_t = new TextBox();
            tb_usuario_t = new TextBox();
            label38 = new Label();
            label37 = new Label();
            tb_numero_contacto_t = new TextBox();
            label36 = new Label();
            tb_nombre_t = new TextBox();
            label35 = new Label();
            tb_id_t = new TextBox();
            label34 = new Label();
            label33 = new Label();
            cb_pelicula = new ComboBox();
            cb_sala = new ComboBox();
            dt_fecha_hora = new DateTimePicker();
            b_crear_funcion = new Button();
            label32 = new Label();
            label31 = new Label();
            label30 = new Label();
            label29 = new Label();
            cb_edad_minima = new ComboBox();
            cb_genero = new ComboBox();
            tb_sillas_preferenciales = new TextBox();
            tb_sillas_generales = new TextBox();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            b_crear_sala = new Button();
            b_crear_pelicula = new Button();
            label25 = new Label();
            label24 = new Label();
            label9 = new Label();
            label8 = new Label();
            tb_duracion_peli = new TextBox();
            tb_nombre_peli = new TextBox();
            label4 = new Label();
            gb_registro.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // b_login
            // 
            b_login.Location = new Point(6, 172);
            b_login.Name = "b_login";
            b_login.Size = new Size(215, 31);
            b_login.TabIndex = 3;
            b_login.Text = "Iniciar Sesión";
            b_login.UseVisualStyleBackColor = true;
            b_login.Click += b_login_Click_1;
            // 
            // tb_sala
            // 
            tb_sala.Location = new Point(247, 124);
            tb_sala.Name = "tb_sala";
            tb_sala.ReadOnly = true;
            tb_sala.Size = new Size(212, 27);
            tb_sala.TabIndex = 19;
            // 
            // cb_preferencial
            // 
            cb_preferencial.FormattingEnabled = true;
            cb_preferencial.Location = new Point(252, 54);
            cb_preferencial.Name = "cb_preferencial";
            cb_preferencial.Size = new Size(216, 28);
            cb_preferencial.TabIndex = 30;
            cb_preferencial.SelectedIndexChanged += cb_svip_SelectedIndexChanged;
            // 
            // cb_general
            // 
            cb_general.FormattingEnabled = true;
            cb_general.Location = new Point(6, 54);
            cb_general.Name = "cb_general";
            cb_general.Size = new Size(189, 28);
            cb_general.TabIndex = 29;
            cb_general.SelectedIndexChanged += cb_sgeneral_SelectedIndexChanged;
            // 
            // cb_horarios
            // 
            cb_horarios.FormattingEnabled = true;
            cb_horarios.Location = new Point(247, 60);
            cb_horarios.Name = "cb_horarios";
            cb_horarios.Size = new Size(212, 28);
            cb_horarios.TabIndex = 28;
            cb_horarios.SelectedIndexChanged += cb_horarios_SelectedIndexChanged;
            // 
            // cb_cartelera
            // 
            cb_cartelera.FormattingEnabled = true;
            cb_cartelera.Location = new Point(6, 59);
            cb_cartelera.Name = "cb_cartelera";
            cb_cartelera.Size = new Size(212, 28);
            cb_cartelera.TabIndex = 27;
            cb_cartelera.SelectedIndexChanged += cb_cartelera_SelectedIndexChanged;
            // 
            // cb_combos
            // 
            cb_combos.FormattingEnabled = true;
            cb_combos.Location = new Point(512, 54);
            cb_combos.Name = "cb_combos";
            cb_combos.Size = new Size(212, 28);
            cb_combos.TabIndex = 32;
            cb_combos.SelectedIndexChanged += cb_combos_SelectedIndexChanged;
            // 
            // b_comprar
            // 
            b_comprar.Location = new Point(6, 98);
            b_comprar.Name = "b_comprar";
            b_comprar.Size = new Size(189, 45);
            b_comprar.TabIndex = 33;
            b_comprar.Text = "Comprar Boletas";
            b_comprar.UseVisualStyleBackColor = true;
            b_comprar.Click += b_comprar_Click;
            // 
            // tb_categoriap
            // 
            tb_categoriap.Location = new Point(6, 124);
            tb_categoriap.Name = "tb_categoriap";
            tb_categoriap.ReadOnly = true;
            tb_categoriap.Size = new Size(214, 27);
            tb_categoriap.TabIndex = 36;
            // 
            // tb_puntosp
            // 
            tb_puntosp.Location = new Point(6, 60);
            tb_puntosp.Name = "tb_puntosp";
            tb_puntosp.ReadOnly = true;
            tb_puntosp.Size = new Size(214, 27);
            tb_puntosp.TabIndex = 34;
            // 
            // tb_saldop
            // 
            tb_saldop.Location = new Point(6, 186);
            tb_saldop.Name = "tb_saldop";
            tb_saldop.ReadOnly = true;
            tb_saldop.Size = new Size(214, 27);
            tb_saldop.TabIndex = 38;
            // 
            // tb_duracionp
            // 
            tb_duracionp.Location = new Point(6, 124);
            tb_duracionp.Name = "tb_duracionp";
            tb_duracionp.ReadOnly = true;
            tb_duracionp.Size = new Size(212, 27);
            tb_duracionp.TabIndex = 40;
            // 
            // tb_generop
            // 
            tb_generop.Location = new Point(6, 186);
            tb_generop.Name = "tb_generop";
            tb_generop.ReadOnly = true;
            tb_generop.Size = new Size(212, 27);
            tb_generop.TabIndex = 41;
            // 
            // tb_edadm
            // 
            tb_edadm.Location = new Point(247, 186);
            tb_edadm.Name = "tb_edadm";
            tb_edadm.ReadOnly = true;
            tb_edadm.Size = new Size(212, 27);
            tb_edadm.TabIndex = 42;
            // 
            // gb_registro
            // 
            gb_registro.Controls.Add(b_registro);
            gb_registro.Controls.Add(tb_contrasena);
            gb_registro.Controls.Add(label17);
            gb_registro.Controls.Add(tb_usuario);
            gb_registro.Controls.Add(label16);
            gb_registro.Controls.Add(tb_numero);
            gb_registro.Controls.Add(label15);
            gb_registro.Controls.Add(tb_nombre);
            gb_registro.Controls.Add(label14);
            gb_registro.Controls.Add(label13);
            gb_registro.Controls.Add(tb_id);
            gb_registro.Location = new Point(12, 12);
            gb_registro.Name = "gb_registro";
            gb_registro.Size = new Size(227, 399);
            gb_registro.TabIndex = 44;
            gb_registro.TabStop = false;
            gb_registro.Text = "Registro de usuario";
            // 
            // b_registro
            // 
            b_registro.Location = new Point(6, 352);
            b_registro.Name = "b_registro";
            b_registro.Size = new Size(215, 29);
            b_registro.TabIndex = 45;
            b_registro.Text = "Registrar Cliente";
            b_registro.UseVisualStyleBackColor = true;
            b_registro.Click += b_registro_Click;
            // 
            // tb_contrasena
            // 
            tb_contrasena.Location = new Point(6, 310);
            tb_contrasena.Name = "tb_contrasena";
            tb_contrasena.Size = new Size(215, 27);
            tb_contrasena.TabIndex = 49;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 287);
            label17.Name = "label17";
            label17.Size = new Size(83, 20);
            label17.TabIndex = 4;
            label17.Text = "Contraseña";
            // 
            // tb_usuario
            // 
            tb_usuario.Location = new Point(6, 241);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(215, 27);
            tb_usuario.TabIndex = 48;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 218);
            label16.Name = "label16";
            label16.Size = new Size(137, 20);
            label16.TabIndex = 3;
            label16.Text = "Nombre de usuario";
            // 
            // tb_numero
            // 
            tb_numero.Location = new Point(6, 173);
            tb_numero.Name = "tb_numero";
            tb_numero.Size = new Size(215, 27);
            tb_numero.TabIndex = 47;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 150);
            label15.Name = "label15";
            label15.Size = new Size(146, 20);
            label15.TabIndex = 2;
            label15.Text = "Numero de contacto";
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(6, 108);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(215, 27);
            tb_nombre.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 85);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 1;
            label14.Text = "Nombre";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 23);
            label13.Name = "label13";
            label13.Size = new Size(22, 20);
            label13.TabIndex = 0;
            label13.Text = "Id";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(6, 46);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(215, 27);
            tb_id.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cb_usuario);
            groupBox1.Controls.Add(tb_contrasena_lg);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(b_login);
            groupBox1.Location = new Point(12, 436);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 229);
            groupBox1.TabIndex = 45;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de sesión";
            // 
            // cb_usuario
            // 
            cb_usuario.FormattingEnabled = true;
            cb_usuario.Location = new Point(6, 61);
            cb_usuario.Name = "cb_usuario";
            cb_usuario.Size = new Size(215, 28);
            cb_usuario.TabIndex = 50;
            // 
            // tb_contrasena_lg
            // 
            tb_contrasena_lg.Location = new Point(6, 135);
            tb_contrasena_lg.Name = "tb_contrasena_lg";
            tb_contrasena_lg.Size = new Size(215, 27);
            tb_contrasena_lg.TabIndex = 47;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(6, 104);
            label19.Name = "label19";
            label19.Size = new Size(83, 20);
            label19.TabIndex = 47;
            label19.Text = "Contraseña";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 38);
            label18.Name = "label18";
            label18.Size = new Size(59, 20);
            label18.TabIndex = 46;
            label18.Text = "Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(tb_puntosp);
            groupBox2.Controls.Add(tb_categoriap);
            groupBox2.Controls.Add(tb_saldop);
            groupBox2.Location = new Point(256, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(226, 240);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Información cliente";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 163);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 49;
            label12.Text = "Saldo";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 36);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 47;
            label10.Text = "Puntos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 101);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 48;
            label11.Text = "Categoría";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(label22);
            groupBox3.Controls.Add(label21);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(tb_duracionp);
            groupBox3.Controls.Add(tb_edadm);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(tb_generop);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cb_cartelera);
            groupBox3.Controls.Add(cb_horarios);
            groupBox3.Controls.Add(tb_sala);
            groupBox3.Location = new Point(521, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(469, 240);
            groupBox3.TabIndex = 47;
            groupBox3.TabStop = false;
            groupBox3.Text = "Información películas";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(247, 163);
            label23.Name = "label23";
            label23.Size = new Size(97, 20);
            label23.TabIndex = 53;
            label23.Text = "Edad Mínima";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 163);
            label22.Name = "label22";
            label22.Size = new Size(57, 20);
            label22.TabIndex = 52;
            label22.Text = "Género";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(247, 101);
            label21.Name = "label21";
            label21.Size = new Size(37, 20);
            label21.TabIndex = 51;
            label21.Text = "Sala";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 101);
            label20.Name = "label20";
            label20.Size = new Size(69, 20);
            label20.TabIndex = 50;
            label20.Text = "Duracion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 39);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 49;
            label2.Text = "Horarios";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 48;
            label1.Text = "En cartelera";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(b_recargar);
            groupBox4.Controls.Add(cb_recarga);
            groupBox4.Controls.Add(b_comprar_combo);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(cb_general);
            groupBox4.Controls.Add(cb_preferencial);
            groupBox4.Controls.Add(b_comprar);
            groupBox4.Controls.Add(cb_combos);
            groupBox4.Location = new Point(256, 268);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(734, 226);
            groupBox4.TabIndex = 48;
            groupBox4.TabStop = false;
            groupBox4.Text = "Atención al cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 160);
            label3.Name = "label3";
            label3.Size = new Size(207, 20);
            label3.TabIndex = 37;
            label3.Text = "Opciones de recarga de saldo";
            // 
            // b_recargar
            // 
            b_recargar.Location = new Point(252, 168);
            b_recargar.Name = "b_recargar";
            b_recargar.Size = new Size(216, 43);
            b_recargar.TabIndex = 36;
            b_recargar.Text = "Recargar Saldo";
            b_recargar.UseVisualStyleBackColor = true;
            b_recargar.Click += b_recargar_Click;
            // 
            // cb_recarga
            // 
            cb_recarga.FormattingEnabled = true;
            cb_recarga.Location = new Point(6, 183);
            cb_recarga.Name = "cb_recarga";
            cb_recarga.Size = new Size(189, 28);
            cb_recarga.TabIndex = 35;
            // 
            // b_comprar_combo
            // 
            b_comprar_combo.Location = new Point(512, 98);
            b_comprar_combo.Name = "b_comprar_combo";
            b_comprar_combo.Size = new Size(212, 45);
            b_comprar_combo.TabIndex = 34;
            b_comprar_combo.Text = "Comprar Combo";
            b_comprar_combo.UseVisualStyleBackColor = true;
            b_comprar_combo.Click += b_comprar_combo_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(512, 26);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 2;
            label7.Text = "Comprar Combo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 31);
            label6.Name = "label6";
            label6.Size = new Size(216, 20);
            label6.TabIndex = 1;
            label6.Text = "Comprar Boletas Preferenciales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 0;
            label5.Text = "Comprar Boletas Generales";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(b_contratar);
            groupBox5.Controls.Add(tb_contrasena_t);
            groupBox5.Controls.Add(tb_usuario_t);
            groupBox5.Controls.Add(label38);
            groupBox5.Controls.Add(label37);
            groupBox5.Controls.Add(tb_numero_contacto_t);
            groupBox5.Controls.Add(label36);
            groupBox5.Controls.Add(tb_nombre_t);
            groupBox5.Controls.Add(label35);
            groupBox5.Controls.Add(tb_id_t);
            groupBox5.Controls.Add(label34);
            groupBox5.Controls.Add(label33);
            groupBox5.Controls.Add(cb_pelicula);
            groupBox5.Controls.Add(cb_sala);
            groupBox5.Controls.Add(dt_fecha_hora);
            groupBox5.Controls.Add(b_crear_funcion);
            groupBox5.Controls.Add(label32);
            groupBox5.Controls.Add(label31);
            groupBox5.Controls.Add(label30);
            groupBox5.Controls.Add(label29);
            groupBox5.Controls.Add(cb_edad_minima);
            groupBox5.Controls.Add(cb_genero);
            groupBox5.Controls.Add(tb_sillas_preferenciales);
            groupBox5.Controls.Add(tb_sillas_generales);
            groupBox5.Controls.Add(label28);
            groupBox5.Controls.Add(label27);
            groupBox5.Controls.Add(label26);
            groupBox5.Controls.Add(b_crear_sala);
            groupBox5.Controls.Add(b_crear_pelicula);
            groupBox5.Controls.Add(label25);
            groupBox5.Controls.Add(label24);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(tb_duracion_peli);
            groupBox5.Controls.Add(tb_nombre_peli);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(1008, 22);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(438, 643);
            groupBox5.TabIndex = 49;
            groupBox5.TabStop = false;
            groupBox5.Text = "Panel de control";
            // 
            // b_contratar
            // 
            b_contratar.Location = new Point(293, 584);
            b_contratar.Name = "b_contratar";
            b_contratar.Size = new Size(131, 29);
            b_contratar.TabIndex = 50;
            b_contratar.Text = "Contratar";
            b_contratar.UseVisualStyleBackColor = true;
            b_contratar.Click += b_contratar_Click;
            // 
            // tb_contrasena_t
            // 
            tb_contrasena_t.Location = new Point(162, 586);
            tb_contrasena_t.Name = "tb_contrasena_t";
            tb_contrasena_t.Size = new Size(125, 27);
            tb_contrasena_t.TabIndex = 53;
            // 
            // tb_usuario_t
            // 
            tb_usuario_t.Location = new Point(7, 586);
            tb_usuario_t.Name = "tb_usuario_t";
            tb_usuario_t.Size = new Size(124, 27);
            tb_usuario_t.TabIndex = 54;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(7, 556);
            label38.Name = "label38";
            label38.Size = new Size(137, 20);
            label38.TabIndex = 31;
            label38.Text = "Nombre de usuario";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(144, 488);
            label37.Name = "label37";
            label37.Size = new Size(64, 20);
            label37.TabIndex = 30;
            label37.Text = "Nombre";
            // 
            // tb_numero_contacto_t
            // 
            tb_numero_contacto_t.Location = new Point(276, 518);
            tb_numero_contacto_t.Name = "tb_numero_contacto_t";
            tb_numero_contacto_t.Size = new Size(148, 27);
            tb_numero_contacto_t.TabIndex = 52;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(162, 556);
            label36.Name = "label36";
            label36.Size = new Size(83, 20);
            label36.TabIndex = 29;
            label36.Text = "Contraseña";
            // 
            // tb_nombre_t
            // 
            tb_nombre_t.Location = new Point(144, 518);
            tb_nombre_t.Name = "tb_nombre_t";
            tb_nombre_t.Size = new Size(113, 27);
            tb_nombre_t.TabIndex = 51;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(276, 486);
            label35.Name = "label35";
            label35.Size = new Size(146, 20);
            label35.TabIndex = 28;
            label35.Text = "Numero de contacto";
            // 
            // tb_id_t
            // 
            tb_id_t.Location = new Point(7, 518);
            tb_id_t.Name = "tb_id_t";
            tb_id_t.Size = new Size(99, 27);
            tb_id_t.TabIndex = 50;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(6, 488);
            label34.Name = "label34";
            label34.Size = new Size(22, 20);
            label34.TabIndex = 27;
            label34.Text = "Id";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 462);
            label33.Name = "label33";
            label33.Size = new Size(140, 20);
            label33.TabIndex = 26;
            label33.Text = "Contratar Taquillero";
            // 
            // cb_pelicula
            // 
            cb_pelicula.FormattingEnabled = true;
            cb_pelicula.Location = new Point(7, 418);
            cb_pelicula.Name = "cb_pelicula";
            cb_pelicula.Size = new Size(161, 28);
            cb_pelicula.TabIndex = 25;
            // 
            // cb_sala
            // 
            cb_sala.FormattingEnabled = true;
            cb_sala.Location = new Point(276, 353);
            cb_sala.Name = "cb_sala";
            cb_sala.Size = new Size(148, 28);
            cb_sala.TabIndex = 24;
            // 
            // dt_fecha_hora
            // 
            dt_fecha_hora.Location = new Point(7, 351);
            dt_fecha_hora.Name = "dt_fecha_hora";
            dt_fecha_hora.Size = new Size(250, 27);
            dt_fecha_hora.TabIndex = 23;
            // 
            // b_crear_funcion
            // 
            b_crear_funcion.Location = new Point(199, 417);
            b_crear_funcion.Name = "b_crear_funcion";
            b_crear_funcion.Size = new Size(212, 29);
            b_crear_funcion.TabIndex = 22;
            b_crear_funcion.Text = "Crear Función";
            b_crear_funcion.UseVisualStyleBackColor = true;
            b_crear_funcion.Click += b_crear_funcion_Click;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(7, 395);
            label32.Name = "label32";
            label32.Size = new Size(59, 20);
            label32.TabIndex = 21;
            label32.Text = "Película";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(276, 318);
            label31.Name = "label31";
            label31.Size = new Size(37, 20);
            label31.TabIndex = 20;
            label31.Text = "Sala";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(6, 318);
            label30.Name = "label30";
            label30.Size = new Size(92, 20);
            label30.TabIndex = 19;
            label30.Text = "Fecha y hora";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(7, 286);
            label29.Name = "label29";
            label29.Size = new Size(99, 20);
            label29.TabIndex = 18;
            label29.Text = "Crear Funcion";
            // 
            // cb_edad_minima
            // 
            cb_edad_minima.FormattingEnabled = true;
            cb_edad_minima.Location = new Point(314, 86);
            cb_edad_minima.Name = "cb_edad_minima";
            cb_edad_minima.Size = new Size(97, 28);
            cb_edad_minima.TabIndex = 17;
            // 
            // cb_genero
            // 
            cb_genero.FormattingEnabled = true;
            cb_genero.Location = new Point(6, 147);
            cb_genero.Name = "cb_genero";
            cb_genero.Size = new Size(151, 28);
            cb_genero.TabIndex = 16;
            // 
            // tb_sillas_preferenciales
            // 
            tb_sillas_preferenciales.Location = new Point(144, 243);
            tb_sillas_preferenciales.Name = "tb_sillas_preferenciales";
            tb_sillas_preferenciales.Size = new Size(126, 27);
            tb_sillas_preferenciales.TabIndex = 15;
            // 
            // tb_sillas_generales
            // 
            tb_sillas_generales.Location = new Point(6, 243);
            tb_sillas_generales.Name = "tb_sillas_generales";
            tb_sillas_generales.Size = new Size(125, 27);
            tb_sillas_generales.TabIndex = 14;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(144, 220);
            label28.Name = "label28";
            label28.Size = new Size(126, 20);
            label28.TabIndex = 13;
            label28.Text = "Sillas preferencial";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(6, 220);
            label27.Name = "label27";
            label27.Size = new Size(97, 20);
            label27.TabIndex = 12;
            label27.Text = "Sillas general";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(6, 189);
            label26.Name = "label26";
            label26.Size = new Size(76, 20);
            label26.TabIndex = 11;
            label26.Text = "Crear Sala";
            // 
            // b_crear_sala
            // 
            b_crear_sala.Location = new Point(276, 242);
            b_crear_sala.Name = "b_crear_sala";
            b_crear_sala.Size = new Size(148, 29);
            b_crear_sala.TabIndex = 10;
            b_crear_sala.Text = "Crear Sala";
            b_crear_sala.UseVisualStyleBackColor = true;
            b_crear_sala.Click += b_crear_sala_Click;
            // 
            // b_crear_pelicula
            // 
            b_crear_pelicula.Location = new Point(199, 147);
            b_crear_pelicula.Name = "b_crear_pelicula";
            b_crear_pelicula.Size = new Size(212, 29);
            b_crear_pelicula.TabIndex = 9;
            b_crear_pelicula.Text = "Crear Película";
            b_crear_pelicula.UseVisualStyleBackColor = true;
            b_crear_pelicula.Click += b_crear_pelicula_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(6, 124);
            label25.Name = "label25";
            label25.Size = new Size(57, 20);
            label25.TabIndex = 8;
            label25.Text = "Género";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(314, 63);
            label24.Name = "label24";
            label24.Size = new Size(97, 20);
            label24.TabIndex = 7;
            label24.Text = "Edad mínima";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(199, 63);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 6;
            label9.Text = "Duracion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 63);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 5;
            label8.Text = "Nombre";
            // 
            // tb_duracion_peli
            // 
            tb_duracion_peli.Location = new Point(200, 86);
            tb_duracion_peli.Name = "tb_duracion_peli";
            tb_duracion_peli.Size = new Size(70, 27);
            tb_duracion_peli.TabIndex = 2;
            // 
            // tb_nombre_peli
            // 
            tb_nombre_peli.Location = new Point(6, 86);
            tb_nombre_peli.Name = "tb_nombre_peli";
            tb_nombre_peli.Size = new Size(162, 27);
            tb_nombre_peli.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 0;
            label4.Text = "Crear película";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 677);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gb_registro);
            Name = "Principal";
            Text = "Menu";
            Load += Form1_Load;
            gb_registro.ResumeLayout(false);
            gb_registro.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button b_login;
        private ComboBox cb_genero;
        private ComboBox cb_edad_minima;
        private ComboBox comboBox4;
        private ComboBox cb_preferencial;
        private ComboBox cb_general;
        private ComboBox cb_combos;
        private Button b_comprar;
        private TextBox tb_categoriap;
        private TextBox tb_puntosp;
        private TextBox tb_saldop;
        public TextBox tb_sala;
        public ComboBox cb_horarios;
        public ComboBox cb_cartelera;
        public TextBox tb_duracionp;
        public TextBox tb_generop;
        public TextBox tb_edadm;
        private GroupBox gb_registro;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button b_registro;
        private TextBox tb_contrasena;
        private TextBox tb_usuario;
        private TextBox tb_numero;
        private TextBox tb_nombre;
        private TextBox tb_id;
        private GroupBox groupBox1;
        private TextBox tb_contrasena_lg;
        private Label label19;
        private Label label18;
        private GroupBox groupBox2;
        private Label label12;
        private Label label10;
        private Label label11;
        private GroupBox groupBox3;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label2;
        private Label label1;
        private GroupBox groupBox4;
        private Button b_comprar_combo;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button b_recargar;
        private ComboBox cb_recarga;
        private GroupBox groupBox5;
        private Button b_crear_pelicula;
        private Label label25;
        private Label label24;
        private Label label9;
        private Label label8;
        private TextBox tb_duracion_peli;
        private TextBox tb_nombre_peli;
        private Label label4;
        private TextBox tb_sillas_preferenciales;
        private TextBox tb_sillas_generales;
        private Label label28;
        private Label label27;
        private Label label26;
        private Button b_crear_sala;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private ComboBox cb_pelicula;
        private ComboBox cb_sala;
        private DateTimePicker dt_fecha_hora;
        private Button b_crear_funcion;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Button b_contratar;
        private TextBox tb_contrasena_t;
        private TextBox tb_usuario_t;
        private TextBox tb_numero_contacto_t;
        private TextBox tb_nombre_t;
        private TextBox tb_id_t;
        private ComboBox cb_usuario;
    }
}