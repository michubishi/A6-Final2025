using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Actions {

	public class GameOverAT : ActionTask {

		
		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			SceneManager.LoadScene("GameOver");
		}

		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}