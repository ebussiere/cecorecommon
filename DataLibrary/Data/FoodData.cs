﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Db;
using DataLibrary.Db.Models;

namespace DataLibrary.Data
{
    public class FoodData : IFoodData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;

        public FoodData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public Task<List<FoodModel>> GetFood()
        {
            return _dataAccess.LoadData<FoodModel, dynamic>("dbo.spFood_all", new { },
                _connectionString.SqlConnectionName);
        }
    }
}
