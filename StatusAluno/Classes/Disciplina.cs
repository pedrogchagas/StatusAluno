using System;

namespace StatusAluno
{
    //Classe Disciplina
    public class Disciplina
    {
        public string nomeDisciplina;

        public int cargaHoraria;

        public string AtribuirNomeDisciplina()
        {
            Console.Write("Digite o nome da Disciplina:");
            var nome = Console.ReadLine();

            return nome;
        }

        public int AtribuirCargaHoraria()
        {
            Console.Write("Escolha a carga horária da matéria. Digite 1 para 80 horas, 2 para 60 horas e 3 para 40 horas:");
            var escolha = Console.ReadLine();

            if (escolha == "1")
            {
                var carga = EnumCargaHoraria.CargaHoraria.OITENTAHORAS.ToDescription();
                var intCarga = Convert.ToInt32(carga);

                return intCarga;
            }
            else if (escolha == "2")
            {
                var carga = EnumCargaHoraria.CargaHoraria.SESSENTAHORAS.ToDescription();
                var intCarga = Convert.ToInt32(carga);

                return intCarga;
            }
            else if (escolha == "3")
            {
                var carga = EnumCargaHoraria.CargaHoraria.QUARENTAHORAS.ToDescription();
                var intCarga = Convert.ToInt32(carga);

                return intCarga;
            }
            else
            {
                return 0;
            }
        }
    }
}