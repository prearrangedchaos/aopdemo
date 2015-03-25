using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;
using PostSharp.Aspects.Dependencies;

namespace AOPDemo.Aspects
{
    [Serializable]
    [ProvideAspectRole("Authorize")]
    public class AuthorizeAspect : MethodInterceptionAspect
    {
        private readonly Permission _permission;

        public AuthorizeAspect(Permission permission)
        {
            _permission = permission;
        }

        public override void OnInvoke(MethodInterceptionArgs args)
        {
            var security = new SecurityService();
            security.Authorize(this._permission);

            args.Proceed();
        }
    }
}
