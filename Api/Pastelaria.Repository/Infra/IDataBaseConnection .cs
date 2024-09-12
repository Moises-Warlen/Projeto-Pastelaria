﻿using System.Data;
using System.Data.SqlClient;

namespace Pastelaria.Repository.Infra
{
    public interface IDatabaseConnection
    {
        SqlConnection SqlConnection { get; }
        SqlTransaction SqlTransaction { get; }
        void OpenTransaction();
        void OpenTransaction(IsolationLevel isolationLevel);
        void Commit();
        void Rollback();
        void Dispose();
    }
}