/** Sam Carpenter
*   Who knows when this is
*   Attacking.cs
*   returns various strings
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : State
{
    public Attacking(){}
	
	public string block(){
		return "You block the strike with your bracer, although you feel a dull thud of pain.";
	}
	
	public string dodge(){
		return "You deftly avoid the flash of steel, a scar in the earth left where you once stood.";
	}
	
	public string attack(){
		return "Your foe hits you before you do! You feel a sharp pain and the flow of blood, but refuse to fall.";
	}
	
	public string move(){
		return "Your foe readies their blade...";
	}
}
