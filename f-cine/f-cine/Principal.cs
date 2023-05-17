namespace f_cine
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Llenado de los cb de sillas
                for (byte i = 0; i <= 10; i++)
                {
                    cb_sgeneral.Items.Add((byte)i);
                    cb_svip.Items.Add((byte)i);
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
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error abriendo el formulario\n" + error);
            }
        }

        //Eventos para controlar que solo se seleccionen 10 boletas en total
        private void cb_sgeneral_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                byte numSelect = Convert.ToByte(cb_sgeneral.SelectedItem);

                cb_svip.Items.Clear();
                for (byte i = 0; i <= 10 - numSelect; i++)
                {
                    cb_svip.Items.Add((byte)i);
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
                byte numSelect = Convert.ToByte(cb_svip.SelectedItem);

                cb_sgeneral.Items.Clear();
                for (byte i = 0; i <= 10 - numSelect; i++)
                {
                    cb_sgeneral.Items.Add((byte)i);
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
                byte numSelectgen = Convert.ToByte(cb_sgeneral.SelectedItem);
                byte numSelectvip = Convert.ToByte(cb_svip.SelectedItem);
                MessageBox.Show("Usted ha comprado " + numSelectgen + " sillas generales y " + numSelectvip + " sillas VIP");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error en la compra\n" + error);
            }
        }
    }
}