using GoPDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoPDataAccess.Interfaces
{
    public interface IPubDataRepository
    {
        List<Pub> GetPubs();
        Pub GetPub(int id);
    }
}
