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
  }
}