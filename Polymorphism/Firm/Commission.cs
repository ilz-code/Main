using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    class Commission : Hourly
    {
        double _totalSales;
        double _commissionRate;

        public Commission(string name, string address, string phone, string securityNumber, double hourlyRate, double commissionRate) : base( name, address, phone, securityNumber, hourlyRate)
        {
            _commissionRate = commissionRate;
        }

        public void addSales(double totalSales)
        {
            _totalSales = totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + _totalSales * _commissionRate;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: " + _totalSales;
            return result;
        }
    }
}
