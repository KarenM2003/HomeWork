using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Class1
    {
        public List<int> Merge(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                result.Add(arr1[i]);
            }

            for (int i = 0;i < arr2.Length; i++)
            {
                result.Add(arr2[i]);
            }

            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < result.Count; j++)
                {
                    if (result[i] < result[j])
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
    }
}
