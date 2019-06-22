using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation)
        {
        }
        protected virtual void OnAfter(IInvocation invocation)
        {
        }
        protected virtual void OnException(IInvocation invocation)
        {
        }
        protected virtual void OnSuccess(IInvocation invocation)
        {
        }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            this.OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception)
            {
                isSuccess = false;
                this.OnException(invocation);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    this.OnSuccess(invocation);
                }
            }
            this.OnAfter(invocation);
        }
    }
}
