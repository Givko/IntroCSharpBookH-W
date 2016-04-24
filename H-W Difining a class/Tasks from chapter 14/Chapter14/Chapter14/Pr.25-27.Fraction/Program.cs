using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Pr._25_27.Fraction
{
    class Fraction
    {
        private int fractionNumerator;
        private int fractionDenominator;

        private Fraction(int fractionNumerator, int fractionDenominator)
        {
            try
            {
                if(fractionDenominator==0)
                {
                    throw new DivideByZeroException();
                }                
                else
                {
                this.fractionNumerator = fractionNumerator;
                this.fractionDenominator = fractionDenominator;
                }
            }           
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occured!");
            }                  
        }

        /// <summary>
        /// Returns the decimal value from this fraction.
        /// </summary>
        public string DecimalValue
        {
            get
            {                
                decimal decimalValue=Math.Round(this.fractionNumerator / (decimal)this.fractionDenominator,2);
                return  "("+decimalValue.ToString("0.00")+")";
            }
        }

        public int FractionNumerator 
        { 
            get
            {
                return this.fractionNumerator;
            }
            private  set
             {
                 this.fractionNumerator=value;
             }
        }

        public int FractionDenominator
        { 
            get
            {
                return this.fractionDenominator;
            }
            private set
             {
                 if (value == 0)
                 {
                     throw new DivideByZeroException("Division by zero!");
                 }
                 else
                 {
                     this.fractionDenominator = value;
                 }
             }
        }
        /// <summary>
        /// Greatest common divisor by Euclidian algorithm (with recursion)
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        private static int GreatestCommonDivisor(int firstNumber, int secondNumber)
        {
            if (firstNumber != 0)
            {
                int num1 = Math.Abs(firstNumber);
                int num2 = Math.Abs(secondNumber);
                if (num1 != num2)
                {
                    if (num1 > num2)
                    {
                        return GreatestCommonDivisor(num1 - num2, num2);
                    }
                    else
                    {
                        return GreatestCommonDivisor(num1, num2 - num1);
                    }
                }
                return num1;
            }
            else
            {
                return secondNumber;
            }
        }
        /// <summary>
        /// The least common multiple
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>

       private static int TheLeastCommonMultiple(int firstNumber, int secondNumber)
        {
            
            return firstNumber*secondNumber/(GreatestCommonDivisor(firstNumber,secondNumber));

        }

        /// <summary>
        /// Alows to find the Sum of two fractions
        /// </summary>
        /// <param name="a"> first fraction</param>
        /// <param name="b">second fraction</param>
        /// <returns></returns>
       public  static Fraction operator +(Fraction a, Fraction b)
        {

            int denominator = TheLeastCommonMultiple(a.fractionDenominator, b.fractionDenominator);

            int numerator = a.fractionNumerator*denominator/a.fractionDenominator + b.fractionNumerator*denominator/b.fractionDenominator;



            Fraction newFraction = new Fraction(numerator, denominator);
          //  newFraction.Simplification();
            Simplification(newFraction);

            return newFraction;
        }
       /// <summary>
       /// Alows to substract second fraction from first 
       /// </summary>
       /// <param name="a"> first fraction</param>
       /// <param name="b">second fraction</param>
       /// <returns></returns>

       public static Fraction operator -(Fraction a, Fraction b)
       {


           int denominator = TheLeastCommonMultiple(a.fractionDenominator, b.fractionDenominator);

           int numerator = a.fractionNumerator * denominator / a.fractionDenominator - b.fractionNumerator * denominator / b.fractionDenominator;



           Fraction newFraction = new Fraction(numerator, denominator);
           Simplification(newFraction);
           return newFraction;
       }
        /// <summary>
        /// Allows simplifikation of fraction
        /// </summary>
        private static void Simplification(Fraction fract)
        {
                        
           int commonDivisor= GreatestCommonDivisor(fract.FractionNumerator, fract.FractionDenominator);

           fract.fractionNumerator = fract.fractionNumerator / commonDivisor;
           fract.FractionDenominator = fract.FractionDenominator / commonDivisor;

        }

      
        /// <summary>
        /// Creates fraction from string /if possible/
        /// </summary>           
        public static Fraction Parse( string fractionAsString )
        {


            try
            {
                int fractionNumerator;
                int fractionDenominator;
                string[] fractionParts = fractionAsString.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                bool isNumeratorCorrect = int.TryParse(fractionParts[0], out fractionNumerator);
                if (isNumeratorCorrect == false)
                {
                    throw new FormatException();
                }

                if (fractionParts.Length > 1)
                {

                    bool isDenominatorCorrect = int.TryParse(fractionParts[1], out fractionDenominator);
                    if (isDenominatorCorrect == false)
                    {
                        throw new FormatException();
                    }
                    if (fractionDenominator == 0)
                    {
                        throw new DivideByZeroException();
                    }
                }
                else
                {
                    fractionDenominator = 1;
                }

                if (fractionDenominator < 0)
                {
                    fractionDenominator = (-1) * fractionDenominator;
                    fractionNumerator = (-1) * fractionNumerator;
                }
              Fraction result= new Fraction(fractionNumerator, fractionDenominator);

              Simplification(result);
              Console.WriteLine("The fraction is valid!");

              return result;
            }
            catch (FormatException)
            {
                Console.WriteLine("Given string is not a valid fraction!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero!");
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected error occured!");
            }
            
            return default(Fraction);
        }


        public override string ToString()
        {
            
            
            string result = string.Empty;

            try
            {

                if ((this == default(Fraction)))
                {

                    throw new NullReferenceException();

                }
                else if (this.fractionDenominator == 0)
                {
                    throw new DivideByZeroException();
                }

                else
                {
                    if (this.fractionDenominator == 1)
                    {
                        result = this.fractionNumerator.ToString();
                    }
                    else
                    {
                    result = this.fractionNumerator + "/" + this.fractionDenominator;
                    }

                    Console.Write(result);

                    return result;
                }
            }
            catch (DivideByZeroException)
            {
                return "Division by zero!";
            }
            catch (NullReferenceException)
            {
                return "This is not a valid fraction!";
            }            
        }        
    }
}
