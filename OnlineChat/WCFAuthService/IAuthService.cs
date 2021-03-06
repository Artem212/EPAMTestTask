using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFAuthService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract(Name = "IAuthService")]
    public interface IAuthService
    {
        [OperationContract(Name = "GetLogin")]
        string GetLogin(int cookieId);

        [OperationContract(Name = "SaveLogin")]
        int SaveLogin(string login);
    }
}
