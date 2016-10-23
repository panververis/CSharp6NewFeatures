using CSharp6NewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6NewFeatures
{
    /// <summary>
    /// Static Class used for demonstrating C# 6 Static using Syntax
    /// </summary>
    static class CustomStaticClass
    {

        #region Class Methods

        public static string GetAHelloMessage()
        {
            return Resource1.sHelloMessage;
        }

        #endregion

    }
}
