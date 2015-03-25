using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace AOPDemo.Aspects
{
    [Serializable]
    public class LoggingAspect : OnMethodBoundaryAspect
    {
        public override void OnEntry(MethodExecutionArgs args)
        {
            var logger = new LoggerService();

            logger.Log(string.Format(
                "- {0}.{1} method invoked with: {2}",
                args.Instance.GetType().FullName,
                args.Method.Name,
                string.Join(",", args.Arguments)));

        }

        public override void OnException(MethodExecutionArgs args)
        {
            base.OnException(args);
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            base.OnExit(args);
        }

        public override void OnResume(MethodExecutionArgs args)
        {
            base.OnResume(args);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            var logger = new LoggerService();

            logger.Log(string.Format(
                    "+ {0}.{1} method completed returning: {2}",
                    args.Instance.GetType().FullName,
                    args.Method.Name,
                    args.ReturnValue));
        }

        public override void OnYield(MethodExecutionArgs args)
        {
            base.OnYield(args);
        }
    }
}
