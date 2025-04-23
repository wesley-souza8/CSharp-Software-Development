using Model;
using Interface;
using Repository;

byte option;
ClienteRepository repository = new ClienteRepository();


do{
    
    Menu.Show();
    option = Menu.GetOption();
    Console.Clear();
    
    switch (option){
        case 1:
        case 2:
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();
            
            Cliente cliente = option == 1 
                ? new ClienteComum(nome, sobrenome) 
                : new ClienteVIP(nome, sobrenome);

            repository.Add(cliente);
            Console.WriteLine("Cliente adicionado com sucesso!\n");
            break;

        case 3:
            List<Cliente> todos = repository.GetAll();
            if (todos.Count == 0){
                Console.WriteLine("Nenhum cliente cadastrado.\n");
                break;  
            }else{
                Console.WriteLine("==== Cliente cadastrados ===");
                foreach (Cliente c in todos){
                    Console.WriteLine(c.MostrarTipo());
                    Console.WriteLine(((IPrintable)c).PrintDetails());
                }
                Console.WriteLine("");
            }
            break;

        case 4:
            Console.WriteLine("Encerrando o programa......");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

} while( option != 4);
