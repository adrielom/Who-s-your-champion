using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InitiativeBar : MonoBehaviour {

    public static InitiativeBar instance = null;

    public Slider oponentHandleInitiative;
    public Slider playerHandleInitiative;
    public float speedMod, playerTempIncreaseSpeed, oponentTempIncreaseSpeed;
    public GameObject button;
    public int turn = 0;

    void Awake () {
        if (instance == null)
            instance = this;
    }

    void Start () {
        playerTempIncreaseSpeed = 1;
        oponentTempIncreaseSpeed = 1;
        CheckingFirstToMove ();
    }

    void Update () {

        print ("TURN: "+turn);

        if (turn != 0) {
            Initiative ();
            CheckingInitiativeBarBoundries (oponentHandleInitiative);
            CheckingInitiativeBarBoundries (playerHandleInitiative);
            CastingEffectOponent (oponentHandleInitiative, Oponent.instance.oponent.canMove);
            CastingEffectPlayer (playerHandleInitiative, Player.instance.player.canMove);
        }

    }

    IEnumerator DelayEndOfCasting (float f, int t) {
        yield return new WaitForSeconds (f);
        turn = t;
    }

    public void CheckingFirstToMove () {
        if (Player.instance.player.speed > Oponent.instance.oponent.speed) {
            turn = 1;
        }
        else if (Oponent.instance.oponent.speed > Player.instance.player.speed) {
            turn = 2;
        }
        else {
            turn = Random.Range (1, 3);
        }
        button.SetActive (false);
    }

    public void CastingEffectPlayer (Slider p, bool m) {

        if (p.value >= 80 && m == false) {
            turn = 0;
            button.SetActive (true);
          
        }
        else if (p.value > 80 && p.value < p.maxValue && m == true) {
            button.SetActive (false);
            playerTempIncreaseSpeed = 2;
            turn = 1;
        }
        else if (p.value > p.minValue && p.value < 1) {
            Player.instance.player.canMove = false;
            playerTempIncreaseSpeed = 1;
        }
        if (ButtonCards.instance.playerCards != null && p.value == p.minValue) {
            ButtonCards.instance.playerCards.GetCardEffect (Player.instance.player, Oponent.instance.oponent, ButtonCards.instance.cardName);
        }
    }

    public void CastingEffectOponent (Slider p, bool m) {
        
        if (p.value >= 80 && p.value < 80.2f && m == false) {
            turn = 0;
            StartCoroutine (DelayEndOfCasting (0.2f,2));

        }
        else if (p.value > 80 && p.value < p.maxValue && m == true) {
            turn = 2;
            oponentTempIncreaseSpeed = 2;
        }
        else if (p.value > p.minValue && p.value < 1) {
            Oponent.instance.oponent.canMove = false;
            oponentTempIncreaseSpeed = 1;
        }
        if (ButtonCards.instance.oponentCards != null && p.value == p.minValue) {
            ButtonCards b = new ButtonCards ();
            b.OponetCallButtonEffect ();
        }
    }

    public void Initiative () {

        oponentHandleInitiative.value += Oponent.instance.oponent.speed * Time.deltaTime * oponentTempIncreaseSpeed * speedMod;
        playerHandleInitiative.value += Player.instance.player.speed * Time.deltaTime * playerTempIncreaseSpeed * speedMod;

    }

    public void CheckingInitiativeBarBoundries (Slider p) {

        if (p.value >= p.maxValue) {
            p.value = p.minValue;
        }
    }
}
