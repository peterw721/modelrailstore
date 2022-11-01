using System.ComponentModel.DataAnnotations;
namespace _92031083_ModelRailStore.Models
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }
    public class CategoryMetaData
    {
        [Display(Name = "Category Name")]
        public string Name;
    }
}