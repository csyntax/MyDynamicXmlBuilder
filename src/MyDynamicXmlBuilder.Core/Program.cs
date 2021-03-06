﻿using System;

namespace MyDynamicXmlBuilder.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var xml = XmlBuilder.Create())
            {
                xml.Declaration();

                xml.Comment("Someone comment");

                xml.Users(new { @class = "css bate" }, XmlBuilder.Section(users =>
                {
                    users.Comment("Users");
                    users.User(new { Id = 1 }, XmlBuilder.Section(user =>
                    {
                        user.Comment("User");
                        user.FirstName("Kiro");
                        user.LastName("Zlatnia");
                        user.UserName("zlatnia");
                        user.Age(50);
                        user.Email("kiro@zlatnia.bg");
                        user.Phone("089855533");
                    }));
                }));

                Console.WriteLine(xml.Build());
            }
        }
    }
}
