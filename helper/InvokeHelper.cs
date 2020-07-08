using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSpector.helper
{
    public class InvokeHelper
    {
        public static object InvokeWebElement(String className, String methodName, object[] parametersArray = null)
        {
            // Get a type from the string 
            Type type = Type.GetType(className);
            // Create an instance of that type
            Object obj = Activator.CreateInstance(type);
            // Retrieve the method you are looking for
            MethodInfo methodInfo = type.GetMethod(methodName);
            // Invoke the method on the instance we created above
            ParameterInfo[] parameters = methodInfo.GetParameters();
            if (parametersArray == null)
            {
               return methodInfo.Invoke(obj, null);
            }
            else
            {
                //https://stackoverflow.com/questions/2202381/reflection-how-to-invoke-method-with-parameters
                // The invoke does NOT work;
                // it throws "Object does not match target type"            
                return methodInfo.Invoke(obj, parametersArray);
            }

        }

    }
}
