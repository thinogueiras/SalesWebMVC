using System.Collections.Generic;
using System.ComponentModel;

namespace SalesWebMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }

        public ICollection<Department> Departments { get; set; }
    }
}
