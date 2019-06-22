using System;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;

namespace Core.Aspects
{
    public class TestAspect : MethodInterception
    {
        public TestAspect()
        {
        }

        protected override void OnBefore(IInvocation invocation)
        {
          // Test aspect
          // Aspect code...
        }
    }
}
