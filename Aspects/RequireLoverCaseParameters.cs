using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PostSharp;
using PostSharp.Constraints;
using PostSharp.Extensibility;

namespace AOPDemo.Aspects
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, Inheritance = MulticastInheritance.Multicast)]
    public class RequireLoverCaseParameters : ScalarConstraint
    {
        public override void ValidateCode(object target)
        {
            MethodInfo targetMethod = (MethodInfo)target;

            foreach (var parameter in targetMethod.GetParameters())
            {
                if (!char.IsLower(parameter.Name[0]))
                    Message.Write(
                        MessageLocation.Of(target),
                        SeverityType.Error,
                        "4000",
                        "Parameter {0} with upper case in {1}",
                        parameter.Name,
                        targetMethod.Name);
            }
        }
    }
}
