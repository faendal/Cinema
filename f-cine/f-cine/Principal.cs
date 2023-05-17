using B_Cine;
namespace f_cine
{
    public partial class Principal : Form
    {
        Multiplex multiplex;
        List<Persona> l_personas;
        Cliente cliente_seleccionado;
        Taquillero taquillero_seleccionado;
        List<byte> boletas_g;
        List<byte> boletas_p;

        public Principal()
        {
            try
            {
                InitializeComponent();
                multiplex = new Multiplex();
                multiplex.Crear_cliente(1, "Admin", "123456789", "admin", "1234");
                dt_fecha_hora.Format = DateTimePickerFormat.Custom;
                l_personas = new List<Persona> { multiplex.L_clientes[0] };
                cb_usuario.DataSource = l_personas;
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
                List<uint> l_recarga = new List<uint>
                {
                    (uint)Persona.l_recargas.v1,
                    (uint)Persona.l_recargas.v2,
                    (uint)Persona.l_recargas.v3,
                    (uint)Persona.l_recargas.v4,
                    (uint)Persona.l_recargas.v5,
                    (uint)Persona.l_recargas.v6,
                    (uint)Persona.l_recargas.v7,
                    (uint)Persona.l_recargas.v8,
                    (uint)Persona.l_recargas.v9,
                    (uint)Persona.l_recargas.v10
                };
                cb_recarga.DataSource = l_recarga;
                List<byte> l_combos = new List<byte> { 1, 2, 3, 4, 5 };
                cb_combos.DataSource = l_combos;
                groupBox5.Enabled = false;
                boletas_g = new List<byte> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                boletas_p = new List<byte> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                cb_general.DataSource = boletas_g;
                cb_preferencial.DataSource = boletas_p;

            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error construyendo el form\n" + error); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
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
                if (cb_usuario.SelectedItem.ToString() == "admin" &&
                    tb_contrasena_lg.Text == "1234") { groupBox5.Enabled = true; }
                else
                {
                    groupBox5.Enabled = false;
                    if (l_personas[cb_usuario.SelectedIndex] is Cliente)
                    {
                        tb_categoriap.Clear();
                        tb_puntosp.Clear();
                        tb_saldop.Clear();
                        cliente_seleccionado = (Cliente)l_personas[cb_usuario.SelectedIndex];
                        tb_categoriap.Text = cliente_seleccionado.Categoria.ToString();
                        tb_saldop.Text = cliente_seleccionado.Saldo.ToString();
                        tb_puntosp.Text = cliente_seleccionado.Puntos_acumulados.ToString();
                    }
                    else if (l_personas[cb_usuario.SelectedIndex] is Taquillero)
                    {
                        tb_categoriap.Clear();
                        tb_puntosp.Clear();
                        tb_saldop.Clear();
                        taquillero_seleccionado = (Taquillero)l_personas[cb_usuario.SelectedIndex];
                        tb_saldop.Text = taquillero_seleccionado.Saldo.ToString();
                    }
                }
            }
            catch (Exception error) { MessageBox.Show("Ocurrio un error abriendo sesión\n" + error); }
        }

        //Eventos para controlar que solo se seleccionen 10 boletas en total
        private void cb_sgeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
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
                if (cliente_seleccionado != null)
                {
                    cliente_seleccionado.Comprar_boletas((Funcion)cb_horarios.SelectedItem,
                                                          (byte)cb_general.SelectedItem,
                                                          (byte)cb_preferencial.SelectedItem);
                    tb_categoriap.Text = cliente_seleccionado.Categoria.ToString();
                    tb_saldop.Text = cliente_seleccionado.Saldo.ToString();
                    tb_puntosp.Text = cliente_seleccionado.Puntos_acumulados.ToString();

                }
                else if (taquillero_seleccionado != null)
                {
                    taquillero_seleccionado.Comprar_boletas((Funcion)cb_horarios.SelectedItem,
                                                          (byte)cb_general.SelectedItem,
                                                          (byte)cb_preferencial.SelectedItem);
                    tb_categoriap.Clear();
                    tb_saldop.Text = taquillero_seleccionado.Saldo.ToString();
                    tb_puntosp.Clear();
                }
                else MessageBox.Show("Ingrese sesión");
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
                l_personas.Add(multiplex.L_clientes[multiplex.L_clientes.Count - 1]);
                cb_usuario.DataSource = null;
                cb_usuario.DataSource = l_personas;
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
                cb_pelicula.DataSource = null;
                cb_cartelera.DataSource = null;
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
                cb_sala.DataSource = null;
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
                multiplex.Contratar_taquillero(uint.Parse(tb_id_t.Text), tb_nombre_t.Text, tb_numero_contacto_t.Text,
                                    tb_usuario_t.Text, tb_contrasena_t.Text);
                l_personas.Add(multiplex.L_taquilleros[multiplex.L_taquilleros.Count - 1]);
                cb_usuario.DataSource = null;
                cb_usuario.DataSource = l_personas;
                tb_id_t.Clear();
                tb_nombre_t.Clear();
                tb_numero_contacto_t.Clear();
                tb_usuario_t.Clear();
                tb_contrasena_t.Clear();
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error contratando al taquillero\n" + error); }
        }

        private void b_recargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente_seleccionado != null)
                {
                    cliente_seleccionado.Recargar_saldo((Persona.l_recargas)Enum.Parse(typeof(Persona.l_recargas), cb_recarga.SelectedItem.ToString()));
                    tb_categoriap.Text = cliente_seleccionado.Categoria.ToString();
                    tb_saldop.Text = cliente_seleccionado.Saldo.ToString();
                    tb_puntosp.Text = cliente_seleccionado.Puntos_acumulados.ToString();

                }
                else if (taquillero_seleccionado != null)
                {
                    taquillero_seleccionado.Recargar_saldo((Persona.l_recargas)Enum.Parse(typeof(Persona.l_recargas), cb_recarga.SelectedItem.ToString()));
                    tb_categoriap.Clear();
                    tb_saldop.Text = taquillero_seleccionado.Saldo.ToString();
                    tb_puntosp.Clear();
                }
                else MessageBox.Show("Ingrese sesión");
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error regargando el saldo\n" + error); }
        }

        private void b_comprar_combo_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente_seleccionado != null)
                {
                    cliente_seleccionado.Comprar_Combo((byte)(cb_combos.SelectedIndex));
                    tb_categoriap.Text = cliente_seleccionado.Categoria.ToString();
                    tb_saldop.Text = cliente_seleccionado.Saldo.ToString();
                    tb_puntosp.Text = cliente_seleccionado.Puntos_acumulados.ToString();
                }
                else MessageBox.Show("Inicie sesión como un cliente");
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error comprando el combo\n" + error); }
        }

        private void cb_cartelera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Funcion> funciones_peli = new List<Funcion>();
                Pelicula pelicula_seleccionada = (Pelicula)cb_cartelera.SelectedItem;
                foreach (Funcion funcion in multiplex.L_funciones)
                {
                    if (funcion.Pelicula.Nombre == pelicula_seleccionada.Nombre &&
                        funcion.Pelicula.Duracion == pelicula_seleccionada.Duracion) funciones_peli.Add(funcion);
                }
                cb_horarios.DataSource = funciones_peli;
            }
            catch (Exception error) { MessageBox.Show("Ocurrió un error en el cambio de índice de cartelera\n" + error); }
        }

        private void cb_horarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Funcion funcion = (Funcion)cb_horarios.SelectedItem;
            Pelicula pelicula_seleccionada = (Pelicula)cb_cartelera.SelectedItem;
            tb_edadm.Text = Convert.ToByte(pelicula_seleccionada.Edad_minima).ToString();
            tb_generop.Text = pelicula_seleccionada.Genero.ToString();
            tb_duracionp.Text = pelicula_seleccionada.Duracion.ToString();
            tb_sala.Text = funcion.Sala.ToString();
        }
    }
}