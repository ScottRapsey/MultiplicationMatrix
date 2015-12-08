using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write code to print out multiplication tables, based on two input parameters
//a.Starting value(int)
//b.Ending value(int)

//Example output(for inputs 1, 12):

//1	2	3	4	5	6	7	8	9	10	11	12
//2	4	6	8	10	12	14	16	18	20	22	24
//3	6	9	12	15	18	21	24	27	30	33	36
//4	8	12	16	20	24	28	32	36	40	44	48
//5	10	15	20	25	30	35	40	45	50	55	60
//6	12	18	24	30	36	42	48	54	60	66	72
//7	14	21	28	35	42	49	56	63	70	77	84
//8	16	24	32	40	48	56	64	72	80	88	96
//9	18	27	36	45	54	63	72	81	90	99	108
//10	20	30	40	50	60	70	80	90	100	110	120
//11	22	33	44	55	66	77	88	99	110	121	132
//12	24	36	48	60	72	84	96	108	120	132	144


namespace MultiplicationMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //no point reinventing the wheel by writing our own commandLine parser
            //use the CommandLineParser https://www.nuget.org/packages/CommandLineParser/2.0.275-beta
            var result = CommandLine.Parser.Default.ParseArguments<Options>(args);
            var exitCode = result
                 .MapResult(
                     options =>
                     {
                         var multiplicationResult = RawOutputGenerator.GetMultiplicationMatrixString(options.Starting, options.Ending);
                         Console.WriteLine(multiplicationResult);
                         return 0;
                     },
                     parseErrors =>
                     {
                         //log the errors away somewhere
                         foreach (var item in parseErrors)
                         {
                             Console.WriteLine(item.ToString());
                         }
                         System.Diagnostics.Debug.WriteLine(parseErrors);
                         return 1;
                     });

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();


            ////var result = RawPrinter.GetMultiplicationMatrixString(1, 12);
            ////Console.WriteLine(result);

            //the formating goes out the window when we use negative numnbers
            //result = RawPrinter.GetMultiplicationMatrixString(-5, 5);
            //Console.WriteLine(result);

            ////the formating goes out the window when we get to results in the 1000
            //result = RawPrinter.GetMultiplicationMatrixString(1, 32);
            //Console.WriteLine(result);
        }
    }

    internal class Options
    {
        [Option('s', "starting", Required = true,
          HelpText = "starting value")]
        public int Starting { get; set; }

        [Option('e', "ending", Required = true, Separator = ',',
          HelpText = "ending value")]
        public int Ending { get; set; }
    }
}
