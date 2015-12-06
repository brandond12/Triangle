using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleTDD
{
    public class NegitiveNumber : Exception
    {
        /**
        * \brief default constructor. Create a NegitiveNumber with base Exception class
        *
        * \details <b>Details</b>
        *
        * \param n/a
        *
        * \return  n/a
        */
        public NegitiveNumber()
        {

        }

        /**
        * \brief overloaded constructor. Create a NegitiveNumber with base Exception class and message
        *
        * \details <b>Details</b>
        *
        * \param message <b>string</b> - the message to be attached to the exception
        *
        * \return  n/a
        */
        public NegitiveNumber(string message)
            : base(message)
        {

        }
    }
}
