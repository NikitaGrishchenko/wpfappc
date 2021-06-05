using WpfApp.Model;

namespace WpfApp.Helper
{
    public class FindPersonDPO
    {
        private readonly int id;

        public FindPersonDPO(int id)
        {
            this.id = id;
        }

        public bool PersonDpoPredicate(PersonDPO person)
        {
            return person.Id == id;
        }
    }
}
