using System;
using Dapper;
using System.Data;
using AstartesCodexProject.Models;
using System.Collections.Generic;

namespace AstartesCodexProject.Data
{
  public class LegionRepository
  {
    private readonly IDbConnection _db;
    public LegionRepository(IDbConnection db)
    {
      _db = db;
    }

    public Legion CreateLegion(Legion legion)
    {
      int id = _db.ExecuteScalar<int>
      (@"INSERT INTO legion (img, primarch, legionHomeWorld, legionStory, isLoyal, name) VALUES (@Img, @Primarch, @LegionHomeWorld, @LegionStory, @IsLoyal, @Name); SELECT LAST_INSERT_ID();", legion);
      legion.Id = id;
      return legion;
    }

    public IEnumerable<Legion> GetAllLegion()
    {
      try
      {
        return _db.Query<Legion>("SELECT * FROM legion");
      }
      catch (Exception e)
      {

        throw new Exception(e.Message);
      }
    }

    public Legion GetLegionById(int id)
    {
      try
      {
        return _db.QuerySingle<Legion>("SELECT * FROM legion WHERE id = @id", new { id });
      }
      catch (Exception e)
      {

        throw new Exception(e.Message);
      }
    }

    public bool DeleteLegionById(int id)
    {
      var complete = _db.Execute("DELETE FROM legion WHERE id = @id", new { id });
      return complete > 0;
      {
        throw new Exception("All Heretics Have Been Purged!");
      }
    }

  }

}