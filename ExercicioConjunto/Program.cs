using System;
using System.Collections.Generic;

namespace ExercicioConjunto {
    class Program {
        static void Main(string[] args) {
            int matricula;
            int aluno;

            HashSet<int> mat = new HashSet<int>();
            // incluindo alunos no curso A
            Console.Write("O curso A possui quantos alunos? ");
            aluno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");

            for (int i = 0; i < aluno; i++) {
                matricula = int.Parse(Console.ReadLine());
                mat.Add(matricula);
            }

            // incluindo alunos no curso B
            Console.Write("O curso B possui quantos alunos? ");
            aluno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");

            for (int i = 0; i < aluno; i++) {
                matricula = int.Parse(Console.ReadLine());
                mat.Add(matricula);
            }

            // incluindo alunos no curso C
            Console.Write("O curso C possui quantos alunos? ");
            aluno = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");

            for (int i = 0; i < aluno; i++) {
                matricula = int.Parse(Console.ReadLine());
                mat.Add(matricula);
            }
            Console.WriteLine();

            Console.WriteLine("Alunos matriculados em todos os cursos:");
            int totalAlunos = 0;
            foreach (int x in mat) {
                Console.WriteLine(x);
                totalAlunos++;
            }
            
            Console.WriteLine("Total de alunos: " + totalAlunos);
        }
    }
}
