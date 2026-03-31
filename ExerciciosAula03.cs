namespace ExerciciosAula03;

    /// <summary>
    /// 📋 EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS
    /// =======================================
    ///
    /// Exercício 1: Classificação de números
    /// Exercício 2: Par ou Ímpar (Operador Ternário)
    /// Exercício 3: Dias da semana (Switch/Case)
    /// Exercício 4: Sistema de Autenticação
    /// </summary>
    public class AlunoCondicionais
    {
        public void Executar()
        {
            Console.WriteLine("\n📋 1. EXERCÍCIOS DE ESTRUTURAS CONDICIONAIS");
            Console.WriteLine("===========================================\n");
 
            // ===================================================
            // EXERCÍCIO 1: Classificação de números (if/else if/else)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário que digite um número
            // 2. Usar if/else if/else para classificar:
            //    - Se número > 0 → POSITIVO
            //    - Se número < 0 → NEGATIVO
            //    - Se número = 0 → ZERO
            // 3. Exibir o resultado
            //
            // 💡 Dica: Use Console.ReadLine() e Convert.ToInt32()
 
            Console.WriteLine("📝 Exercício 1: Classificação de números");
            Console.Write("Digite um número: ");
 
            // ESCREVA SEU CÓDIGO AQUI
            // 1. Solicitar ao utilizador que digite um número
            Console.Write("Digite um número inteiro: ");
            
            // Lendo a entrada (string) e convertendo para inteiro
            string entrada = Console.ReadLine();
            int numero = Convert.ToInt32(entrada);

            // 2. Usar if/else if/else para classificar
            if (numero > 0)
            {
                // Se número > 0 → POSITIVO
                Console.WriteLine("Resultado: O número é POSITIVO.");
            }
            else if (numero < 0)
            {
                // Se número < 0 → NEGATIVO
                Console.WriteLine("Resultado: O número é NEGATIVO.");
            }
            else
            {
                // Se não for maior nem menor que zero, então é ZERO
                Console.WriteLine("Resultado: O número é ZERO.");
            }

            // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();


            

            Console.WriteLine(); // Linha em branco
 
            // ===================================================
            // EXERCÍCIO 2: Par ou Ímpar (Operador Ternário)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário que digite um número
            // 2. Usar o operador ternário para verificar se é par ou ímpar
            //    Fórmula: número % 2 == 0 → "PAR", senão "ÍMPAR"
            // 3. Exibir o resultado
            //
            // 💡 Sintaxe do ternário: condição ? valor_se_true : valor_se_false
 
            Console.WriteLine("📝 Exercício 2: Par ou Ímpar (Ternário)\n");
            Console.Write("Digite um número: ");
 
            // ESCREVA SEU CÓDIGO AQUI

            // 1. Solicitar ao utilizador que digite um número
            Console.Write("Digite um número inteiro para saber se é Par ou Ímpar: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            // 2. Usar o operador ternário para verificar se é par ou ímpar
            // O operador % (módulo) retorna o resto da divisão. 
            // Se o resto da divisão por 2 for 0, o número é par.
            string resultado = (numero2 % 2 == 0) ? "PAR" : "ÍMPAR";

            // 3. mostrar o resultado
            Console.WriteLine($"O número {numero2} é: {resultado}");

            // Pausa para leitura
            Console.WriteLine("Pressione qualquer tecla para continuar...\n");
            Console.ReadKey();


 
            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 3: Dias da semana (Switch/Case)
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Solicitar ao usuário um número de 1 a 7
            // 2. Usar switch/case para exibir o dia correspondente:
            //    1 - Segunda-feira
            //    2 - Terça-feira
            //    3 - Quarta-feira
            //    4 - Quinta-feira
            //    5 - Sexta-feira
            //    6 - Sábado
            //    7 - Domingo
            // 3. Usar default para valores inválidos
            //
            // 💡 Cada case deve terminar com break
 
            Console.WriteLine("📝 Exercício 3: Dias da semana (Switch)\n");
            Console.Write("Digite um número de 1 a 7: ");
 
            // ESCREVA SEU CÓDIGO AQUI
 // 1. Solicitar ao usuário um número de 1 a 7
            Console.Write("Digite um número de 1 a 7 para saber o dia da semana: ");
            int dia = Convert.ToInt32(Console.ReadLine());

            // 2. Usar switch/case para exibir o dia correspondente
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Segunda-feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                
                // 3. Usar default para valores inválidos
                default:
                    Console.WriteLine("Erro: Valor inválido! Digite apenas números de 1 a 7.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar...\n");
            Console.ReadKey();


            Console.WriteLine();
 
            // ===================================================
            // EXERCÍCIO 4: Sistema de Autenticação
            // ===================================================
            // 👉 O QUE FAZER:
            // 1. Definir username e password corretos (admin/1234)
            // 2. Solicitar ao usuário que digite username e password
            // 3. Verificar se ambos estão corretos usando && (AND)
            // 4. Exibir "ACESSO PERMITIDO" ou "ACESSO NEGADO"
            //
            // 💡 Use == para comparar strings
 
            Console.WriteLine("📝 Exercício 4: Sistema de Autenticação\n");
            Console.Write("Username: ");
 
            // ESCREVA SEU CÓDIGO AQUI

            // 1. Definir username e password corretos
            string userCorreto = "admin";
            string senhaCorreta = "1234";

            // 2. Solicitar ao usuário que digite username e password
            Console.WriteLine("=== SISTEMA DE LOGIN ===");
            
            Console.Write("Utilizador: ");
            string userDigitado = Console.ReadLine();

            Console.Write("Senha: ");
            string senhaDigitada = Console.ReadLine();

            // 3. Verificar se ambos estão corretos usando && (AND)
            // A condição só será verdadeira se as duas comparações forem verdadeiras
            if (userDigitado == userCorreto && senhaDigitada == senhaCorreta)
            {
                // 4. Exibir resultado positivo
                Console.ForegroundColor = ConsoleColor.Green; // Bônus: muda a cor do texto para verde
                Console.WriteLine("ACESSO PERMITIDO! Bem-vindo ao sistema.\n");
            }
            else
            {
                // 4. Exibir resultado negativo
                Console.ForegroundColor = ConsoleColor.Red; // Bônus: muda a cor do texto para vermelho
                Console.WriteLine("ACESSO NEGADO! Utilizador ou senha incorretos.\n");
            }

            // Resetar a cor do console e finalizar
            Console.ResetColor();
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();

 
            Console.WriteLine();
 
            // ===================================================
            // RESUMO FINAL
            // ===================================================
            Console.WriteLine("📌 Resumo das estruturas condicionais:\n");
            Console.WriteLine("if/else      → para decisões simples e complexas");
            Console.WriteLine("ternário ?:  → para atribuições simples");
            Console.WriteLine("switch/case  → para múltiplas opções de um valor");
            Console.WriteLine("&& (AND)     → todas condições devem ser verdadeiras");
        
        

        // teste final

        int numeroSecreto = 7;
            int palpite = 0;

            Console.WriteLine("--- JOGO DA ADIVINHAÇÃO ---");
            Console.WriteLine("Adivinhe o número entre 1 e 10!");

            // O loop continua enquanto a condição for VERDADEIRA
            while (palpite != numeroSecreto)
            {
                Console.Write("Digite o seu palpite: ");
                palpite = Convert.ToInt32(Console.ReadLine());

                if (palpite != numeroSecreto)
                {
                    Console.WriteLine("❌ Errou... tente de novo!");
                }
            }

            Console.WriteLine("🎉 BOOOA! Você descobriu o número secreto!\n");
                       // Resetar a cor do console e finalizar
            Console.ResetColor();
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();
            


            // teste 2

            int numeroSecreto2 = 7;
            int palpite2 = 0;

            Console.WriteLine("--- JOGO DA ADIVINHAÇÃO ---");
            Console.WriteLine("Adivinhe o número entre 1 e 10!");

            // Usamos do-while para repetir o bloco de código ATÉ o palpite ser igual ao número secreto
            do
            {
                Console.Write("Digite o seu palpite: ");
                string entrada2 = Console.ReadLine();

                // 1. Validamos se o que foi digitado é um número
                while (!int.TryParse(entrada2, out palpite2))
                {
                    Console.WriteLine("❌ Entrada inválida! Digite apenas números.");
                    Console.Write("Tente novamente: ");
                    entrada2 = Console.ReadLine();
                }

                // 2. Verificamos se ele acertou ou errou
                if (palpite2 != numeroSecreto2)
                {
                    Console.WriteLine("❌ Errou... tente de novo!");
                }

            } while (palpite2 != numeroSecreto2); // O loop volta para o início se o palpite for diferente

            Console.WriteLine("🎉 BOOOA! Você descobriu o número secreto!\n");
                       // Resetar a cor do console e finalizar
            Console.ResetColor();
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();
           
        } // fim executar
   
   
    } // fim AlunoCondicionais