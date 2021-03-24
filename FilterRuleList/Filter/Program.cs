using Filter.Models;
using System;
using System.Collections.Generic;
using System.Net;

namespace Filter
{
    public class Program
    {
        static void Main(string[] args)
        {
            FilterRule filterRuleOne = new FilterRule
            {
                RemoteIpAddress = "192.168.48.10:400;192.168.48.11:50"
            };

            List<string> RemoteIpAddresses = new List<string>();
            RemoteIpAddresses.AddRange(filterRuleOne.RemoteIpAddress.Split(';'));

            foreach (var RemoteIPAddress in RemoteIpAddresses)
            {
                Console.WriteLine(RemoteIPAddress.ToString());
            }

            Console.ReadLine();
        }
    }
}
