﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparky
{
    public interface ILogBook
    {
        public int LogSeverity { get; set; }
        public string LogType { get; set; }
        void Message(string message);
        bool LogToDb(string message);
        bool LogBalanceAfterWithdrawl(int balanceAfterWithdrawl);
        string MessageWithReturnString(string message);
        bool LogWithOutputResult(string str, out string outputStr);
        bool LogWithRefObj(ref Customer customer);

    }
    public class LogBook: ILogBook
    {
        public int LogSeverity { get; set; }
        public string LogType { get; set; }

        public bool LogBalanceAfterWithdrawl(int balanceAfterWithdrawl)
        {
            if(balanceAfterWithdrawl>=0)
            {
                Console.WriteLine("Success");
                return true;
            }
            Console.WriteLine("Failure");
            return false;
        }

        public bool LogToDb(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public bool LogWithOutputResult(string str, out string outputStr)
        {
            outputStr = "Hello " + str;
            return true;
        }

        public bool LogWithRefObj(ref Customer customer)
        {
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public string MessageWithReturnString(string message)
        {
            Console.WriteLine(message);
            return message.ToLower();
        }

    }
    //public class LogFaker : ILogBook
    //{
    //    public void Message(string message)
    //    {
    //    }
    //}

}
