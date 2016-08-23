using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonCards : MonoBehaviour {

    public static ButtonCards instance;

    public Cards playerCards = new Cards ();
    public Cards oponentCards = new Cards ();
    public string cardName;

    void Awake () {
        if (instance == null)
            instance = this;
    }

    void Start () {

        playerCards.AddCardsByType (Player.instance.player.type);
        cardName = playerCards.RandomCards ();
        this.gameObject.GetComponentInChildren<Text> ().text = cardName;
    }

    IEnumerator DelayEndOfCasting (float f, int t) {
        yield return new WaitForSeconds (f);
        InitiativeBar.instance.turn = t;
    }

    public void PlayerCallButtonEffect () {
        print (cardName);
        Player.instance.player.canMove = true;
        StartCoroutine (DelayEndOfCasting (0.2f, 1));


    }

    public void OponetCallButtonEffect () {
        oponentCards.AddCardsByType (Oponent.instance.oponent.type);
        cardName = oponentCards.RandomCards ();
        oponentCards.GetCardEffect (Oponent.instance.oponent, Player.instance.player, cardName);
        print (cardName);
        Oponent.instance.oponent.canMove = true;

    }
}
