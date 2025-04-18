using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class StopMovingAT : ActionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Stops the teacher from moving. It checks if the player eats again.
		 */

		public NavMeshAgent navAgent;
		public BBParameter<bool> ateAgain;
		public float elaspedTime;
		public GameObject susSpeech;

		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			navAgent.speed = 0; //stop the teacher
		}

	
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;

			if (Input.GetKeyDown(KeyCode.E)) //if the player attempts to eat
			{
                susSpeech.SetActive(false); //the UI pops up that shows the teacher being confused
                ateAgain.value = true; 
				EndAction(true);
			}
			

			if(elaspedTime >= 3) //or, if it has been 3 seconds
			{
				susSpeech.SetActive(false); //turn off the speech
				EndAction(true);
			}
			
		}

	}
}