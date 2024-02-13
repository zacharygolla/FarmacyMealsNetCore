using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Runtime.Serialization;

namespace FarmacyMeals.WebApi.Models.User
{
    [DataContract]
    public class UserModel : IdentityUser
    {

    }
}
