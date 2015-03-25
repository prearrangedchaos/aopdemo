using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace AOPDemo.Aspects
{
    [Serializable]
    public class ExceptionHandlerAspect : OnExceptionAspect
    {
        public override void OnException(MethodExecutionArgs args)
        {
            var logger = new LoggerService();

            logger.Log(string.Format(
                                "! Exception in {0}.{1} method: {2}",
                                args.Instance.GetType().FullName,
                                args.Method.Name,
                                args.Exception));
            throw args.Exception;
        }
    }
}
