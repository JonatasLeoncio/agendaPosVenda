namespace agendaPosVenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        //Declarar as Variaveis Globais do progeto
        public static string FuncionarioLogin;//variavel Global para armazenar dados Login



        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmAgendaPosVenda());
        }
    }
}