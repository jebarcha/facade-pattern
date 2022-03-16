using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallOfMud.Services
{
    internal class BigClassFacade
    {
        private BigClass _bigClass;

        public BigClassFacade(BigClass bigClass)
        {
            _bigClass = bigClass;
            _bigClass.SetValueI(0);
        }
        public void IncreaseBy(int numberToAdd)
        {
            _bigClass.AddToI(numberToAdd);
        }
        public void DecreaseBy(int numberToSubstract)
        {
            _bigClass.AddToI(-numberToSubstract);
        }
        public int GetCurrentValue()
        {
            return _bigClass.GetValueA();
        }
    }
}
