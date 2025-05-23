using Exercise_ContractsPayment.Enitites;
using Exercise_ContractsPayment.Services;
using System.Globalization;

namespace Exercise_ContractsPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract cotract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(cotract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in cotract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
