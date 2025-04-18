using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToGame : MonoBehaviour
{
    /**
		 * Author: Michelle Vuong
		 * Description: Used for the play again button. Switches the scene to the game scene.
		 */
    public void switchToGame()
    {
        SceneManager.LoadScene("Game"); //load the game scene
    }

    

}
