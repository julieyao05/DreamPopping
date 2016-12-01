using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextOptions
{
    public static KeyValuePair<string, int>[] positiveOptions = new KeyValuePair<string, int>[] 
    {
            new KeyValuePair<string, int>("Buy Apples\n for $10", 10),
            new KeyValuePair<string, int>("Buy a Novel\n for $10", 10),
            new KeyValuePair<string, int>( "Buy Pencils\n for $5", 5),
            new KeyValuePair<string, int>("Buy Erasers\n for $5", 5)
    };


    public static KeyValuePair<string, int>[] negativeOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Buy a Video\n Game Console\n for $50", 50),
            new KeyValuePair<string, int>("Buy New\n Limited Fancy\n Sneakers for $30", 30),
            new KeyValuePair<string, int>("Buy a new\n Smartphone\n for $80", 80),
            new KeyValuePair<string, int>("Buy Designer Jeans for $40", 40) 
    };

    public static KeyValuePair<string, int>[] earnOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Earn $5 for\n cleaning\n a car", 5),
            new KeyValuePair<string, int>("Earn $5 for\n delivering\n newspapers", 5),
            new KeyValuePair<string, int>("Earn $10 for\n raking your\n neighbor's lawn", 10),
            new KeyValuePair<string, int>("Earn $10 for\n cat-sitting", 10)
    };

    public static KeyValuePair<string, int>[] goalOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Buy Mother's Day gift for $50", 50),
            new KeyValuePair<string, int>("Buy Bike for $60", 60),
            new KeyValuePair<string, int>("Buy gift for friend's birthday for $40", 40),
            new KeyValuePair<string, int>( "Buy new fiction novel for $50", 50)
	};
}
