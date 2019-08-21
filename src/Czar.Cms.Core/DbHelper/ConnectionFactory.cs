﻿using Czar.Cms.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Czar.Cms.Core.Extensions;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql;
using Dapper;

namespace Czar.Cms.Core.DbHelper
{
    /// <summary>
    /// yilezhu
    /// 2018.12.13
    /// 数据库连接工厂类
    /// </summary>
    public class ConnectionFactory
    {
        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="dbtype">数据库类型</param>
        /// <param name="conStr">数据库连接字符串</param>
        /// <returns>数据库连接</returns>
        public static IDbConnection CreateConnection(string dbtype, string strConn)
        {
            if (dbtype.IsNullOrWhiteSpace())
                throw new ArgumentNullException("获取数据库连接失败");
            if (strConn.IsNullOrWhiteSpace())
                throw new ArgumentNullException("获取数据库连接失败");
            var dbType = GetDataBaseType(dbtype);
            return CreateConnection(dbType, strConn);
        }

        /// <summary>
        /// 获取数据库连接
        /// </summary>
        /// <param name="dbType">数据库类型</param>
        /// <param name="conStr">数据库连接字符串</param>
        /// <returns>数据库连接</returns>
        public static IDbConnection CreateConnection(DatabaseType dbType, string strConn)
        {
            IDbConnection connection = null;
            if (strConn.IsNullOrWhiteSpace())
                throw new ArgumentNullException("获取数据库连接失败");

            switch (dbType)
            {
                case DatabaseType.SqlServer:
                    //设置sqlserver                    
                    connection = new SqlConnection(strConn);
                    SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLServer);
                    break;
                case DatabaseType.MySQL:
                    //设置mysql                   
                    connection = new MySqlConnection(strConn);
                    SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
                    break;
                case DatabaseType.PostgreSQL:
                    //设置PostgreSQL                    
                    connection = new NpgsqlConnection(strConn);
                    SimpleCRUD.SetDialect(SimpleCRUD.Dialect.PostgreSQL);
                    break;
                //case DatabaseType.Oracle:
                //    connection = new Oracle.ManagedDataAccess.Client.OracleConnection();                   
                    //break;
                default:
                    throw new ArgumentNullException($"还不支持的{dbType.ToString()}数据库类型");

            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        /// <summary>
        /// 转换数据库类型
        /// </summary>
        /// <param name="dbtype">数据库类型字符串</param>
        /// <returns>数据库类型</returns>
        public static DatabaseType GetDataBaseType(string dbtype)
        {
            if (dbtype.IsNullOrWhiteSpace())
                throw new ArgumentNullException("获取数据库连接失败");
            DatabaseType returnValue = DatabaseType.SqlServer;
            foreach (DatabaseType dbType in Enum.GetValues(typeof(DatabaseType)))
            {
                if (dbType.ToString().Equals(dbtype, StringComparison.OrdinalIgnoreCase))
                {
                    returnValue = dbType;
                    break;
                }
            }
            return returnValue;
        }


    }
}
