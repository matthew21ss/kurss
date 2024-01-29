using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _732_2AlphSort
{
    public class Sorter1
    {
        public string MakeSort(string input)
        {

            string[] inputArray = input.Split(' ');

            int[] array = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
                try
                {
                    array[i] = int.Parse(inputArray[i]);
                }
                catch (Exception ex)
                {
                    
                    MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            GnomeSortMethod(array);

            string result = "";
            foreach (int i in array)
            {
                result += i.ToString() + " ";
            }

            return result;
        }


        private void GnomeSortMethod(int[] arr)
        {
            int pos = 0;
            while (pos < arr.Length)
            {
                if (pos == 0 || arr[pos] >= arr[pos - 1])
                {
                    pos++;
                }
                else
                {
                    int temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos--;
                }
            }
        }
    }
}



