using Autofac;
using Monica.Core.Abstraction.Profile;
using Monica.Core.Abstraction.ReportEngine;
using Monica.Core.Attributes;
using Monica.Core.DbModel.ModelCrm.Client;
using Monica.Core.Service.Profile;
using Monica.Core.Service.ReportEngine;
using Monica.Core.Service.ReportEngine.Actions;

namespace Monica.CrmDbModel.Autofac
{
    /// <summary>
    /// Модуль IoC контейнера
    /// </summary>
    [CommonModule]
    public class MonicaDataBaseWorkingModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Загрузить работу с профилями пользователей
            builder.RegisterType<ManagerProfile>().As<IManagerProfile>();
            // Загрузить работу с доступом
            builder.RegisterType<AccessManager>().As<IAccessManager>();
            // Загрузить работу с данными
            builder.RegisterType<ReportData>().As<IReportData>();
            //Менеджер управления режимами
            builder.RegisterType<ReportManager>().As<IReportManager>();
            // Загрузить генератор данных под структуру MySql
            builder.RegisterType<GenerateFieldMySql>().Named<IGenerateField>(nameof(GenerateFieldMySql));
            //Менеджер получение объектов БД
            builder.RegisterType<ConnectorManager>().As<IConnectorManager>();
            //Регистрация сервиса формированрия данных для конструктора по умолчанию
            builder.RegisterType<ReportEngineDefaultData>().Named<IReportEngineData>(nameof(ReportEngineDefaultData));
            builder.RegisterType<ReportClientData>().Named<IReportEngineData>(nameof(ReportClientData));
            builder.RegisterType<ReportClientProductData>().Named<IReportEngineData>(nameof(ReportClientProductData));
            builder.RegisterType<ReportManagerData>().Named<IReportEngineData>(nameof(ReportManagerData));
            builder.RegisterType<ActionReplaceDateFromModel>().Named<IActionBtnFormModel>("AcceptedClientProductDate");
            builder.RegisterType<ActionAcceptedFromModel>().Named<IActionBtnFormModel>("AcceptedClientProduct");
            builder.RegisterType<ActionNotAcceptedFromModel>().Named<IActionBtnFormModel>("NotAcceptedClientProduct");
            builder.RegisterType<ActionReplaceDateFromModel>().Named<IActionBtnFormModel>("AcceptedClientProductDate");
            //Регистрация генератора колонок по умолчанию
            builder.RegisterType<ColumnCreater>().As<IColumnCreater>();
            //Регистрация генератора кнопок по умолчанию
            builder.RegisterType<ButtonCreater>().As<IButtonCreater>();
        }
    }
}
