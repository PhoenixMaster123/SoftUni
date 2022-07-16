using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Telephony.Models.Interfaces
{
    public class Smartphone : ICallable, IBrawseble
    {
        public string BrawsURL(string url)
        {
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            return $"Calling... {number}";
        }
    }
}
