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

    internal object GetAllNotableAstartes()
    {
      try
      {
        return _db.Query<NotableAstartes>("SELECT * FROM notableAstartes");
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }

    }

    public NotableAstartes GetNotableAstartesById(int id)
    {
      try
      {

        return _db.QuerySingle<NotableAstartes>("SELECT *FROM notableAstartes WHERE id = @id", new { id });

      }
      catch (Exception e)
      {

        throw new Exception(e.Message);
      }
    }

    public bool DeleteNotableAstartesById(int id)
    {
      var complete = _db.Execute("DELETE FROM notableAstartes WHERE id = @id", new { id });
      return complete > 0;
      {
        throw new Exception("Only in death does duty end!");
      }
    }
  }
}