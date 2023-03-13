using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    //Card
    public CardBase card;
    //UI Connections
    public Text nameText, descriptionText, costText, attackText, healthText;
    // Text name, description, cost, attack, health
    public Image iconImage;
    public Image backgroundImage;
    //Image - icon, background

    //This is triggered when the card is set to active in the scene...it allows the card time to get the data from the hand before setting itself up.
    
    void OnEnable()
    {
        // CardBase class (card) . cardName. value (value being the variable set in GenericVariable class
        // which is assigned to the value of the inherited data type Classes
        nameText.text = card.cardName.value;
        descriptionText.text = card.description.value;
        costText.text = card.cost.value.ToString();
        attackText.text = card.attackBase.value.ToString();
        healthText.text = card.healthBase.value.ToString();
        iconImage.sprite = card.icon.value;
        backgroundImage.sprite = card.background.value;

        //Remember to 'turn off' the card prefab, otherwise it will take the nothing values from there.
    }
}
