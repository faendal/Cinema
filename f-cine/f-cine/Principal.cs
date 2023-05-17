using B_Cine;
namespace f_cine
{
    public partial class Principal : Form
    {
        Multiplex multiplex;
        List<string> l_usuarios;

        public Principal()
        {
            try
            {
                InitializeComponent();
                multiplex = new Multiplex();
                multiplex.Crear_cliente(1, "Admin", "123456789", "admin", "1234");
                dt_fecha_hora.Format = DateTimePickerFormat.Custom;
                l_usuarios = new List<string> { multiplex.L_clientes[0].Usuario };
                cb_usuario.DataSource = l_usuarios;
                List<byte> edades = new List<byte>
                {
                    (byte)Pelicula.l_edades_minimas.v1,
                    (byte)Pelicula.l_edades_minimas.v2,
                    (byte)Pelicula.l_edades_minimas.v3,
                    (byte)Pelicula.l_edades_minimas.v4,
                    (byte)Pelicula.l_edades_minimas.v5,
                    (byte)Pelicula.l_edades_minimas.v6,
                };
                cb_edad_minima.DataSource = edades;
                List<string> generos = new List<string>
                {
                    Pelicula.l_generos.Accion.ToString(),
                    Pelicula.l_generos.Animacion.ToString(),
                    Pelicula.l_generos.Aventura.ToString(),
                    Pelicula.l_generos.Comedia.ToString(),
                    Pelicula.l_generos.Crimen.ToString(),
                    Pelicula.l_generos.Documental.ToString(),
                    Pelicula.l_generos.Drama.ToString(),
                    Pelicula.l_generos.Familia.ToString(),
                    Pelicula.l_generos.Fantasia.ToString(),
                    Pelicula.l_generos.Horror.ToString(),
                    Pelicula.l_generos.Misterio.ToString(),
                    Pelicula.l_generos.Musical.ToString(),
                    Pelicula.l_generos.Romance.ToString(),
                    Pelicula.l_generos.SciFi.ToString(),
                    Pelicula.l_generos.Thriller.ToString(),
                };
                cb_genero.DataSource = generos;
                groupBox5.Enabled = false;
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error construyendo el form\n" + error); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Llenado de los cb de sillas
                for (byte i = 0; i <= 10; i++)
                {
                    cb_general.Items.Add((byte)i);
                    cb_preferencial.Items.Add((byte)i);
                }
                tb_puntosp.Text = "0";

                //Verficiacion de puntos para asignar categoría
                string texto = tb_puntosp.Text;
                int puntos;

                puntos = int.Parse(texto);

                if (puntos < 100)
                    tb_categoriap.Text = "Normal";
                else if (puntos < 150)
                    tb_categoriap.Text = "Platino";
                else
                    tb_categoriap.Text = "Oro";

                //Llenado de combos
                cb_combos.Items.Add("0");
                cb_combos.Items.Add("Combo 1: $25.000");
                cb_combos.Items.Add("Combo 2: $30.000");
                cb_combos.Items.Add("Combo 3: $40.000");
                if (tb_categoriap.Text.Equals("Platino"))
                    cb_combos.Items.Add("Combo 4: $50.000");
                else if (tb_categoriap.Text.Equals("Oro"))  //Solo si es una categoria mas avanzada se le muestran las opciones extras de combos
                {
                    cb_combos.Items.Add("Combo 4: $50.000");
                    cb_combos.Items.Add("Combo 5: $60.000");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error en el formulario principal\n" + error);
            }
        }


        private void b_login_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cb_usuario.SelectedItem.ToString() == "admin")
                {
                    groupBox5.Enabled = true;
                }
            }
            catch (Exception error) { MessageBox.Show("Ocurrio un error abriendo sesión\n" + error); }
        }

        //Eventos para controlar que solo se seleccionen 10 boletas en total
        private void cb_sgeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                byte numSelect = Convert.ToByte(cb_general.SelectedItem);

                cb_preferencial.Items.Clear();
                for (byte i = 0; i <= 10 - numSelect; i++)
                {
                    cb_preferencial.Items.Add((byte)i);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error en el evento del cb sillas general\n" + error);
            }
        }

        private void cb_svip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                byte numSelect = Convert.ToByte(cb_preferencial.SelectedItem);

                cb_general.Items.Clear();
                for (byte i = 0; i <= 10 - numSelect; i++)
                {
                    cb_general.Items.Add((byte)i);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error en el evento del cb sillas vip\n" + error);
            }
        }
        //Fin eventos
        private void b_cerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error cerrando el formulario\n" + error);
            }
        }

        private void cb_combos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_comprar_Click(object sender, EventArgs e)
        {
            try
            {
                byte numSelectgen = Convert.ToByte(cb_general.SelectedItem);
                byte numSelectvip = Convert.ToByte(cb_preferencial.SelectedItem);
                MessageBox.Show("Usted ha comprado " + numSelectgen + " sillas generales y " + numSelectvip + " sillas VIP");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error en la compra\n" + error);
            }
        }

        private void b_registro_Click(object sender, EventArgs e)
        {
            try
            {
                multiplex.Crear_cliente(uint.Parse(tb_id.Text), tb_nombre.Text, tb_numero.Text,
                                    tb_usuario.Text, tb_contrasena.Text);
                l_usuarios.Add(tb_usuario.Text);
                cb_usuario.DataSource = l_usuarios;
                tb_id.Clear();
                tb_nombre.Clear();
                tb_numero.Clear();
                tb_usuario.Clear();
                tb_contrasena.Clear();
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error en el registro\n" + error); }
        }

        private void b_crear_pelicula_Click(object sender, EventArgs e)
        {
            try
            {
                multiplex.Pasar_pelicula(tb_nombre_peli.Text,
                                         TimeSpan.FromMinutes(int.Parse(tb_duracion_peli.Text)),
                                         (Pelicula.l_edades_minimas)Enum.Parse(typeof(Pelicula.l_edades_minimas), cb_edad_minima.SelectedItem.ToString()),
                                         (Pelicula.l_generos)Enum.Parse(typeof(Pelicula.l_generos), cb_genero.SelectedItem.ToString()));
                tb_nombre_peli.Clear();
                tb_duracion_peli.Clear();
                cb_pelicula.DataSource = multiplex.L_peliculas;
                cb_cartelera.DataSource = multiplex.L_peliculas;
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error en la creación de la película\n" + error); }
        }

        private void b_crear_sala_Click(object sender, EventArgs e)
        {
            try
            {
                multiplex.Construir_sala(ushort.Parse(tb_sillas_generales.Text),
                                         ushort.Parse(tb_sillas_preferenciales.Text));
                tb_sillas_generales.Clear();
                tb_sillas_preferenciales.Clear();
                cb_sala.DataSource = multiplex.L_salas;
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error creando la sala\n" + error); }
        }

        private void b_crear_funcion_Click(object sender, EventArgs e)
        {
            try
            {
                multiplex.Crear_funcion(dt_fecha_hora.Value,
                                        (Sala)cb_sala.SelectedItem,
                                        (Pelicula)cb_pelicula.SelectedItem);
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error creando la funcion\n" + error); }
        }

        private void b_contratar_Click(object sender, EventArgs e)
        {
            try
            {
                multiplex.Crear_cliente(uint.Parse(tb_id_t.Text), tb_nombre_t.Text, tb_numero_contacto_t.Text,
                                    tb_usuario_t.Text, tb_contrasena_t.Text);
                l_usuarios.Add(tb_usuario_t.Text);
                cb_usuario.DataSource = l_usuarios;
                tb_id_t.Clear();
                tb_nombre_t.Clear();
                tb_numero_contacto_t.Clear();
                tb_usuario_t.Clear();
                tb_contrasena_t.Clear();
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error contratando al taquillero\n" + error); }
        }
    }
}