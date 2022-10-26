public static double cardPrice(Card card) {
    double price = card.getPrice();
    Components [] component = card.GetComponents();
     for (int i=0;i<component.Length; i++)
    {
        price += component[i].getPrice();
    }
     return price;
}

public static double kitPrice(Kits kit)
{
    double price = 0;
    Components []components = kit.GetComponents();
    Card [] cards = kit.getcards();
    for (int i = 0; i < components.Length; i++)
    {
        price += components[i].getPrice();
    }
    for (int i = 0; i < cards.Length; i++)
    {
        price += cardPrice(cards[i]);
    }
    return price;
}
