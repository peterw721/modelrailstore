using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;

namespace _92031083_ModelRailStore.ViewModels
{
    public class ProductIndexViewModel
    {
        public IPagedList<Models.Product> Products { get; set; }
        //public IQueryable<Models.Product> Products { get; set; }

        public string Search { get; set; }

        //will hold all of the CategoryWithCount items to be used in the select control in the view
        public IEnumerable<CategoryWithCount> CatsWithCount { get; set; }

        //wil be used as the name of the select control in the view
        public string Category { get; set; }

        public string SortBy { get; set; }
        public Dictionary<string, string> Sorts { get; set; }

        // will generate a value of the categoryName to be used as the value when the HTML form is
        // submitted and the text displayed in the format of CatNameWithCount
        public IEnumerable<SelectListItem> CatFilterItems
        {
            get
            {
                var allCats = CatsWithCount.Select(cc => new SelectListItem
                {
                    Value = cc.CategoryName,
                    Text = cc.CatNameWithCount
                });
                return allCats;
            }
        }
    }
    public class CategoryWithCount
    {
        public int ProductCount { get; set; }
        public string CategoryName { get; set; }
        public string CatNameWithCount
        {
            get
            {
                return CategoryName + " (" + ProductCount.ToString() + ")";
            }
        }
    }
}