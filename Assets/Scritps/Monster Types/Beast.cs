using UnityEngine;
using System.Collections;

public class Beast : Monsters {

    public Beast () {
        this.nameMonster = "BeastName";
        this.hp = 100;
        this.mp = 10;
        this.speed = 5;
        this.type = "Beast";
    }

    public Beast (string name, int life, int mana, int initiative) {
        nameMonster = name;
        hp = life;
        mp = mana;
        speed = initiative;
    }
}
