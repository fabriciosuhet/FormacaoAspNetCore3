using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASPNET Core 1", "Minha descrição de projeto 1", 1, 1, 10000),
                new Project("Meu projeto ASPNET Core 2", "Minha descrição de projeto 2", 1, 1, 20000),
                new Project("Meu projeto ASPNET Core 3", "Minha descrição de projeto 3", 1, 1, 30000),
            };

            Users = new List<User>
            {
                new User("Fabrício Suhet", "fabricio@dev.com", new DateTime(2000, 03, 15)),
                new User("Thais Costa", "thais@dev.com", new DateTime(2002, 02, 06)),
                new User("Fabricio Silva", "silva@dev.com", new DateTime(2000, 03, 15)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET CORE"),
                new Skill("C#"),
                new Skill("SQL"),
            };
        }
        public List<Project>? Projects { get; set; }
        public List<User>? Users { get; set; }
        public List<Skill>? Skills { get; set; }
        public List<ProjectComment> ProjectComments { get; set; }
    }
}
