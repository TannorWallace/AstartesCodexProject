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
    //Ok Set Up the SQL TABELS NEXT
  }

}