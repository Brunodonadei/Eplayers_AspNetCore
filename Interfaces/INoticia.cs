using System.Collections.Generic;
using Eplayers_AspNetCore.Models;

namespace Eplayers_AspNetCore.Interfaces
{
    public interface INoticia
    {
         void Create(Noticia n);
         List<Noticia> ReadAll();
         void Update(Noticia n);
         void Delete(int id);
         
    }
}