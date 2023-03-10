using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace ATMProject
{
    internal class Customer
    {
        private long accountNo;
        public string accountHolder;
        private int  balance;
        private int atmPin;
        public  Stack miniStatement;

        public Customer(long accountNo, string accountHolder,  int atmPin)
        {
            this.accountNo = accountNo;
            this.accountHolder = accountHolder;
            this.atmPin = atmPin;
            miniStatement = new Stack();
        }
        //setters and getters for the balance field to provide the encapsulation
        public void setBalance(int  blnc)
        {
            this.balance += blnc;
        }
        public double getBalance() 
        { 
            return balance; 
        }  
        public int getAtmPin()
        {
            return atmPin;
        }
        public string getAccountHolder()
        {
            return accountHolder;
        }
        //returns the customer account details
        public override string ToString()
        {
            return "[AccountHolder: "+ accountHolder+ " , Account no: "+accountNo+" , "+"ATM PIN: "+ atmPin+"]";
        }



    }

}
