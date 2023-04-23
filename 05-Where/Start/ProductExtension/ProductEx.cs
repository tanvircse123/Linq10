using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LINQSamples;

namespace Start.ProductExtension
{
    public static class ProductEx
    {
        public static IEnumerable<Product> ByColor(this IEnumerable<Product>query,string color){
            return query.Where(s=>s.Color==color);
        }
    }
}