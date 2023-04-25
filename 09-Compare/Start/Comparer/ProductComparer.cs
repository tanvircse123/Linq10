using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LINQSamples;
namespace Start.Comparer
{
    public class ProductComparer:EqualityComparer<Product>
    {
        // override object.Equals
        public override bool Equals(Product x ,Product y)
        {
           return x.ProductID == y.ProductID &&
                 x.Name == y.Name &&
                 x.Color == y.Color &&
                 x.Size == y.Size;
        }
        
        // override object.GetHashCode
        public override int GetHashCode(Product obj)
        {
            // TODO: write your implementation of GetHashCode() here
            
            string value = obj.ProductID.ToString()+obj.Name+obj.Color+obj.Size.ToString();
            return value.GetHashCode();
            
        }
    }
}