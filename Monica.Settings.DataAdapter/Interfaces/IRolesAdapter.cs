﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Monica.Settings.DataAdapter.Models.Crm.Core;
using Monica.Settings.DataAdapter.Models.Dto;

namespace Monica.Settings.DataAdapter.Interfaces
{
    public interface IRolesAdapter
    {
        /// <summary>
        /// Метод возвращающий роли для организаций
        /// </summary>
        /// <param name="levelOrg"></param>
        /// <returns></returns>
        Task<IEnumerable<UserRoleDto>> GetRolesByLevelOrgAsync(int idOrg);
        /// <summary>
        /// Метод добавления роли для выбранной организации
        /// </summary>
        /// <param name="levelOrg"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<ResultCrmDb> AddRoleForLevelOrgAsync(RoleCreateArgs args);
        /// <summary>
        /// Метод изменения названия выбранной роли
        /// </summary>
        /// <param name="sysIdRole"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        Task<ResultCrmDb> EditUserRoleAsync(int sysIdRole, string newName);
        /// <summary>
        /// Метод удаления выбранной роли
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<ResultCrmDb> RemoveUserRoleAsync(int idRole);

    }
}
