using Bsam.Cores;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Bsam.Core.Common.DB
{
    public class BaseDBConfig
    {
        /* 之前的单库操作已经删除，如果想要之前的代码，可以查看我的GitHub的历史记录
         * 目前是多库操作，默认加载的是appsettings.json设置为true的第一个db连接。
         */
        public static List<MutiDBOperate> MutiConnectionString => MutiDBConnInit();

        /// <summary>
        /// 初始化DB连接对象
        /// </summary>
        /// <returns></returns>
        public static List<MutiDBOperate> MutiDBConnInit()
        {
            var path = "appsettings.json";

            List < MutiDBOperate > listdatabase = new List<MutiDBOperate>();
            // 从配置项文件 appsettings.json 中获取节点 DBS 配置的数据库连接信息
            using (var streamReader = new StreamReader(path))
            {
                using (var jsonReader = new JsonTextReader(streamReader))
                {
                    var jObj = (JObject)JToken.ReadFrom(jsonReader);
                    var dbsNode = jObj["DBS"];
                    if (dbsNode != null)
                    {
                        for (int i = 0; i < dbsNode.Count(); i++)
                        {
                            var dbOperation = new MutiDBOperate() { 
                                Conn = dbsNode[i]["Connection"].ObjToString(),
                                ConnId = dbsNode[i]["ConnId"].ObjToString(),
                                DbType = (DataBaseType)(dbsNode[i]["DBType"].ObjToInt()),
                            };

                            listdatabase.Add(SpecialDbString(dbOperation));
                        }
                    }
                }
                return listdatabase;
            }

        }

        /// <summary>
        /// 如果系统有指定文件指定新的db连接方式，则采用文件的，否则采用代码的配置文件的
        /// </summary>
        /// <param name="mutiDBOperate"></param>
        /// <returns></returns>
        private static MutiDBOperate SpecialDbString(MutiDBOperate mutiDBOperate)
        {
            if (mutiDBOperate.DbType == DataBaseType.Sqlite)
            {
                mutiDBOperate.Conn = $"DataSource=" + Path.Combine(Environment.CurrentDirectory, mutiDBOperate.Conn);
            }
            else if (mutiDBOperate.DbType == DataBaseType.SqlServer)
            {
                mutiDBOperate.Conn = DifDBConnOfSecurity(@"D:\my-file\dbCountPsw1.txt", @"c:\my-file\dbCountPsw1.txt", mutiDBOperate.Conn);
            }
            else if (mutiDBOperate.DbType == DataBaseType.MySql)
            {
                mutiDBOperate.Conn = DifDBConnOfSecurity(@"D:\my-file\dbCountPsw1_MySqlConn.txt", @"c:\my-file\dbCountPsw1_MySqlConn.txt", mutiDBOperate.Conn);
            }
            else if (mutiDBOperate.DbType == DataBaseType.Oracle)
            {
                mutiDBOperate.Conn = DifDBConnOfSecurity(@"D:\my-file\dbCountPsw1_OracleConn.txt", @"c:\my-file\dbCountPsw1_OracleConn.txt", mutiDBOperate.Conn);
            }

            return mutiDBOperate;
        }

        /// <summary>
        /// 从指定文件路径读取连接字符串内容，如果都没有，就返回最后一个（参数）
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        private static string DifDBConnOfSecurity(params string[] conn)
        {
            foreach (var item in conn)
            {
                try
                {
                    if (File.Exists(item))
                    {
                        return File.ReadAllText(item).Trim();
                    }
                }
                catch (System.Exception) { }
            }

            return conn[conn.Length - 1];
        }

    }


    /// <summary>
    /// 数据库类型
    /// </summary>
    public enum DataBaseType
    {
        MySql = 0,
        SqlServer = 1,
        Sqlite = 2,
        Oracle = 3,
        PostgreSQL = 4
    }
    /// <summary>
    /// 数据库对象
    /// </summary>
    public class MutiDBOperate
    {
        public string ConnId { get; set; }
        public string Conn { get; set; }
        public DataBaseType DbType { get; set; }
    }
}
