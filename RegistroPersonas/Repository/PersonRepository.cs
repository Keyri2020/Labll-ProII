using RegistroPersonas.Data;
using RegistroPersonas.Dominio;
using RegistroPersonas.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPersonas.Repository
{
    public class PersonRepository : IPersonas
    {
        public ApplicationDbContext context;


        public List<PersonTb> personList()
        {
            return context.personTbs.ToList();
        }

        public void SaveData(PersonTb person)
        {
            context.Add(person);
            context.SaveChanges();
        }
    }
}
