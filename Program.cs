using System;
using System.IO;

namespace VisitorLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simulando la entrada de un visitante
            LogVisitor("Visitor1");
            LogVisitor("Visitor2");
            LogVisitor("Visitor3");

            // Leer el archivo de log
            Console.WriteLine("Contenido del archivo de log:");
            var logContents = File.ReadAllText("visitors.log");
            Console.WriteLine(logContents);

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static void LogVisitor(string visitorName)
        {
            var logPath = "visitors.log";
            var visitorInfo = $"{DateTime.Now}: {visitorName} ha visitado la página.";
            File.AppendAllText(logPath, visitorInfo + Environment.NewLine);
            Console.WriteLine($"Registrado: {visitorInfo}");
        }
    }
}
