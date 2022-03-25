﻿using League.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace League.Service.Interfaces
{
    public interface IHistoricDetailService
    {
        Task<HistoricDetail> GetHistoricDetails(string match);
    }
}
