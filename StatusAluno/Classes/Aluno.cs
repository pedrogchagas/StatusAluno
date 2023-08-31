using System;

namespace StatusAluno
{
    //Classe Aluno
    public class Aluno
    {
        public string nome;

        public double nota1;

        public double nota2;

        public double media;

        public int faltas;

        public string status;

        public string statusRecFinal;

        public bool isSemestreFinalizado;

        //Método para ler as notas do aluno
        private double LerNota()
        {
            while (true)
            {
                try
                {
                    //Receber como string para tratar pontos como vírgula
                    //Estava dando erro pois tratava 3.1 como 31 e não 3,1
                    string input = Console.ReadLine();
                    input = input.Replace('.', ',');

                    return double.Parse(input);
                }
                catch (FormatException)
                {
                    Console.Write("Formato inválido. Digite novamente: ");
                }
            }
        }

        //Atribuir primeira nota
        public double AtribuirNota1()
        {
            Console.Write("Digite a nota do primeiro bimestre do aluno: ");

            while (true)
            {
                double nota = LerNota();
                if (nota >= 0 && nota <= 10)
                {
                    return nota;
                }
                else
                {
                    Console.Write("Nota deve ser entre 0 e 10. Digite novamente: ");
                }
            }
        }

        //Atribuir segunda nota
        public double AtribuirNota2()
        {
            Console.Write("Digite a nota do segundo bimestre do aluno: ");
            while (true)
            {
                double nota = LerNota();
                if (nota >= 0 && nota <= 10)
                {
                    return nota;
                }
                else
                {
                    Console.Write("Nota deve ser entre 0 e 10. Digite novamente: ");
                }
            }
        }

        //Calcular a média do aluno
        public double CalcularMedia()
        {
            media = (nota1 + nota2) / 2;

            return media;
        }

        //Método para atribuir faltas
        public void AtribuirFalta()
        {
            faltas++;
        }

        //Método para abonar faltas
        public void AbonarFalta()
        {
            if (faltas > 0)
            {
                faltas--;
            }
        }

        //Verifica o status do aluno
        public string VerificarStatus(Disciplina disciplina)
        {
            if (isSemestreFinalizado)
            {
                if (faltas <= (0.25 * disciplina.cargaHoraria) && (media >= 7))
                {
                    status = EnumStatus.Status.APROVADO.ToDescription();
                }
                else if (faltas <= (0.25 * disciplina.cargaHoraria) && (media >= 3))
                {
                    status = EnumStatus.Status.RECUPERACAOFINAL.ToDescription();
                }
                else
                {
                    status = EnumStatus.Status.REPROVADO.ToDescription();
                }
            }
            else
            {
                status = EnumStatus.Status.STATUSINDEFINIDO.ToDescription();
            }

            return status;
        }

        //Caso o Aluno fique de recuperação final
        public string RecuperacaoFinal(double mediaFinal)
        {
            Console.Write("Digite a nota do aluno na prova de Recuperação Final: ");

            while (true)
            {
                double nota = LerNota();
                if (nota >= 0 && nota <= 10)
                {
                    if (mediaFinal + nota >= 10)
                    {
                        statusRecFinal = EnumStatus.Status.APROVADO.ToDescription();
                    }
                    else
                    {
                        statusRecFinal = EnumStatus.Status.REPROVADO.ToDescription();
                    }

                    return statusRecFinal;
                }
                else
                {
                    Console.Write("Nota deve ser entre 0 e 10. Digite novamente: ");
                }
            }
        }
    }
}