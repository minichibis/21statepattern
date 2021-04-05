/** Sam Carpenter
*   Who knows when this is
*   Dodging.cs
*   returns various strings
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dodging : State
{
	public Dodging(){}
 
	public string block(){
		return "You hold up your shield, but they perform a dodge roll!";
	}
	
	public string dodge(){
		return "You deftly reposition yourself as your foe rolls along the ground.";
	}
	
	public string attack(){
		return "Your foe handily dodges the blow! You pull your blade out of the ground.";
	}
	
	public string move(){
		return "Your foe gets ready to roll...";
	}
}

