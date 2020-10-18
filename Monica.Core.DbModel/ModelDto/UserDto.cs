using System;
using Monica.Core.DbModel.ModelCrm.Profile;

namespace Monica.Core.DbModel.ModelDto
{
    public class UserDto 
    {
        
        /// <summary>
        /// Уникальный номер пользователя
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Аккаунт пользователя
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Короткое имя пользователя
        /// </summary>
        public string ShortName { get; set; }
        /// <summary>
        /// Электронная почта
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Тип пользователя
        /// </summary>
        public string TypeUser { get; set; }
        /// <summary>
        /// Тип пользователя
        /// </summary>
        public int TypeUserId { get; set; }
        /// <summary>
        /// Дата создания пользователя
        /// </summary>
        public DateTime? CreateDate { get; set; }


        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Middlename { get; set; }

        public static implicit operator User(UserDto dto)
        {
            var user = new User();
            user.Name = dto.Name;
            user.Surname = dto.Surname;
            user.Middlename = dto.Middlename;
            user.Id = dto.Id;
            user.Account = dto.Account;
            user.Email = dto.Email;
            user.Phone = dto.Phone;
            user.CreateDate = dto.CreateDate;
            if (dto.TypeUserId != 0)
            {
                user.TypeUserId = (int)dto.TypeUserId;
            }
            return user;
        }
    }
}
