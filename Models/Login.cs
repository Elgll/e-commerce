using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace galli.mingucci._5i.Progetto_E_Commerce.Data;
public class Login{
    public string UserName { get; set; }
    [Key]
    public string Password { get; set; }

    public ICollection<ApplicationUser> ApplicationUsers  {get; set;}
}