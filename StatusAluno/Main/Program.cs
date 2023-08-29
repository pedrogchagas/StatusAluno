﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Novo Aluno
            Aluno aluno = new Aluno();

            aluno.nome = "Pedro Chagas"; //nome teste
            aluno.nota1 = aluno.AtribuirNota1();
            aluno.nota2 = aluno.AtribuirNota2();
            var mediaFinal = aluno.CalcularMedia();
            aluno.faltas = 10;  //valor teste
            aluno.isSemestreFinalizado = true; //valor teste

            //Nova Disciplina
            var disciplina = new Disciplina();

            disciplina.nomeDisciplina = "Programação Orientada a Objetos II"; //disciplina teste
            disciplina.cargaHoraria = 80; //valor teste

            //Verificando o status do Aluno
            var statusAluno = aluno.VerificarStatus(disciplina);

            if (statusAluno == EnumStatus.Status.RECUPERACAOFINAL.ToDescription())
            {
                Console.WriteLine($"O aluno {aluno.nome} está de {statusAluno} na disciplina {disciplina.nomeDisciplina}");

                var statusRecFinal = aluno.RecuperacaoFinal(mediaFinal);

                Console.WriteLine($"O aluno {aluno.nome} foi {statusRecFinal} na Recuperação Final na disciplina {disciplina.nomeDisciplina}");
            }
            else 
            {
                Console.WriteLine($"O aluno {aluno.nome} está {statusAluno} na disciplina {disciplina.nomeDisciplina}");
            }

            Console.ReadLine();
        }
    }
}
