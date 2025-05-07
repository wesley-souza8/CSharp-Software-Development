namespace Utils
{
    public static class Menu{
        public static void Show(){
            Console.WriteLine("========== Sistema de Cadastro de Produtos ==========");
            Console.WriteLine("1 - Adicionar");
            Console.WriteLine("2 - Listar todos");
            Console.WriteLine("3 - Alterar preço");
            Console.WriteLine("4 - Sair");
        }

        public static byte GetOption(){
            Console.Write("Opção:\n> ");
            if (byte.TryParse(Console.ReadLine(), out byte opc))
                return opc;
            else
                return 0;
        }
    }
}