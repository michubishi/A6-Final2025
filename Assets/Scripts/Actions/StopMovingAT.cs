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
			navAgent.speed = 0;
		}

	
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;

			if (Input.GetKeyDown(KeyCode.E))
			{
                susSpeech.SetActive(false);
                ateAgain.value = true;
				EndAction(true);
			}
			

			if(elaspedTime >= 3)
			{
				susSpeech.SetActive(false);
				EndAction(true);
			}
			
		}

	}
}