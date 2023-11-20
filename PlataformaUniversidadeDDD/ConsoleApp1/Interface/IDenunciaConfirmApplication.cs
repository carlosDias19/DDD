﻿using DDD.Domain.ReportRadarContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IDenunciaConfirmApplication
    {
        void DeleteDenunciaConfirm(int id);
        List<DenunciasConfirm> GetDenunciaConfirm();
        DenunciasConfirm GetDenunciaConfirmById(int id);
        void InsertDenunciaConfirm(DenunciasConfirm denunciaConfirm);
        void UpdateDenunciaConfirm(DenunciasConfirm denunciaConfirm);
    }
}
