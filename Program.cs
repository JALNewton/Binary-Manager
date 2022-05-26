using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryManager binMngr = new BinaryManager();

            binMngr.WriteLoadFile("testeArquivo.bin");
            binMngr.Write("Sistema de gerenciamento criado por jose araujo!");
            
            binMngr.CloseFileWriter();

            binMngr.ReadLoadFile("testeArquivo.bin");
            Console.WriteLine(binMngr.ReadString());
            binMngr.Close();
        }
    }
}
