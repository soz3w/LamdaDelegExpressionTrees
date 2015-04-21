using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

//using system.linq.expressions


namespace LamdaDelegExpressionTrees
{
    class Program
    {

        public delegate double CalAreaPointer(int r);

        
        static void Main(string[] args)
        {
            //Expression trees
            //(10+20)-(5+3)

            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(10), Expression.Constant(20));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(5), Expression.Constant(3));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, b1, b2);

            int result = Expression.Lambda<Func<int>>(b3).Compile()();

            Console.WriteLine(result);

            //usage translate english to code, linq/sql, ...
            
            Console.ReadKey();
        }


    }
}
