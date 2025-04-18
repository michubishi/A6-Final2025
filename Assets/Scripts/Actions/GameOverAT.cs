using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Actions {

	public class GameOverAT : ActionTask {

		/*
		 * Author: Michelle Vuong
		 * Description: Loads the Game Over screen.
		 */

		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			SceneManager.LoadScene("GameOver"); //load the game over screen
		}

		
	}
}