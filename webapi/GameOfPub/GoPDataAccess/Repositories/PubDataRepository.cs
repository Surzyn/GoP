using GoPDataAccess.Context;
using GoPDataAccess.Interfaces;
using GoPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GoPDataAccess.Repositories
{
    public class PubDataRepository : IPubDataRepository
    {
        public Pub GetPub(int id)
        {
            using (var pubContext = new PubDataContext())
            {
                return pubContext.Pubs
                    .Include(p => p.Comments)
                    .Include(p => p.Images)
                    .FirstOrDefault(p=>p.Id == id);
            }
        }

        public List<Pub> GetPubs()
        {
            using (var pubContext = new PubDataContext())
            {
                return pubContext.Pubs.Include(pub => pub.Images).ToList();
            }
        }
    }
}
