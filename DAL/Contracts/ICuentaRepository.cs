using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface ICuentaRepository
    {
        Cuenta GetOne(string Nombre);
        void Insert(Cuenta obj);
    }
}
