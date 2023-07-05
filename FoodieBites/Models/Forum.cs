using System.ComponentModel.DataAnnotations;

namespace FoodieBites.Models;

public class Forum
{
    public int Id { get; set; }
    public string imageurl { get; set; }
    public string Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime PostDate { get; set; }
    public string MealType { get; set; }
    public decimal Price { get; set; }

    public string Description { get; set; }

    public string ingredients { get; set; }
    public string instructons { get; set; }


}