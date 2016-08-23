using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cards {

    public string cardName { get; set; }
    public int price { get; set; }
    public float attack { get; set; }
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

    public void GetCardEffect (Monsters p, Monsters o, string s) {

        switch (s) {
            case "Attack1":
                o.hp = Attack1 (o.hp);
            break;
            case "Attack2":
                o.hp = Attack2 (o.hp);
            break;
            case "Attack3":
                o.hp = Attack3 (o.hp);
            break;
            case "Defense1":
                o.hp = Defense1 (o.hp, p.attack);
            break;
            case "Defense2":
                o.hp = Defense2 (o.hp, p.attack);
            break;
            case "Defense3":
                o.hp = Defense3 (o.hp);
            break;
        }

    }

    //---------------------------------------------------- Generic Cards ------------------------------------------------------------------

    public int Attack1 (int hp) {
        cardName = "Attack1";
        attack = 1;
        hp -= (int)attack;
        return hp;
    }

    public int Attack2 (int hp) {
        attack = 2;
        hp -= (int)attack;
        return hp;
    }

    public int Attack3 (int hp) {
        cardName = "Attack3";
        attack = 3;
        hp -= (int)attack;
        return hp;
    }

    public int Defense1 (int hp, int o) {
        cardName = "Defense1";
        attack = o;
        attack *= .25f;
        hp -= (int)attack;
        return hp;
    }

    public int Defense2 (int hp, int o) {
        cardName = "Defense2";
        attack = o;
        attack *= .5f;
        hp -= (int)attack;
        return hp;
    }

    public int Defense3 (int hp) {
        cardName = "Defense3";
        return hp;
    }

    //----------------------------------------------------------- End of Generic Cards -----------------------------------------------------
 
}
