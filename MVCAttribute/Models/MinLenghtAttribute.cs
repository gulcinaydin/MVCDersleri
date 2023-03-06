using System;

namespace MVCAttribute.Models
{
    internal class MinLenghtAttribute : Attribute
    {
        public MinLenghtAttribute(int v, string ErrorMassage)
        {
            this.ErrorMassage = ErrorMassage;
        }

        public string ErrorMassage { get; set; }
    }
}