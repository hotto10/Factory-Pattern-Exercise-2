﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType.ToLower())
            {
                case "list":
                case "regular":
                    return new ListDataAccess();

                case "mysql":
                case "sql":
                case "my":
                    return new SQLDataAccess();

                case "mongob":
                case "mongo":
                    return new MongoDataAccess();

                default:
                    return new ListDataAccess();
            }
        }
    }
}
