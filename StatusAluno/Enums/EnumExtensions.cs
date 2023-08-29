using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusAluno
{
    public static class EnumExtensions
    {
        public static string ToDescription(this Enum TipoEnum)
        {
            string[] array = TipoEnum.ToString().Split(',');
            string[] array2 = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                DescriptionAttribute[] array3 = (DescriptionAttribute[])TipoEnum.GetType().GetField(array[i].Trim()).GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
                array2[i] = ((array3.Length != 0) ? array3[0].Description : array[i].Trim());
            }

            return string.Join(", ", array2);
        }
    }
}
