using System;
using Dapper;
using System.Data;
using AstartesCodexProject.Models;
using System.Collections.Generic;

namespace AstartesCodexProject.Data
{
  public class PrimarchRepository
  {
    private readonly IDbConnection _db;
    public PrimarchRepository(IDbConnection db)
    {
      _db = db;
    }

    public Primarch CreatePrimarch(Primarch primarch)
    {
      int id = _db.ExecuteScalar<int>(@"INSERT INTO primarch (img, name, orgin, flagship, isLoyal) VALUES (@Img, @Name, @Orgin, @Flagship, @Isloyal) SELECT LAST_INSERT_ID(); ");
      primarch.Id = id;
      return primarch;
    }

    public IEnumerable<Primarch> GetAllPrimarch()
    {
      return _db.Query<Primarch>("SELECT * FROM primarch");
    }
    public Primarch GetPrimarchById(int id)
    {
      try
      {
        return _db.QuerySingle<Primarch>("SELECT * FROM primarch WHERE id = @id", new { id });
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }
    public bool DeletePrimarchById(int id)
    {
      var compelete = _db.Execute("DELETE FROM primarch WHERE id = @id", new { id });
      return compelete > 0;
      {
        throw new Exception("failed to delete");
      }
    }

  }

}