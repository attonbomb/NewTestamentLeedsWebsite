using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTestamentLeedsWebsite.Models
{
    public class NTCGLeedsContext:NTCGLeedsNewEntities, INTCGLeedsContext
    {
        IQueryable<CEvent> INTCGLeedsContext.CEvents
        {
            get { return CEvents; }
        }

        IQueryable<CImage> INTCGLeedsContext.CImages
        {
            get { return CImages; }
        }

        int INTCGLeedsContext.SaveChanges()
        {
            try
            {
                return SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        T INTCGLeedsContext.Add<T>(T entity)
        {
            return Set<T>().Add(entity);
        }

        T INTCGLeedsContext.Delete<T>(T entity)
        {
            return Set<T>().Remove(entity);
        }

        void INTCGLeedsContext.Update(CEvent entity1, CEvent entity2)
        {
            Entry(entity1).CurrentValues.SetValues(entity2);
        }

        CImage INTCGLeedsContext.FindPhotoById(int ID)
        {
            return Set<CImage>().Find(ID);
        }

        CEvent INTCGLeedsContext.FindEventById(int ID)
        {
            return Set<CEvent>().Find(ID);
        }
    }
}