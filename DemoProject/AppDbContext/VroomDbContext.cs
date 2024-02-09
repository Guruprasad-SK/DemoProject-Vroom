
using Microsoft.EntityFrameworkCore;

namespace DemoProject.AppDbContext
{
    public class VroomDbContext:DbContext
    {
        public VroomDbContext(DbContextOptions<VroomDbContext> options):base(options)
        {

        }
       
    }
}
