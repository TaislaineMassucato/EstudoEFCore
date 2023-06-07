using Blog.Data;
using Blog.Models;

namespace Blog
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var user = new User{
                 Name = "John Doe",
                    Email = "johndoe@example.com",
                    PasswordHash = "hashedpassword",
                    Image = "profile.jpg",
                    Slug = "john-doe",
                    Bio = "Software developer passionate about coding.",
                    GitHub = "johndoe" };

          using var context = new BlogDataContext();  
             context.Users.Add(user);
            context.SaveChanges();
           
          }
        }
    }




