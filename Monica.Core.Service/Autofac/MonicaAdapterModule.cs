using Autofac;
using Monica.Core.Abstraction.Crm;
using Monica.Core.Abstraction.LoadInfo;
using Monica.Core.Abstraction.Registration;
using Monica.Core.Abstraction.Transactions;
using Monica.Core.Attributes;
using Monica.Core.Service.Crm;
using Monica.Core.Service.LoadInfo;
using Monica.Core.Service.Registration;
using Monica.Core.Service.Transactoins;

namespace Monica.Core.Service.Autofac
{
    /// <summary>
    /// Модуль автофака
    /// </summary>
    [CommonModule]
    public class MonicaAdapterModule : Module
    {
        /// <summary>
        /// загрузить записимости
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegistrationUserAdapter>().As<IRegistrationUserAdapter>();
            builder.RegisterType<WriterInfoClient>().As<IWriterInfoClient>();
            builder.RegisterType<WriterInfoTransaction>().As<IWriterInfoTransaction>();
            builder.RegisterType<ManagerClients>().As<IManagerClients>();
            builder.RegisterType<TransactionDataAdapter>().As<ITransactionDataAdapter>();
        }
    }
}
