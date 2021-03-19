﻿using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer() {DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861499108" });
            Console.ReadLine();

        }
    }
}
