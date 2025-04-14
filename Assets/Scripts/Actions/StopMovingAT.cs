using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class StopMovingAT : ActionTask {

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

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}