using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Cards {

    public string cardName { get; set; }
    public int price { get; set; }
    public int attack { get; set; }
    public int defense { get; set; }
    public List<string> cards = new List<string> ();

    public void AddCardsByType (string characterType) {

        cards.Add ("Attack1");
        cards.Add ("Attack2");
        cards.Add ("Attack3");
        cards.Add ("Defense1");
        cards.Add ("Defense2");
        cards.Add ("Defense3");

        switch (characterType) {
            case "Alien":
            break;

            case "Robot":
            break;

            case "Beast":
            break;

            case "Mutant":
            break;

            case "Elemental":
            break;

            case "Mystic":
            break;

        }
    }

    public string GetCardName (List<string> c) {
        return c[Random.Range (0, c.Count)];
    }

    public string RandomCards () {
        return cards[Random.Range (0, cards.Count)];
    }

    public void GetCardEffect (Monsters p, string s) { 
        Debug.Log (" -- PREVIOUS -- THE MONSTER: " + p.nameMonster + " HAS THE ATTACK: " + p.attack + " AND THE DEFENSE: " + p.defense);
        switch (s) {
            case "Attack1":
                p.attack = Attack1 ();
            break;
            case "Attack2":
                p.attack = Attack2 ();
            break;
            case "Attack3":
                p.attack = Attack3 ();
            break;
            case "Defense1":
                p.defense = Defense1 ();
            break;
            case "Defense2":
                p.defense = Defense2 ();
            break;
            case "Defense3":
                p.defense = Defense3 ();
            break;
        }
        Debug.Log ("THE MONSTER: " + p.nameMonster + " HAS THE ATTACK: " + p.attack + " AND THE DEFENSE: " + p.defense);
        Debug.Log (" The cardname was : " + cardName);

    }

    public void DecrementingHP (Monsters p, Monsters o) {
        Debug.Log (" IT'S TIME TO DECREASE HP. THE MONSTER'S PREVIOUS HP WAS: " + o.hp);
        if (o.defense > 0) {
            p.attack -= o.defense;
            o.hp -= p.attack;
        }
        else {
            o.hp -= p.attack;

        }
        Debug.Log (" THE MONSTER'S NEW HP IS: " + o.hp);
    }

    //---------------------------------------------------- Generic Cards ------------------------------------------------------------------

    public int Attack1 () {
        cardName = "Attack1";
        attack = 1;
        return attack;
    }

    public int Attack2 () {
        cardName = "Attack2";
        attack = 2;
        return attack;
    }

    public int Attack3 () {
        cardName = "Attack3";
        attack = 3;
        return attack;
    }

    public int Defense1 () {
        cardName = "Defense1";
        defense = 1;
        return defense;
    }

    public int Defense2 () {
        cardName = "Defense2";
        defense = 2;
        return defense;
    }

    public int Defense3 () {
        cardName = "Defense3";
        defense = 3;
        return defense;
    }

    //----------------------------------------------------------- End of Generic Cards -----------------------------------------------------

}
