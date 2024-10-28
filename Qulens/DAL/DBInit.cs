// using Microsoft.EntityFrameworkCore;
// namespace Qulens.DAL;

// public class DBInit
// {
//     public static void Seed(IApplicationBuilder app)
//     {
//         using var serviceScope = app.ApplicationServices.CreateScope();
//         var context = serviceScope.ServiceProvider.GetRequiredService<QulensDb>();
//         context.Database.EnsureCreated();
//         context.Database.EnsureCreated();
//         if (context.Users.Any())
//         {
//             var users = new List<User>
//             {
//                 new User { Name = "Alice", Email = "Alice@gmail.com", Password = "1234" },
//                 new User { Name = "Bob", Email = "Bob@gmail.com", Password = "1234" },
//             };
//             context.Users.AddRange(users);
//             context.SaveChanges();
// ;        }
//          if (context.Profiles.Any())
//          {
//                 var profiles = new List<Profile>
//                 {
//                     new Profile { Name = "Alice", Bio = "I am a software developer", ImageUrl = "https://randomuser.me/api/port", UserId = 1 },
//                     new Profile { Name = "Bob", Bio = "I am a software developer", ImageUrl = "https://randomuser.me/api/port", UserId = 2 },
//                 };
//                 context.Profiles.AddRange(profiles);
//                 context.SaveChanges();
//          }
//          if (context.Posts.Any())
//          {
//                 var posts = new List<Post>
//                 {
//                     new Post { Content = "Hello World", ImageUrl = "https://randomuser.me/api/port", ProfileId = 1 },
//                     new Post { Content = "Hello World", ImageUrl = "https://randomuser.me/api/port", ProfileId = 2 },
//                 };
//                 context.Posts.AddRange(posts);
//                 context.SaveChanges();
//          }
//             if (context.Comments.Any())
//             {
//                     var comments = new List<Comment>
//                     {
//                         new Comment { Content = "Nice Post", PostId = 1 },
//                         new Comment { Content = "Nice Post", PostId = 2 },
//                     };
//                     context.Comments.AddRange(comments);
//                     context.SaveChanges();
//             }
//             if (context.Likes.Any())
//             {
//                     var likes = new List<Like>
//                     {
//                         new Like { PostId = 1, IsLiked = true },
//                         new Like { PostId = 2 , IsDisliked = true },
//                     };
//                     context.Likes.AddRange(likes);
//                     context.SaveChanges();
//             }
        
//     }
// }