using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UkrHistoryService1
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IUkrHistoryService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IUkrHistoryService
    {
        [OperationContract]
        string FindEvents(string a);
    }
}
