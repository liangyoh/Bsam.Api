using Bsam.Core.Common;
using Bsam.Core.Common.DB;
using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bsam.Api.Extensions
{
    public static class SqlsugarSetup
    {
        /// <summary>
        /// 添加SqlSugar启动服务
        /// </summary>
        /// <param name="services"></param>
        public static void AddSqlSugarSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // 设置默认的主数据库
            MainDb.CurrentDbConnId = Appsettings.app("MainDB");

            // 注入SqlSugar（接口）服务，这里必须采用Scope，因为有事务操作
            services.AddScoped<ISqlSugarClient>(o=>
            {
                var listConfig = new List<ConnectionConfig>();
                BaseDBConfig.MutiConnectionString.ForEach(m =>
                {

                    listConfig.Add(new ConnectionConfig()
                    {
                        ConfigId = m.ConnId.ObjToString().ToLower(),
                        ConnectionString = m.Conn,
                        DbType = (DbType)m.DbType,
                        IsAutoCloseConnection = true,
                        IsShardSameThread = false,
                        AopEvents = new AopEvents
                        {
                            OnLogExecuting = (sql, p) =>
                            {
                                // 多库操作的话，此处暂时无效果，在另一个地方有效，具体请查看BaseRepository.cs
                            }
                        },
                        MoreSettings = new ConnMoreSettings()
                        {
                            IsAutoRemoveDataCache = true
                        }
                        //InitKeyType = InitKeyType.SystemTable
                    }
                   );
                });

                return new SqlSugarClient(listConfig);

            });
        }
    }
}
