using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using WpfAppName.Model;
using WpfAppName.ViewModel;


namespace WpfAppName.Helper
{
    class FindRole
    {
        int id;
        public FindRole(int id)
        {
            this.id = id;

        }
        public bool RolePredicate(Role role)
        {
            return role.Id == id;
        }
    }
}
