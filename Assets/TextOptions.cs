using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextOptions
{
    public static KeyValuePair<string, int>[] positiveOptions = new KeyValuePair<string, int>[] 
    {
            new KeyValuePair<string, int>("Buy Apples for $10", 10),
            new KeyValuePair<string, int>("Buy a Novel for $10", 10),
            new KeyValuePair<string, int>( "Buy Pencils for $5", 5),
            new KeyValuePair<string, int>("Buy Erasers for $5", 5)
    };


    public static KeyValuePair<string, int>[] negativeOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Buy a Video Game Console for $50", 50),
            new KeyValuePair<string, int>("Buy New Limited Fancy Sneakers for $30", 30),
            new KeyValuePair<string, int>("Buy a new Smartphone for $80", 80),
            new KeyValuePair<string, int>("Buy Designer Jeans for $40", 40) 
    };

    public static KeyValuePair<string, int>[] earnOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Earn $5 for cleaning a car", 5),
            new KeyValuePair<string, int>("Earn $5 for delivering newspapers", 5),
            new KeyValuePair<string, int>("Earn $10 for raking your neighbor's lawn", 10),
            new KeyValuePair<string, int>("Earn $10 for cat-sitting", 10)
    };

    public static KeyValuePair<string, int>[] goalOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Buy Mother's Day gift for $50", 50),
            new KeyValuePair<string, int>("Buy Bike for $60", 60),
            new KeyValuePair<string, int>("Buy gift for friend's birthday for $40", 40),
            new KeyValuePair<string, int>( "Buy new fiction novel for $50", 50)
	};
}
