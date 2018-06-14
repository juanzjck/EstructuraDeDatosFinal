using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Studient : User {
    private Schedule schedule;
    
    public void addSignature(Signature s){

        schedule.addSgnature(s);
    }

}
