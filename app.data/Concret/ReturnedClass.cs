using System.Collections.Generic;

namespace app.data.Concret
{
    public class ReturnedClass<T> where T:class
    {
        public ReturnedClass()
        {
            values=new List<T>();
        }
        public ReturnedClass(OprationResult _oprationResult)
        {
            oprationResult=_oprationResult;
        }
        public ReturnedClass(OprationResult __oprationResult,int _id)
        {
            oprationResult=__oprationResult;
            number=_id;
        }
        public ReturnedClass(OprationResult _oprationResult,T _value)
        {
            oprationResult=_oprationResult;
            value=_value;
        }
        public ReturnedClass(OprationResult _oprationResult,List<T> _values)
        {
            values=new List<T>();
            oprationResult=_oprationResult;
            values=_values;
        }
        public OprationResult oprationResult{get;set;}
        public List<T> values { get; set; }
        public T value{get;set;}
        public int number{get;set;}
    }
}