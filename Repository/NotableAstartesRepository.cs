using System;
using Dapper;
using System.Data;
using AstartesCodexProject.Models;
using System.Collections.Generic;

namespace AstartesCodexProject.Data
{
  public class NotableAstartesRepository
  {
    private readonly IDbConnection _db;
    public NotableAstartesRepository(IDbConnection db)
    {
      _db = db;
    }

    public NotableAstartes CreateNotableAstartes(NotableAstartes notableAstartes)
    {
      int id = _db.ExecuteScalar<int>
      (@"INSERT INTO notableAstartes (img, name, story, legion, primarch, isLoyal) VALUES (@Img, @Name, @Story, @Legion, @Primarch, @IsLoyal); SELECT LAST_INSERT_ID();", notableAstartes);
      notableAstartes.Id = id;
      return notableAstartes;
    }
  }
}