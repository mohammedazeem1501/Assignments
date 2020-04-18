using Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace SubtractionOperators
{
    public class SubtractionOperator
    {
        private double? _numericResult;
        private StringBuilder _stringResult;
        public SubtractionOperator()
        {
        }


        //subtraction for 2 numeric nnumbers
        public object Evaluate(List<object> data)
        {
            bool stringFound = false;
            bool numericFound = false;
            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                        _numericResult = Convert.ToDouble(value);
                    else
                    {
                        _numericResult = _numericResult.Value - Convert.ToDouble(value);
                    }
                    
                }

                else
                {
                    throw new ArgumentException($"Non numeric or string value encountered");
                }
            }

            if (_numericResult != null)
                result = _numericResult.Value;
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(SubtractionOperator)}");
            }
            return result;
        }
    }
}
