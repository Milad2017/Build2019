using NikamoozBuild2019.ModelDotnetFramework;
using System.Linq;

namespace NikamoozBuild2019.DAL.DotNetFramework
{
    public class PersonRepository
    {
        private string path = @"D:\People.txt";
        public int Insert(Person person)
        {
            var lines = System.IO.File.ReadAllLines(path).ToList();
            person.Id = lines.Count + 1;
            lines.Add( $"Id:{person.Id}, First Name:{person.FirstName}, Last Name: {person.LastName}, RegisterDate: {person.InsertDate}");
            System.IO.File.WriteAllLines(path, lines);
            return 1;

        }
    }
}
