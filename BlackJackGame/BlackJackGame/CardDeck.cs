using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for Class1
/// </summary>
public class CardDeck
{
	public CardDeck()
	{
	    List<Card> cardDeck = new List<Card>();
        for (int i = 0; i < 13; i++)
	    {
	        for (int j = 0; j < 4; j++)
	        {
	           Card card = new Card(j, i+1);
	            cardDeck.Add(card);
	        }
	    }

    }

    private void ShuffelDeck()
    {
        
    }
}
