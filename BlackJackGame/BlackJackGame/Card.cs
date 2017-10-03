using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Card
{

    private int value { get; set; }
    private string type { get; set; }

    public Card(int i, int value)
    {
        switch (i)
        {
            case 0:
                type = "Heart";
                break;
            case 1:
                type = "Diamond";
                break;
            case 2:
                type = "Club";
                break;
            case 3:
                type = "Spade";
                break;

        }
        this.value = value;
        this.type = type;
    }

    public override string ToString()
    {
      
        return "value: " + value +"  Type: "+ type;
    }
}
