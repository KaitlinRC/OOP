using System;

namespace _10_20
{
    public class CompanyReport
    {
        private Company[] companies;

        public CompanyReport(Company[] companies) {
            this.companies = companies;
        }

        public void PrintAllCompanies() {
            for(int i = 0; i < Company.GetCount(); i++) {
                Console.WriteLine(companies[i].ToString());
            }
        }
    }
}