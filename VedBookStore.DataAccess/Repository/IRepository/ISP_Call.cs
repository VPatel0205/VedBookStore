﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace VedBookStore.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters param = null);
        void Execute(string procedurename, DynamicParameters param = null);
        T OneRecords<T>(string procedurename, DynamicParameters param = null);

        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
