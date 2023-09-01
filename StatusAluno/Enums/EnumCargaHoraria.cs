using System.ComponentModel;

namespace StatusAluno
{
    //Esse EnumCargaHoraria foi criado para organizar melhor o projeto,
    //evitando a repetição de strings completas
    //e facilitando a comparação dos valores
    public static class EnumCargaHoraria
    {
        public enum CargaHoraria
        {
            [Description("80")]
            OITENTAHORAS = 0,

            [Description("60")]
            SESSENTAHORAS = 1,

            [Description("40")]
            QUARENTAHORAS = 2,
        }
    }
}