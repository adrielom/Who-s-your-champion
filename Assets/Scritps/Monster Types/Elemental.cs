using UnityEngine;
using System.Collections;

public class Elemental : Monsters {

    public Elemental () {
        this.nameMonster = "ElementalName";
        this.hp = 100;
        this.mp = 10;
        this.speed = 5;
        this.type = "Elemental";
    }

    public Elemental (string name, int life, int mana, int initiative) {
        nameMonster = name;
        hp = life;
        mp = mana;
        speed = initiative;
    }
}
