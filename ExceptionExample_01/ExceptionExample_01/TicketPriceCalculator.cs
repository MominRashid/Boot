﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample_01
{
    class TicketPriceCalculator
    {
        public double GetTotalPrice(string noOfTickets)
        {
            try
            {
                byte noOfTicketsInByte = Convert.ToByte(noOfTickets);
                double total = noOfTicketsInByte*10;
                return total;
            }
            catch (FormatException formatException)
            {
                //return -1;
                //throw new Exception("Digit only", formatException);
            }
            catch (OverflowException overflowException)
            {
                //return -2;
                //throw new Exception("Overflow", overflowException);
            }
        }
    }
}
