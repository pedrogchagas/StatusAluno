﻿using System;
using System.ComponentModel;

namespace StatusAluno
{
    //Essa classe foi criada para trazer a descrição do Enum (string), quando utilizar o ToDescription()
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