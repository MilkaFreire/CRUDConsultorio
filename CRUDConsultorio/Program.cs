


using CRUDConsultorio;

int opcao = 0;


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


             
                Console.WriteLine("Digite o nome do paciente:");
                string Nome = Console.ReadLine();

                Console.WriteLine("Digite o cpf do paciente:");
                string Cpf = Console.ReadLine();

                Console.WriteLine("Digite o Email do paciente:");
                string Email = Console.ReadLine();

                Console.WriteLine("Digite o telefone do paciente:");
                string Telefone = Console.ReadLine();

                Console.WriteLine("Digite a data de nascimento do paciente:");
                string DataNascimento = Console.ReadLine();


                Paciente p = new Paciente();
                p.Nome = Nome;
                p.Cpf = Cpf;
                p.Email = Email;
                p.Telefone =Telefone;
                p.DataNascimento = DataNascimento;
                PacienteDAO pacienteDAO = new PacienteDAO();

                pacienteDAO.Salvar(p);

                Console.WriteLine("Paciente cadastrado com sucesso!");
            }


            break;


        case 2:
            {
                PacienteDAO pacienteDAO = new PacienteDAO();
                List<Paciente> pacientes =pacienteDAO.Listar();

                foreach (Paciente p2 in pacientes)
                {
                    Console.WriteLine($"nome:{p2.Nome}");
                    Console.WriteLine($"cpf:{p2.Cpf}");
                    Console.WriteLine($"Email:{p2.Email}");
                    Console.WriteLine($"telefone:{p2.Telefone}");
                    Console.WriteLine($"DataNascimento:{p2.DataNascimento}");
                   
                }

            }
            break;


        case 3:
            {

                try
                {
                    PacienteDAO pacienteDAO = new PacienteDAO();

                    Console.WriteLine("Digite o Id do paciente que deseja excluir:");
                    int IdExcluir = Convert.ToInt32(Console.ReadLine());
                    pacienteDAO.Deletar(IdExcluir);
                    Console.WriteLine("Paciente excluido com sucesso!");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Erro ao deletar paciente: {ex.Message}");
                }                

            }
            break;

        case 4:
            {

                PacienteDAO pacienteDAO = new PacienteDAO();

                Console.WriteLine("Digite o ID do paciente que deseja atualizar:");
                int IdAtualizar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Como deseja atualizar o nome do paciente?");
                string nomeAtualizado = Console.ReadLine();  
                
                Console.WriteLine("Como deseja atualizar o CPF do paciente?");
                string CpfAtualizado = Console.ReadLine();    
                
                Console.WriteLine("Como deseja atualizar o Email do paciente?");
                string EmailAtualizado = Console.ReadLine();

                 Console.WriteLine("Como deseja atualizar o Telefone do paciente?");
                string TelefoneAtualizado = Console.ReadLine();


                Console.WriteLine("Como deseja atualizar a DataNascimento do paciente?");
                string DataNascimentoAtualizado = Console.ReadLine();

                Paciente paciente = new Paciente();
                paciente.IdPaciente = IdAtualizar;
                paciente.Cpf = CpfAtualizado;
                paciente.Email = EmailAtualizado;
                paciente.Telefone = TelefoneAtualizado;
                paciente.DataNascimento = DataNascimentoAtualizado;

                pacienteDAO.Atualizar(paciente);

                Console.WriteLine(" Paciente atualizado com sucesso!");


            }
            break;

        case 5:
            {
                break;
            }

        default:
            break;
    }
} while (opcao != 5);
