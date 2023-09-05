﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Students_Naididis
{
    public class MessageMain
    {
        public static void Main()
        {
            List<Message> list = new List<Message>();
            Random r= new Random();
            Message m = new Message(); 
            int MCount=r.Next(1,10);
            for (int i = 0; i < MCount; i++)
            {
                Console.WriteLine("Sõnumi sisu:");
                string c = Console.ReadLine();
                Console.WriteLine("Sõnumi autor:");
                string a = Console.ReadLine();
                int t = -1*r.Next(0, 1000000000);
                DateTime dhm = DateTime.Now.Date.AddSeconds(t);//Now()
                m = new Message(c, a, dhm);
                for (int j = 0;j< r.Next(1,1000);j++)
                {
                    m.AddLike();
                }
                list.Add(m);
                m.ShowMessageInfo();
                
            }
            Console.WriteLine(m.GetPopularityInfoN(list));

        }
    }
}
