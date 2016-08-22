using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace U2O.Test
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void ConstantExpressionEvaluateRetunsIs4()
        {
            ConstantExpression constantExpression = new ConstantExpression(4);

            var evaluate = constantExpression.Evaluate();

            Assert.AreEqual(evaluate, 4);
        }


        [TestMethod]
        public void PlusExpressionEvaluateReturns()
        {
            Expression expr = new PlusExpression(new ConstantExpression(2),
                new ConstantExpression(2));

            Assert.AreEqual(expr.Evaluate(), 4);

        }
       
    }
}
