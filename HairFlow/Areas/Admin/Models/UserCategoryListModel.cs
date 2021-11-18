using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HairFlow.Areas.Admin.Models
{
    public class UserCategoryListModel
    {
        public int CategoryId { get; set; }
        public ICollection<UserModel> Users { get; set; }
        public ICollection<UserModel> UsersSelected { get; set; }
    }
}
