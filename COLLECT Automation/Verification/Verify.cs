using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Text.RegularExpressions;

namespace COLLECT_Automation.Verification
{
    public class Verify
    {
        public static StringBuilder VerificationErrors = new StringBuilder();
        public static string RegexIdentifier = "^";

        /* 
 * Summary:
 * 
 *     Verifies that the specified condition is true. The verification fails if the
 *     condition is false. Adds the message to VerificationErrors. If stopExecution is true, 
 *     then the execution stops.
 *
 * Parameters:
 *   condition:
 *     The condition to verify is true.
 *
 *   message:
 *     A message to be added to Verification call if the condition is false. 
 *     
 *   stopExecution:
 *      In case of verification failure, we will stop the execution and throw exception if 
 *      stopExecution is true. Otherwise the execution will continue. 
 *   
 * */
        public static void VerifyFieldUsingConst(string actual, string expected, string message)
        {
            // Allows expectedValue to be a RegEx expression to validate against as well as a hard value comparison
            EqualOrMatch(actual, expected, message);
        }

        public static void IsTrue(bool condition, string message, bool stopExecution = false)
        {
            if (!condition)
            {
                LogVerificationError(message, stopExecution = true);
            }
        }

        public static void LogVerificationError(string message, bool stopExecution)
        {
            LogVerificationError(message);

            if (stopExecution)
                Assert.Fail(message);
        }

        private static void LogVerificationError(string message)
        {
            VerificationErrors.AppendFormat("{0}{1}{2}", message, Environment.NewLine, Environment.NewLine);
        }

        /// <summary>
        /// Verifies that actual matches expected or matches expected as an expression.
        ///		If not Add the message to VerificationErrors.
        ///		If stopExecution is true, then the execution stops.
        /// </summary>
        /// <param name="actual">The value to be validated.</param>
        /// <param name="expected"></param>
        /// <param name="message">The message to be added to Verification call if the condition fails.</param>
        /// <param name="stopExecution">If TRUE and the condition fails, throws an AssertFailedException.</param>
        public static void EqualOrMatch(object actual, object expected, string message, bool stopExecution = false)
        {
            if (expected.ToString().StartsWith(RegexIdentifier))
                Match(actual, expected, message, stopExecution);
            else
                Equal(actual, expected, message, stopExecution);
        }

        /// <summary>
        /// Verifies that actual matches the expected (expression).
        ///		If not Add the message to VerificationErrors.
        ///		If stopExecution is true, then the execution stops.
        /// </summary>
        /// <param name="actual">The value to be validated.</param>
        /// <param name="expected">The (potenial) RegEx expression to validate against.</param>
        /// <param name="message">The message to be added to Verification call if the condition fails.</param>
        /// <param name="stopExecution">If TRUE and the condition fails, throws an AssertFailedException.</param>
        public static void Match(object actual, object expected, string message, bool stopExecution = false)
        {
            try
            {
                Assert.IsTrue(Regex.IsMatch(actual.ToString(), expected.ToString()));
            }
            catch (AssertFailedException)
            {
                LogVerificationError(message, stopExecution);
            }
        }

        /* 
 * Summary:
 *     Verifies that the two objects are equal. If not Add the message to VerificationErrors.
 *     If stopExecution is true, then the execution stops.
 *
 * Parameters:
 *   objA:
 *     object to be compared.
 *     
 *   objB:
 *     object to be compared to.
 *
 *   message:
 *     A message to be added to Verification call if objects are not equal. 
 *     
 *   stopExecution:
 *      In case of mismatch, we will stop the execution and throw exception if 
 *      stopExecution is true. Otherwise the execution will continue. 
 *   
 * */
        public static void Equal(object objA, object objB, string message, bool stopExecution = false)
        {
            try
            {
                Assert.AreEqual(objA, objB);
            }
            catch (AssertFailedException)
            {
                LogVerificationError(message, stopExecution = true);
            }
        }


    }
}
