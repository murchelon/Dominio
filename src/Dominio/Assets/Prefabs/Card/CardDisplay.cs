using Dominio;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;



public class CardDisplay : MonoBehaviour
{
    public CardData cardData;
    public TMP_Text txtCardValue;
    public TMP_Text txtCardSuit;

    [SerializeField] private Image cardImage_art;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateCardDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void UpdateCardDisplay()
    {
        txtCardValue.text = cardData.faceValue;

        switch (cardData.suit)
        {
            case Suit.Hearts:
                txtCardSuit.text = "♥";
                txtCardSuit.color = Color.red;
                txtCardValue.color = Color.red;
                break;

            case Suit.Diamonds:
                txtCardSuit.text = "♦";
                txtCardSuit.color = Color.red;
                txtCardValue.color = Color.red;
                break;

            case Suit.Clubs:
                txtCardSuit.text = "♣";
                txtCardSuit.color = Color.black;
                txtCardValue.color = Color.black;
                break;

            case Suit.Spades:
                txtCardSuit.text = "♠";
                txtCardSuit.color = Color.black;
                txtCardValue.color = Color.black;
                break;
        }

        Sprite backgroundSprite = null;


        switch (cardData.cardType)
        {
            case CardType.General:
                backgroundSprite = Resources.Load<Sprite>(
                    "Images\\Cards\\Backgrounds\\card_bg_general"
                );
                break;

            case CardType.Army:
                backgroundSprite = Resources.Load<Sprite>(
                    "Images\\Cards\\Backgrounds\\card_bg_soldier"
                );
                break;
        }

        cardImage_art.sprite = backgroundSprite;
    }


}
