//using System; This needed to be removed, because it thought I was asking to use the System 'String' not the class.
//If System needs to be used, type System.String for example.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variable;

[CreateAssetMenu(menuName = "Cards/Card", fileName = "New Card")]
public class CardBase : ScriptableObject
{

    //name
    public String cardName;

    //description
    public String description;
    //Icon

    public SpriteImage icon;

    //Background
    public SpriteImage background;

    //cost
    public Int cost;

    //attack
    public Int attackBase;

    //health
    public Int healthBase;


}
