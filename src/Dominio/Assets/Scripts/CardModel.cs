using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Dominio
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum CardType
    {
        General,
        Army
    }


    [CreateAssetMenu(fileName = "New Card", menuName = "Card")]
    public class CardData : ScriptableObject
    {
        public int ID;

        public string cardName;
        public int baseValue;
        public int useValue;
        public string faceValue;
        public Suit suit;
        public CardType cardType;
    }

}

