using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Monica.Core.Abstraction.Crm;
using Monica.Core.Abstraction.ReportEngine;
using Monica.Core.DbModel.ModelCrm;
using Monica.Core.DbModel.ModelCrm.Core;
using Monica.Core.DbModel.ModelsAuth;

namespace Monica.Core.Service.ReportEngine.Actions
{
    public class ActionReplaceDateFromModel : IActionBtnFormModel
    {
        private readonly IManagerClients _managerClients;
        private readonly ClientDbContext _clientDbContext;

        public ActionReplaceDateFromModel(IManagerClients managerClients, ClientDbContext clientDbContext)
        {
            _managerClients = managerClients;
            _clientDbContext = clientDbContext;
        }

        public async Task<ResultCrmDb> Action(ActionArgs obj, string userName, int formId, int[] modelIds)
        {
            var user = await _clientDbContext.User.FirstOrDefaultAsync(f => f.Account == userName);
            var clientProduct = await _clientDbContext.ClientProduct.Include(c => c.Client).FirstOrDefaultAsync(f => modelIds.Contains(f.Id));
            await _managerClients.CallAgainProduct(user?.Id ?? 0, clientProduct.Client?.Id ?? 0, obj.OtherInfo);
            return new ResultCrmDb();
        }
    }
}
