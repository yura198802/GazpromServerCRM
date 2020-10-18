using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Monica.Core.DbModel.ModelCrm.Core;
using Monica.Core.DbModel.ModelsAuth;

namespace Monica.Core.Abstraction.ReportEngine
{
    public interface IActionBtnFormModel
    {
        Task<ResultCrmDb> Action(ActionArgs obj, string userName, int formId, int[] modelIds);
    }
}
