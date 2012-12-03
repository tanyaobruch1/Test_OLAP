using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService2
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "CalculatorService" в коде и файле конфигурации.
    public class CalculatorService : ICalculatorService
    {
       public double AddDouble(double a, double b)
        {
            return a + b;
        }
    }
}
