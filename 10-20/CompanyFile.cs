using System.IO;

namespace _10_20
{
    public class CompanyFile
    {
        private Company[] companies;

        public CompanyFile(Company[] companies) {
            this.companies = companies;
        }

        public Company[] GetAllCompanies() {
            Company[] companies = new Company[50];
            Company.SetCount(0);

            StreamReader inFile = new StreamReader("input.txt");
            string line = inFile.ReadLine();
            while(line != null) {
                string[] temp = line.Split('#');
                Company tempCompany = new Company(temp[0], temp[1], double.Parse(temp[2]));
                companies[Company.GetCount()] = tempCompany;
                Company.IntCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
            return companies;
        }
    }
}