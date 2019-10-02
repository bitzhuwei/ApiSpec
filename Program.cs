using System;

namespace ApiSpec {
    // C:/VulkanSDK/1.1.106.0/Documentation/apispec.html
    class Program {
        const string fileApispec = "apispec.txt";
        static void Main(string[] args) {
            Console.WriteLine("Parsing...");

            ExtensionsParser.Dump();

            //EnumsParser.Testh4();
            //EnumsParser.h4Counts();
            EnumsParser.Dump();

            //HandlesParser.Testh4();
            //HandlesParser.h4Counts();
            HandlesParser.Dump();

            //FlagsParser.Testh4();
            //FlagsParser.h4Counts();
            FlagsParser.Dump();

            //PFNsParser.Testh4();
            //PFNsParser.h4Counts();
            PFNsParser.Dump();

            //StructsParser.Testh4();
            //StructsParser.h4Counts();
            StructsParser.Dump();
            StructsMarshalParser.Dump();
            StructsSizeParser.Dump();

            //CommandsParser.Testh4();
            //CommandsParser.h4Counts();
            CommandsParser.Dump();

            //Console.ReadKey();
        }
    }


}
