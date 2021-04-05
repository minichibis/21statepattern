/** Sam Carpenter
*   Who knows when this is
*   Defending.cs
*   returns various strings
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defending : State
{
    public Defending(){}
	
	public string block(){
		return "You hold up your shield as your foe does. It feels rather silly.";
	}
	
	public string dodge(){
		return "You fall back to a better position as they block a nonexistent strike.";
	}
	
	public string attack(){
		return "Your blade leaves a scratch in the foe's shield, but it does not yield.";
	}
	
	public string move(){
		return "Your foe readies their shield...";
	}
}