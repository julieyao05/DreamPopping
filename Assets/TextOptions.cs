using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TextOptions
{
    public static KeyValuePair<string, int>[] positiveOptions = new KeyValuePair<string, int>[] 
    {
            new KeyValuePair<string, int>("Buy apples\n for $10", 10),
            new KeyValuePair<string, int>("Buy a novel\n for $10", 10),
            new KeyValuePair<string, int>( "Buy pencils\n for $5", 5),
            new KeyValuePair<string, int>("Buy erasers\n for $5", 5),
			new KeyValuePair<string, int>( "Buy books\n for $10", 10),
			new KeyValuePair<string, int>( "Buy banana\n for $5", 5),
			new KeyValuePair<string, int>( "Buy oatmeal\n for $5", 5),
			new KeyValuePair<string, int>( "Buy kale\n for $5", 5),
			new KeyValuePair<string, int>( "Buy avocado\n for $5", 5),
			new KeyValuePair<string, int>( "Buy quinoa\n for $5", 5),
			new KeyValuePair<string, int>( "Buy kiwi\n for $5", 5),
			new KeyValuePair<string, int>( "Buy mango\n for $5", 5),
			new KeyValuePair<string, int>( "Buy yogurt\n for $5", 5),
			new KeyValuePair<string, int>( "Buy pan\n for $10", 10),
			new KeyValuePair<string, int>( "Buy pot\n for $10", 10),
			new KeyValuePair<string, int>( "Buy water\n for $5", 5),
			new KeyValuePair<string, int>( "Buy milk\n for $5", 5),
			new KeyValuePair<string, int>( "Buy blueberries\n for $5", 5),
			new KeyValuePair<string, int>( "Buy paper\n for $10", 10),
			new KeyValuePair<string, int>( "Buy cereal\n for $5", 5),
			new KeyValuePair<string, int>( "Buy hot\n chocolate\n for $5", 5),
			new KeyValuePair<string, int>( "Buy\n basketball\n for $10", 10),
			new KeyValuePair<string, int>( "Buy\n soccorball\n for $10", 10),
			new KeyValuePair<string, int>( "Buy\n volleyball\n for $10", 10),
			new KeyValuePair<string, int>( "Buy\n football\n for $10", 10),
			new KeyValuePair<string, int>( "Buy\n baseball\n for $10", 10),
    };


    public static KeyValuePair<string, int>[] negativeOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Buy a Video\n Game Console\n for $50", 50),
            new KeyValuePair<string, int>("Buy new\n Limited Fancy\n Sneakers for $30", 30),
            new KeyValuePair<string, int>("Buy new\n Smartphone\n for $80", 80),
            new KeyValuePair<string, int>("Buy Designer\n Jeans for $40", 40),
			new KeyValuePair<string, int>("Buy huge\n box of\n cookies\n for $30", 30),
			new KeyValuePair<string, int>("Buy ticket\n for Disneyland\n for $80", 80),
			new KeyValuePair<string, int>("Buy ticket\n for Universal\n Studios for\n $80", 80),
			new KeyValuePair<string, int>("Buy new\n iPad\n for $80", 80),
			new KeyValuePair<string, int>("Buy second\n for laptop for\n for $80", 80),
			new KeyValuePair<string, int>("Buy glamorous\n headphones\n for $80", 80),
			new KeyValuePair<string, int>("Buy new\n Barbie doll\n for $30", 30),
			new KeyValuePair<string, int>("Buy\n Designer\n shirt for\n $60", 60)
    };

    public static KeyValuePair<string, int>[] earnOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Earn $5\n for cleaning\n a car", 5),
            new KeyValuePair<string, int>("Earn $5\n for delivering\n newspapers", 5),
            new KeyValuePair<string, int>("Earn $10\n for raking\n your neighbor's\n lawn", 10),
            new KeyValuePair<string, int>("Earn $10\n for cat\n-sitting", 10),
			new KeyValuePair<string, int>("Earn $10\n for lawn\n mowing", 10),
			new KeyValuePair<string, int>("Earn $10\n for baking\n cookies", 10),
			new KeyValuePair<string, int>("Earn $10\n for selling\n lemonade", 10),
			new KeyValuePair<string, int>("Earn $15\n from garage\n sale", 15),
			new KeyValuePair<string, int>("Earn $10\n for selling\n old books", 10),
			new KeyValuePair<string, int>("Earn $10\n for watering\n plants", 10)
    };

    public static KeyValuePair<string, int>[] goalOptions = new KeyValuePair<string, int>[]
    {
            new KeyValuePair<string, int>("Buy Mother's\n Day gift\n for $50", 50),
            new KeyValuePair<string, int>("Buy Bike\n for $60", 60),
            new KeyValuePair<string, int>("Buy gift\n for friend's\n birthday for $40", 40),
            new KeyValuePair<string, int>("Buy new\n fiction novel\n for $50", 50),
			new KeyValuePair<string, int>("Pay school\n tuition for\n $80", 80),
			new KeyValuePair<string, int>("Buy plane\n ticket for\n $70", 70),
			new KeyValuePair<string, int>("Buy pet\n doggy for\n $50", 50),
			new KeyValuePair<string, int>("Buy art\n supplies\n for $50", 50),
			new KeyValuePair<string, int>("Buy tool\n set for\n $50", 50),
			new KeyValuePair<string, int>("Buy pet\n cat for\n $50", 50),
			new KeyValuePair<string, int>("Donate\n money to\n charity\n for $60", 60),
			new KeyValuePair<string, int>("Buy pet\n goldfish\n for $50", 50),
			new KeyValuePair<string, int>("Pay for\n piano lesson\n for $60", 60),
			new KeyValuePair<string, int>("Pay for\n violin lesson\n for $60", 60),
			new KeyValuePair<string, int>("Pay for\n trumpet lesson\n for $60", 60),
			new KeyValuePair<string, int>("Pay for\n flute lesson\n for $60", 60),
			new KeyValuePair<string, int>("Pay for\n basketball\n lesson for\n $60", 60),
			new KeyValuePair<string, int>("Pay for\n baseball\n lesson for\n $60", 60),
			new KeyValuePair<string, int>("Pay for\n volleyball\n lesson for\n $60", 60),
			new KeyValuePair<string, int>("Pay for\n football\n lesson for\n $60", 60),
			new KeyValuePair<string, int>("Pay for\n soccor\n lesson for\n $60", 60)
	};
}
