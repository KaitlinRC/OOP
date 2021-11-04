namespace _10_20
{
    public class CompanyUt
    {
        private Company[] companies;

        public CompanyUt(Company[] companies) {
            this.companies = companies;
        }
        public void Sort() {
            for(int i = 0; i < Company.GetCount() - 1; i++) {
                int max = i;
                for(int j = i + 1; j < Company.GetCount(); j++) {
                    if(companies[max].CompareTo(companies[j]) < 0) {
                        max = j;
                    }
                }
                if(max != i) {
                    Swap(max, i);
                }
            }
        }
        public void Swap(int x, int y) {
            Company temp = companies[x];
            companies[x] = companies[y];
            companies[y] = temp;
        }
    }
}