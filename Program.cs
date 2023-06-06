using System;
using EFCore.Data;
using EFCore.Models;

namespace EFCore {
    internal class Program
    {
        static void Main(string[] args)
        {
          using(var context = new EFCoreDataContext())
          {
                            //CREATE
            var tag = new Tag{Name = "Front", Slug = "End"};
            context.Tags.Add(tag);
            context.SaveChanges();

                            //UPDATE
            // var upTag = context.Tags.FirstOrDefault(x => x.Name == "Front");
            // upTag.Slug = "Angular";

            // context.Update(upTag);
            // context.SaveChanges();

                                //REMOVE
            // var DelTag = context.Tags.FirstOrDefault(x => x.Name == "Front");
            // DelTag.Slug = "Angular";

            // context.Remove(DelTag);
            // context.SaveChanges();
          }
        }
    }
}

