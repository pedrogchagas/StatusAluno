using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusAluno
{
    //Esse EnumStatus foi criado para organizar melhor o projeto,
    //evitando a repetição de strings completas
    //e facilitando a comparação dos valores
    public class EnumStatus
    {
        public enum Status
        {
            [Description("Aprovado")]
            APROVADO = 0,
            [Description("Recuperação Final")]
            RECUPERACAOFINAL = 1,
            [Description("Reprovado")]
            REPROVADO = 2,
            [Description("Sem status definido")]
            STATUSINDEFINIDO = 3,
        }
    }
}
