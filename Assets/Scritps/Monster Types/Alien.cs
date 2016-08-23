using UnityEngine;
using System.Collections;

public class Alien : Monsters {

    public Alien (string name, int life, int mana, int initiative) {
        nameMonster = name;
        hp = life;
        mp = mana;
        speed = initiative;
    }

    public Alien () {
        this.nameMonster = "AlienName";
        this.hp = 1;
        this.mp = 2;
        this.speed = 3;
        this.type = "Alien";
    }
	
}
