using System.Collections.ObjectModel;
using WpfApp.ViewModel;

namespace WpfApp.Model
{
    /// <summary>
    /// Класс коллекции должностей сотрудников
    /// </summary>
    public class ListRole: ObservableCollection<Role>
    {
        public ListRole()
        {
            RoleViewModel roles = new RoleViewModel();
            foreach (var r in roles.ListRole)
            {
                this.Add(r);
            }
        }
    }
}
