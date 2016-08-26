using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonCards : MonoBehaviour {

    public static ButtonCards instance;

    public Cards playerCards = new Cards ();
    public Cards oponentCards = new Cards ();
    public string cardNamePlayer, cardNameOponent;

    void Awake () {
        if (instance == null)
            instance = this;
    }

    void Start () {
        playerCards.AddCardsByType (Player.instance.player.type);
        InitializingCardsPlayer ();
    }

    public void InitializingCardsPlayer () {
        cardNamePlayer = playerCards.RandomCards ();
        this.gameObject.GetComponentInChildren<Text> ().text = cardNamePlayer;
    }

    void Update () {
    }

   
    IEnumerator DelayEndOfCasting (float f, int t) {
        yield return new WaitForSeconds (f);
        InitiativeBar.instance.turn = t;
        InitializingCardsPlayer ();
    }

    public void PlayerCallButtonEffect () {
        print ("THE PLAYER CARD IS: " + cardNamePlayer);
        Player.instance.playerCard = cardNamePlayer;
        cardNamePlayer = this.gameObject.GetComponentInChildren<Text> ().name;
        Player.instance.player.canMove = true;
        StartCoroutine (DelayEndOfCasting (0.4f, 1));
        
    }

    public void CallingPlayerCardEffect () {
        playerCards.GetCardEffect (Player.instance.player, Player.instance.playerCard);
    }

    public void OponetCallButtonEffect () {
        oponentCards.AddCardsByType (Oponent.instance.oponent.type);
        cardNameOponent = oponentCards.RandomCards ();
        print ("THE OPONENT CARD IS: " + cardNameOponent);
        oponentCards.GetCardEffect (Oponent.instance.oponent, cardNameOponent);
        Oponent.instance.oponent.canMove = true;
        if (Oponent.instance.oponent.attack > 0) {
            oponentCards.DecrementingHP (Oponent.instance.oponent, Player.instance.player);

        }

    }
}
