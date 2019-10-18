using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiEfCoreSqlServerStarter
{
    public class ContextSeed
    {
        public static void SeedData(Context context)
        {
            if (context.Entities.Any())
                return;

            var entities = new List<Entity>
            {
                new Entity() {Id = Guid.NewGuid(), Value = new Random().Next().ToString()},
                new Entity() {Id = Guid.NewGuid(), Value = new Random().Next().ToString()}
            };

            context.Entities.AddRange(entities);
            context.SaveChanges();
        }        
    }
}
