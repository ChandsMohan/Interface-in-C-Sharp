using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface TransactionExample
    {
       // These Are Interface Members and these must be used in the class
        void ShowTransactions();
        double GetAmount();
    }
  class Program : TransactionExample
    {
      private string tcode;
      private string date;
      private double amount;

      public Program()
      {
          tcode = "";
          date = "";
          amount = 0.0;
      }

      public Program(string c, string d, double e)
      {
          tcode = c;
          date = d;
          amount = e;
      }

      public double GetAmount() 
      {                            // GetAmount Is Our Interface Member and It is implementing here
          return amount;          // It must be implemented otherwise error May be shown
      }
      public void ShowTransactions()
      {                                                //ShowTransactions Is Our Interface Member and It is implementing here i.e must be implemented
          Console.WriteLine("Transaction: " + tcode);  // It must be implemented otherwise error May be shown
          Console.WriteLine("Date: " + date);
          Console.WriteLine("Amount: " + amount);
      }

        static void Main(string[] args)
        {
            Program obj = new Program("001", "15/10/2015", 789874.00);
            Program Newobj = new Program("002", "18/10/2015", 7452574.00);
            Newobj.ShowTransactions();
            obj.ShowTransactions();
            Console.ReadKey();
            
        }
    }
}
