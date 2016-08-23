using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
    
public abstract class Monsters {


    public string nameMonster { get; set; }
    public bool canMove { get; set; }
    public int  hp { get; set; }
    public int mp { get; set; }
    public int speed { get; set; }
    public string type { get; set; }
    public int attack { get; set; }
}
