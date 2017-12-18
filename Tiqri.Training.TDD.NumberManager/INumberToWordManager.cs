using System.Collections.Generic;

namespace Tiqri.Training.TDD.NumberManager
{
    public interface INumberToWordManager
    {
        IList<string> Convert(List<int> numbers);
    }
}