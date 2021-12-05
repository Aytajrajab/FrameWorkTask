using FrameWorkTask.Models;
using System.Collections.Generic;

namespace FrameWorkTask.ViewModels
{
    public class HomeViewModel
    {
        public List<Products> products { get; set; }
        public List<Users> users { get; set; }
        public List<Roles> roles { get; set; }
        public List<Categories> categories { get; set; }
    }
}
