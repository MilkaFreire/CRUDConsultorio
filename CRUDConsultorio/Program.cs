









/*int opcao = 0;

List<Paciente> pacientes = new List<Paciente>();



do
{


    Console.WriteLine("Qual a opção deseja executar?");

    Console.WriteLine("1.Cadastrar novo paciente");
    Console.WriteLine("2.Listar todos os pacientes ");
    Console.WriteLine("3.Excluir cadastro do paciente");
    Console.WriteLine("4.Editar cadastro");
    Console.WriteLine("5.Sair.");
    opcao = int.Parse(Console.ReadLine());


    switch (opcao)
    {
        case 1:
            {


                Console.WriteLine("Digite o Idpaciente:");
                int IdPaciente = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do paciente:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf do paciente:");
                string cpf = Console.ReadLine();

                Console.WriteLine("Digite o Email do paciente:");
                string Email = Console.ReadLine();

                Console.WriteLine("Digite o telefone do paciente:");
                string telefone = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do paciente:");
                string DataNascimento = Console.ReadLine();


                Paciente p = new Paciente(IdPaciente, nome, cpf, Email, telefone, DataNascimento);

                pacientes.Add(p);
            }


            break;


        case 2:
            {
                foreach (Paciente p2 in pacientes)
                {
                    Console.WriteLine("############");
                    Console.WriteLine($"IdPaciente:{p2.IdPaciente}");
                    Console.WriteLine($"nome:{p2.Nome}");
                    Console.WriteLine($"cpf:{p2.Cpf}");
                    Console.WriteLine($"Email:{p2.Email}");
                    Console.WriteLine($"telefone:{p2.Telefone}");
                    Console.WriteLine($"DataNascimento:{p2.DataNascimento}");
                   
                }

                break;
            }

        case 3:
            { 
                
                Console.WriteLine("");
                break;
            }

        case 4:
            {
                break;
            }

        case 5:
            {
                break;
            }

        default:
            break;
    }
} while (opcao != 5);*/
