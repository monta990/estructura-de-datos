using System;
using System.Windows.Forms;
namespace esdat
{
    public partial class FrmBusquedaBinaria : Form
    {
        private int[] valores;
        public FrmBusquedaBinaria() => InitializeComponent();
        private void btGenerar_Click(object sender, EventArgs e)
        {
            dGViewElementos.Rows.Clear();
            if (int.TryParse(tBelementos.Text,out int ele) && int.TryParse(tBlimite.Text, out int ele2))
            {
                if (ele2 <= 0)
                {
                    MessageBox.Show("El limite no puede ser inferior 0", "Limite muy bajo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    valores = new int[ele]; //tBelementos
                    Random random1 = new Random();
                    for (int i = 0; i < valores.Length; i++)
                    {
                        valores[i] = random1.Next(ele2 + 1); //tBlimite.Text);
                    }
                    Array.Sort(valores);
                    for (int i = 0; i < valores.Length; i++)
                    {
                        dGViewElementos.Rows.Add(valores[i].ToString());
                        dGViewElementos.Rows[i].HeaderCell.Value = i.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Los elementos o el limite no son un numero enterto", "Numeros ingresados no son enteros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //http://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1
        /// <summary>
        /// Busqueda binaria de un elemento
        /// </summary>
        /// <param name="inputArray">Arreglo de numeros en el cual buscar</param>
        /// <param name="key">Elemento a buscar</param>
        /// <returns>Ubicación del elemento en el arreglo</returns>
        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    ++mid;
                    return " esta en la posición "+mid.ToString();
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return " no esta";
        }
        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tBbuscar.Text, out int res))
            {
                MessageBox.Show("El elemento " + tBbuscar.Text + BinarySearchIterative(valores, int.Parse(tBbuscar.Text)).ToString() + " en la lista.", "Elemento encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El campo esta vacio o no es numero entero","Dato invalido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btSalir_Click(object sender, EventArgs e) => this.Close();
        private void btLimpiar_Click(object sender, EventArgs e)
        {
            dGViewElementos.Rows.Clear();
            tBelementos.Clear();
            tBlimite.Clear();
            tBbuscar.Clear();
        }
    }
}