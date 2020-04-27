﻿using Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace EqualToOperator
{
    public class EqualToOperator
    {
        private double? _numericResult;
        private bool? _numericResultBool=false;
        private string _stringResult;
        private bool? _stringResultbool=false;

        public EqualToOperator()
        {
        }


        // comparision of two inputs(string, integers).....................!@@
        public object Evaluate(List<object> data)
        {

            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                    {
                        _numericResult = Convert.ToDouble(value);
                    }
                    else
                    {
                        if (_numericResult.Value == Convert.ToDouble(value))
                        {
                            _numericResultBool = true;
                            continue;
                        }
                        else
                        {
                            _numericResultBool = false;
                            break;
                        }
                    }   



                }
                else if (value.IsString())
                {
                    if (_stringResult == null)
                    {

                        _stringResult = Convert.ToString(value);
                    }
                    else
                    {
                        if (String.Equals(_stringResult,Convert.ToString(value)))
                            
                        {
                            _stringResultbool = true;
                            continue;
                        }
                        else
                        {
                            _stringResultbool = false;
                            break;
                        }
                        
                    }
                }
                else
                {
                    throw new ArgumentException($"Non numeric or string value encountered");
                }
            }

            if (_numericResultBool != null)
                result = _numericResultBool;
            else if (_stringResultbool != null)
            {
                result = _stringResultbool;
            }
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(EqualToOperator)}");
            }
            return result;
        }
    }
}
