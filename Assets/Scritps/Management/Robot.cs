using UnityEngine;
using System.Collections;

public class Robot : Monsters {

    public Robot () {
        this.nameMonster = "RobotName";
        this.hp = 100;
        this.mp = 10;
        this.speed = 5;
        this.type = "Robot";
    }

    public Robot (string name, int life, int mana, int initiative) {
        nameMonster = name;
        hp = life;
        mp = mana;
        speed = initiative;
    }
}
