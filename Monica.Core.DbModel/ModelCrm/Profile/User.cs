using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Monica.Core.DbModel.ModelCrm.Core;
using Monica.Core.DbModel.ModelDto;
using Monica.Core.DbModel.ModelDto.LevelOrg;

namespace Monica.Core.DbModel.ModelCrm.Profile
{
    /// <summary>
    /// Пользователи системы
    /// </summary>
    public class User : BaseModel
    {
        /// <summary>
        /// Уникальное имя пользователя
        /// </summary>
        [Required]
        public string Account { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Middlename { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Email адрес обязательно с подтверждением
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Тип пользователя. Игрок, Менеджер
        /// </summary>
        [ForeignKey("TypeUserId")]
        public TypeUser TypeUser { get; set; }

        /// <summary>
        /// Тип пользователя
        /// </summary>
        public int? TypeUserId { get; set; }

        public static implicit operator UserDto(User user)
        {
            var name = user.Name == null ? "" : user.Name;
            var surname = user.Surname == null ? "" : user.Surname;
            var middlename = user.Middlename == null ? "" : user.Middlename;
            return new UserDto()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Middlename = user.Middlename,
                Account = user.Account,
                FullName = $"{surname} {name} {middlename}",
                ShortName = $"{user.Surname} {user.Name}",
                Email = user.Email,
                Phone = user.Phone,
                TypeUserId = user.TypeUserId == null ? 0 : (int) user.TypeUserId,
                CreateDate = user.CreateDate
            };
        }
    }
}
