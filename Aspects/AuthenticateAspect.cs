using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using PostSharp.Aspects.Dependencies;
using PostSharp.Extensibility;

namespace AOPDemo.Aspects
{
    [Serializable]
    [ProvideAspectRole("Authenticate")]
    [AspectRoleDependency(AspectDependencyAction.Order, AspectDependencyPosition.Before, "Authorize")]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetMemberAttributes = MulticastAttributes.Instance)]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthenticateAspect : MethodInterceptionAspect
    {
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var security = new SecurityService();

            security.Authenticate();

            args.Proceed();
        }
    }
}
