using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTestamentLeedsWebsite.Models
{
    public interface INTCGLeedsContext
    {
        IQueryable<CEvent> CEvents { get; }
        IQueryable<CImage> CImages { get; }
        int SaveChanges();
        T Add<T>(T entity) where T : class;
        T Delete<T>(T entity) where T : class;
        void Update(CEvent entity1, CEvent entity2);
        CImage FindPhotoById(int ID);
        CEvent FindEventById(int ID);
    }
}
