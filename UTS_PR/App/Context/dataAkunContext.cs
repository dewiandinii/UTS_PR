using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTS_PR.App.Core;
//using UTS_PR.App.Models;

//namespace UTS_PR.App.Context
//{
//    //internal class dataAkunContext : DatabaseWrapper
    //{
    //    private static string table = "dataAkun";

//        public static DataTable All
//        {
//            get
//            {
//                string query = @"
//        SELECT 
//            m.id,
//            m.email,
//            m.password,
//        FROM 
//            dataAkun m

//            DataTable datadataAkun = queryExecutor(query);
//            return datadataAkun;
//    }

//    public static void AdddataAkun(M_DataAkun mahasiswaBaru)
//        {
//            string query = $""INSERT INTO {table} (email, password) VALUES(@email, @password)"";

//            NpgsqlParameter[] parameters =
//            {
//                new NpgsqlParameter(""@email"", dataAkunBaru.email),
//                new NpgsqlParameter(""@password"", dataAkunBaru.semester),
//            };

//            commandExecutor(query, parameters);
//        }
//}
//}