using WpfApp.Model;

namespace WpfApp.Helper
{
    public class FindPerson
    {
        private int id;

        public FindPerson(int id)
        {
            this.id = id;
        }

        public bool PersonPredicate(Person person)
        {
            return person.Id == id;
        }

    }
}
