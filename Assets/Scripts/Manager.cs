/** Sam Carpenter
*   Who knows when this is
*   Manager.cs
*   runs the program
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
	State state;
	
	State attacking;
	State defending;
	State dodging;
	
	public Text actiontext;
	public Text statetext;
	
	
    // Start is called before the first frame update
    void Start()
    {
        attacking = new Attacking();
		defending = new Defending();
		dodging = new Dodging();
		state = attacking;
		actiontext.text = "You are in combat with a dreadful foe! What will you do?";
		statetext.text = state.move();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
			actiontext.text = state.attack();
			statechange();
		}else if (Input.GetKeyDown(KeyCode.W)){
			actiontext.text = state.block();
			statechange();
		}else if (Input.GetKeyDown(KeyCode.E)){
			actiontext.text = state.dodge();
			statechange();
		}else if (Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
	
	void statechange(){
		if(state.Equals(attacking)){
			state = defending;
		}else if(state.Equals(defending)){
			state = dodging;
		}else if(state.Equals(dodging)){
			state = attacking;
		}
		statetext.text = state.move();
	}
}
