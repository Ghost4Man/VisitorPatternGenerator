# VisitorPatternGenerator
[![GitHub](https://img.shields.io/github/license/Ghost4Man/VisitorPatternGenerator)](https://github.com/Ghost4Man/VisitorPatternGenerator/tree/master/LICENSE)
[![Nuget](https://img.shields.io/nuget/v/Ghost4Man.VisitorPatternGenerator)](https://www.nuget.org/packages/Ghost4Man.VisitorPatternGenerator/)
[![Nuget](https://img.shields.io/nuget/dt/Ghost4Man.VisitorPatternGenerator)](https://www.nuget.org/packages/Ghost4Man.VisitorPatternGenerator/)

C# Roslyn (incremental) source generator to help implement the visitor design pattern.

## Fork

This fork (of [Rekkonnect's fork](https://github.com/Rekkonnect/VisitorPatternGenerator) of [hikarin522/VisitorPatternGenerator](https://github.com/hikarin522/VisitorPatternGenerator/)) adds support for `record` types.

## Usage

Example of simple integer expressions:

```cs
partial interface IExpr;
[Acceptor<IExpr>] partial record NumberLiteral(int Value) : IExpr;
[Acceptor<IExpr>] partial record BinaryOperation(IExpr Left, char Operator, IExpr Right) : IExpr;
[Acceptor<IExpr>] partial record FunctionCall(string Function, IExpr[] Args) : IExpr;

[Visitor<IExpr>] partial interface IExprVisitor<out TResult>;
[Visitor<IExpr>] partial interface IExprVisitor<in TArg, out TResult>;
[Visitor<IExpr>(voidReturn: true)] partial interface IExprVoidVisitor;
[Visitor<IExpr>(voidReturn: true)] partial interface IExprVoidVisitor<in TArg>;
```

and a visitor that evaluates them:

```cs
class ExpressionEvaluator : IExprVisitor<int>
{
    public int Visit(NumberLiteral expr) => expr.Value;

    public int Visit(BinaryOperation expr) => expr.Operator switch {
        '+' => expr.Left.Accept(this) + expr.Right.Accept(this),
        '*' => expr.Left.Accept(this) * expr.Right.Accept(this),
    };

    public int Visit(FunctionCall expr) => expr switch {
        ("max", [IExpr a, IExpr b]) => Math.Max(a.Accept(this), b.Accept(this)),
    };
}
```

used like this:

```cs
IExpr expr = new FunctionCall("max", [
    new NumberLiteral(0),
    new BinaryOperation(new NumberLiteral(40), '+', new NumberLiteral(2))
]);
var visitor = new ExpressionEvaluator();
Console.WriteLine($"Result: {expr.Accept(visitor)}");
```

For more samples, see <https://github.com/hikarin522/VisitorPatternGenerator/tree/master/Sample/>
