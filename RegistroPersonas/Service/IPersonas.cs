using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistroPersonas.Dominio;

namespace RegistroPersonas.Service
{
    public interface IPersonas
    {
        public void SaveData(PersonTb person);

        List<PersonTb> personList();
    }
}