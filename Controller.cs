using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class UserController
    {
        private UserModel model;
        private UserViewForm view;

        public UserController(UserModel model, UserViewForm view)
        {
            this.model = model;
            this.view = view;
            this.view.UpdateView(this.model.Username);
        }

        public void UpdateUsername(string newUsername)
        {
            model.Username = newUsername;
            view.UpdateView(model.Username);
        }

        public void ShowView()
        {
            view.ShowDialog();
        }
    }
}
