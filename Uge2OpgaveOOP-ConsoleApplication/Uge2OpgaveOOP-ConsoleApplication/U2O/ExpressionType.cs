using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2O
{
    public abstract class Expression<T>
    {
        public abstract T Evaluate();
    }

    public class ConstantExpression<T> : Expression<T>
    {
        private readonly T _value;

        public ConstantExpression(T value)
        {
            _value = value;
        }

        public override T Evaluate()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }
}

