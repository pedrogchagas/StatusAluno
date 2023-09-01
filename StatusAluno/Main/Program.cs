using System;

namespace StatusAluno
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //Novo Aluno
            Aluno aluno = new Aluno();

            aluno.nome = aluno.AtribuirNome(); //nome teste

            //Nova Disciplina
            var disciplina = new Disciplina();

            disciplina.nomeDisciplina = disciplina.AtribuirNomeDisciplina(); //disciplina teste
            disciplina.cargaHoraria = disciplina.AtribuirCargaHoraria(); //valor teste

            aluno.nota1 = aluno.AtribuirNota1();
            aluno.nota2 = aluno.AtribuirNota2();
            var mediaFinal = aluno.CalcularMedia();
            aluno.faltas = aluno.AtribuirFalta();  //valor teste
            aluno.isSemestreFinalizado = true; //valor teste


            //Verificando o status do Aluno
            var statusAluno = aluno.VerificarStatus(disciplina);

            //Aluno de Recuperação Final
            if (statusAluno == EnumStatus.Status.RECUPERACAOFINAL.ToDescription())
            {
                Console.WriteLine($"O aluno {aluno.nome} está de {statusAluno} na disciplina {disciplina.nomeDisciplina}");

                //Atribuir nota Rec Final
                var statusRecFinal = aluno.RecuperacaoFinal(mediaFinal);

                Console.WriteLine($"O aluno {aluno.nome} foi {statusRecFinal} na Recuperação Final na disciplina {disciplina.nomeDisciplina}");
            }
            else
            {
                //Aprovado ou Reprovado sem Recuperação
                Console.WriteLine($"O aluno {aluno.nome} está {statusAluno} na disciplina {disciplina.nomeDisciplina}");
            }

            Console.ReadLine();
        }
    }
}