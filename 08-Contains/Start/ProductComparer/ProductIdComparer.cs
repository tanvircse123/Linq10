using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using LINQSamples;

namespace Start.ProductComparer
{
    // we create a custom comparer class
    // this class is used in contains() method
    // this class will show how we can comparer two object
    // of product and find a  match
    // although it can do with a where cluase
    
    public class ProductIdComparer:EqualityComparer<Product>{
        public override bool Equals(Product x,Product y){
            // we compare with the product id
            return x.ProductID == y.ProductID;
        }

        // you also need to override the get hash method
        // since the object are reference thats why we need to find the getHash Code 
        public override int GetHashCode(Product obj)
        {
            return obj.ProductID.GetHashCode();
        }
    }
    
}