using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2O
{
    interface IExpression {
        double Evaluate();
    }

    public abstract class Expression:IExpression
    {
        public abstract double Evaluate();
    }

    public sealed class ConstantExpression : Expression
    {
        private readonly double _value;

        public ConstantExpression(double value)
        {
            _value = value;
        }

        public override double Evaluate()
        {
            return _value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }
    }

    public abstract class BinaryExpression : Expression
    {
        protected Expression left { get; set; }
        protected Expression right { get; set; }

        public abstract string OperatorSymbol { get; }

        public sealed override string ToString()
        {
            return String.Format("({0} {1} {2})", left, OperatorSymbol, right);
        }
    }

    public class PlusExpression : BinaryExpression
    {
        public PlusExpression(Expression Expression1, Expression Expression2)
        {
            left = Expression1;
            right = Expression2;
        }

        public override double Evaluate()
        {
            return left.Evaluate() + right.Evaluate();
        }

        public override string OperatorSymbol
        {
            get
            {
                return "+";
            }
        }
    }

    class MinusExpression : BinaryExpression
    {

        public MinusExpression(Expression Expression1, Expression Expression2)
        {
            left = Expression1;
            right = Expression2;
        }

        public override double Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }

        public override string OperatorSymbol
        {
            get
            {
                return "-";
            }
        }
    }

    class MultiplyExpression : BinaryExpression
    {
        public MultiplyExpression(Expression Expression1, Expression Expression2)
        {
            left = Expression1;
            right = Expression2;
        }
        public override double Evaluate()
        {
            return left.Evaluate() * right.Evaluate();
        }

        public override string OperatorSymbol
        {
            get
            {
                return "*";
            }
        }
    }

    abstract class UnaryExpression : Expression
    {
        protected Expression expr;
    }

    class NegateExpression : UnaryExpression
    {
     
        public NegateExpression(Expression v)
        {
            this.expr = v;
        }

        public override double Evaluate()
        {
            return -expr.Evaluate();
        }

        public override string ToString()
        {
            return "-" + expr.ToString();
        }
    }

}
