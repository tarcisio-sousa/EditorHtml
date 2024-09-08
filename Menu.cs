namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine()!);
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            DrawLine('+', '-', true);

            DrawRow('|', ' ', 10);

            DrawLine('+', '-');
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==============");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecoine uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opções: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    Console.WriteLine("View");
                    break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    Show();
                    break;
            }
        }

        private static void DrawRow(char edge, char column, int size)
        {
            for (int lines = 0; lines <= size; lines++)
            {
                DrawLine(edge, column, true);
            }
        }

        private static void DrawLine(char edge, char column, bool breakLine = false, int size = 30)
        {
            Console.Write(edge);

            DrawColumn(column, size);

            Console.Write(edge);

            if (breakLine)
            {
                Console.Write("\n");
            }
        }

        private static void DrawColumn(char column, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                Console.Write(column);
            }
        }
    }
}