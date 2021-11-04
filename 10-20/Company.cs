namespace _10_20
{
    public class Company
    {
        private string name;
        private string industry;
        private double annualRev;
        private static int count;

        public Company() {}
        public Company(string name, string industry, double annualRev) {
            this.name = name;
            this.industry = industry;
            this.annualRev = annualRev;
        }

        public void SetName(string name) {
            this.name = name;
        }
        public void SetIndustry(string industry) {
            this.industry = industry;
        }
        public void SetAnnualRev(double annualRev) {
            this.annualRev = annualRev;
        }
        
        public static void SetCount(int count) {
            // data shadowing problem (this or class name)
            Company.count = count;
        }

        public string GetName() {
            return name;
        }
        public string GetIndustry() {
            return industry;
        }
        public double GetAnnualRev() {
            return annualRev;
        }

        public static int GetCount() {
            return count;
        }
        public static void IntCount() {
            count++;
        }
        public override string ToString() {
            return name + " is in the " + industry + " industry and makes " + annualRev + " billion per year";
        }
        public int CompareTo(Company company) {
            return this.name.CompareTo(company.GetName());
        }

    }
}