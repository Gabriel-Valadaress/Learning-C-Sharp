﻿namespace CarRent_WithoutInterface.Services
{
    class BrazilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100)
            {
                return amount * 0.2;
            }
            return amount * 0.15;
        }
    }
}
