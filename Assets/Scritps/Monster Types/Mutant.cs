using UnityEngine;
using System.Collections;

public class Mutant : Monsters {

    public Mutant () {
        this.nameMonster = "MutantName";
        this.hp = 100;
        this.mp = 10;
        this.speed = 5;
        this.type = "Mutant";
    }

    public Mutant (string name, int life, int mana, int initiative) {
        nameMonster = name;
        hp = life;
        mp = mana;
        speed = initiative;
    }
}
