using System;
using System.IO;

namespace _10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Company[] companies = new Company[50];

            CompanyFile companyFile = new CompanyFile(companies);
            companies = companyFile.GetAllCompanies();

            CompanyReport reporter = new CompanyReport(companies);
            reporter.PrintAllCompanies();

            CompanyUt companyUt = new CompanyUt(companies);
            companyUt.Sort();

            Console.WriteLine("\n- After the sort -\n");
            reporter.PrintAllCompanies();
        }
    }
}
