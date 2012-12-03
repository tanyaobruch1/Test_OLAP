using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ICalculatorService" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double AddDouble(double a, double b);
    }
}
