using System;
using System.Collections.Generic;
using System.Linq.Expressions;


public class CardDeck
{
    private List<Card> deck;

	public CardDeck()
	{
	    deck = new List<Card>();
        
	}

private void FillDeck()
{
    for (int i = 0; i < 13; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Card card = new Card(j, i+1);
            cardDeck.Add(card);
        }
    }
}

private void Shuffle(List deck)
{
    
}
    
}
