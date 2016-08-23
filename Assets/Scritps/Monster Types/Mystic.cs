using UnityEngine;
using System.Collections;

public class Mystic : Monsters {

    public Mystic () {
        this.nameMonster = "MysticName";
        this.hp = 100;
        this.mp = 10;
        this.speed = 5;
        this.type = "Mystic";
    }

    public Mystic (string name, int life, int mana, int initiative) {
        nameMonster = name;
        hp = life;
        mp = mana;
        speed = initiative;
    }
}
