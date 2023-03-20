﻿// <auto-generated/>

namespace Sample
{
partial interface ISample
{
    System.Threading.Tasks.ValueTask AcceptAsync<TArg1, TArg2, TArg3>(Sample.ISampleValueTaskVisitor3<TArg1, TArg2, TArg3> visitor, TArg1 arg1, TArg2 arg2, TArg3 arg3);
}
}

namespace Sample
{
partial interface ISampleValueTaskVisitor3<in TArg1, in TArg2, in TArg3>
{
    System.Threading.Tasks.ValueTask VisitAsync(Sample.Sample1 value, TArg1 arg1, TArg2 arg2, TArg3 arg3);
    System.Threading.Tasks.ValueTask VisitAsync(Sample.Sample2 value, TArg1 arg1, TArg2 arg2, TArg3 arg3);
    System.Threading.Tasks.ValueTask VisitAsync(Sample.Sample3 value, TArg1 arg1, TArg2 arg2, TArg3 arg3);
    System.Threading.Tasks.ValueTask VisitAsync(Sample.Sample4 value, TArg1 arg1, TArg2 arg2, TArg3 arg3);
}
}

namespace Sample
{
partial class Sample1: Sample.ISample
{
    async System.Threading.Tasks.ValueTask Sample.ISample.AcceptAsync<TArg1, TArg2, TArg3>(Sample.ISampleValueTaskVisitor3<TArg1, TArg2, TArg3> visitor, TArg1 arg1, TArg2 arg2, TArg3 arg3) => await visitor.VisitAsync(this, arg1, arg2, arg3);
}
}

namespace Sample
{
partial class Sample2: Sample.ISample
{
    async System.Threading.Tasks.ValueTask Sample.ISample.AcceptAsync<TArg1, TArg2, TArg3>(Sample.ISampleValueTaskVisitor3<TArg1, TArg2, TArg3> visitor, TArg1 arg1, TArg2 arg2, TArg3 arg3) => await visitor.VisitAsync(this, arg1, arg2, arg3);
}
}

namespace Sample
{
partial class Sample3: Sample.ISample
{
    async System.Threading.Tasks.ValueTask Sample.ISample.AcceptAsync<TArg1, TArg2, TArg3>(Sample.ISampleValueTaskVisitor3<TArg1, TArg2, TArg3> visitor, TArg1 arg1, TArg2 arg2, TArg3 arg3) => await visitor.VisitAsync(this, arg1, arg2, arg3);
}
}

namespace Sample
{
partial class Sample4: Sample.ISample
{
    async System.Threading.Tasks.ValueTask Sample.ISample.AcceptAsync<TArg1, TArg2, TArg3>(Sample.ISampleValueTaskVisitor3<TArg1, TArg2, TArg3> visitor, TArg1 arg1, TArg2 arg2, TArg3 arg3) => await visitor.VisitAsync(this, arg1, arg2, arg3);
}
}
