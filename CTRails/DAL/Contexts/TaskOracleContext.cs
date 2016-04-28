using System;
using System.Collections.Generic;
using System.Linq;
using CTRails.Entities;
using Oracle.ManagedDataAccess.Client;


namespace CTRails.DAL.Contexts
{
    public class TaskOracleContext : OracleDatabaseContext, IDataContext<Task>
    {

        public TaskOracleContext()
            : base()
        {
            
        }

        public void Add(Task entity)
        {
            OpenConnection();

            string query = @"INSERT INTO TRM_SCHEDULE (EMPLOYEE_ID, TRAM_ID, DATE, ISDONE) VALUES(:employee, :tram, :date, :isdone)";

            try
            {
                ExecuteQuery(query,
                             new[]
                             {
                                 new OracleParameter("employee", entity.EmployeeID), new OracleParameter("tram", entity.TramID), new OracleParameter("date", entity.Date), new OracleParameter("isdone", entity.IsDone)
                             });
            }
            catch (Exception e) {}


            CloseConnection();
        }



        public void Delete(Task entity)
        {
            OpenConnection();
            
            string query = @"DELETE FROM TRM_SCHEDULE WHERE ID = :id";

            ExecuteQuery(query, new[] {
                new OracleParameter("id", entity.ID),
            });

            CloseConnection();
        }



        public void Update(Task entity)
        {
            OpenConnection();

            Task row = Get(entity.ID);

            OpenConnection();

            string query;
            string begin = @"UPDATE TRM_EMPLOYEE SET ";
            string end = @" WHERE ID = :id";

            if (row.EmployeeID != entity.EmployeeID)
            {
                query = begin + @"EMPLOYEE_ID = :employee" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("employee", entity.EmployeeID),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.TramID != entity.TramID)
            {
                query = begin + @"TRAM_ID = :tram" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("tram", entity.TramID),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.Date != entity.Date)
            {
                query = begin + @"DATE = :date" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("date", entity.Date),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }
            if (row.IsDone != entity.IsDone)
            {
                query = begin + @"ISDONE = :isdone" + end;
                try
                {
                    ExecuteQuery(query,
                                 new[]
                                 {
                                     new OracleParameter("isdone", entity.IsDone),
                                     new OracleParameter("id", entity.ID)
                                 });
                }
                catch (Exception e) { }
            }

            CloseConnection();
        }


        public IEnumerable<Task> Get()
        {
            OpenConnection();

            string query = @"SELECT * FROM TRM_SCHEDULE";

            List<Task> tasks = new List<Task>();

            try
            {
                OracleDataReader reader = ResultSet(query);

                UnitOfWork uow = new UnitOfWork();

                while (reader.Read())
                {
                    Task t = new Task(Convert.ToInt32(reader["ID"]), 
                        Convert.ToInt32(reader["EMPLOYEE_ID"]),
                        Convert.ToInt32(reader["TRAM_ID"]),
                        Convert.ToDateTime(reader["DATE"]), 
                        Convert.ToInt32(reader["ISDONE"]));

                    tasks.Add(t);
                }
            }
            catch (System.InvalidOperationException e)
            {
                Console.WriteLine("A connection could not be made.");
            }
            

            CloseConnection();

            return tasks;
        }

        public Task Get(int id)
        {
            OpenConnection();

            string query = @"SELECT * FROM TRM_SCHEDULE WHERE ID = :id";

            OracleDataReader reader = ResultSet(query, new[] {
                new OracleParameter("id", id)
            });

            Task result = null;

            while (reader.Read())
            {
                result = new Task(Convert.ToInt32(reader["ID"]),
                        Convert.ToInt32(reader["EMPLOYEE_ID"]),
                        Convert.ToInt32(reader["TRAM_ID"]),
                        Convert.ToDateTime(reader["DATE"]),
                        Convert.ToInt32(reader["ISDONE"]));
            }

            CloseConnection();

            return result;
        }

    }
}
