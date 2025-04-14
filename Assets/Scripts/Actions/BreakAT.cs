using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class BreakAT : ActionTask {

		/*
		 * Author: Michelle Vuong
		 * Description: Action Task (AT). This AT is used for the student AI. The student runs off away from the player to take a break from work.
		 */

		public NavMeshAgent navAgent;
		public Vector3 chalkboardLocation;
		public float chalkboardX;
        public float chalkboardZ;
		public GameObject breakSpeech;
        protected override string OnInit() {
			return null;
		}

	
		protected override void OnExecute() {

		}

		protected override void OnUpdate() {
			chalkboardLocation = new Vector3(chalkboardX, navAgent.transform.position.y, chalkboardZ); //set the destination to walk too
			breakSpeech.SetActive(true); //show the speech bubble
			navAgent.SetDestination(chalkboardLocation); //move to the set destination

			if(navAgent.transform.position == chalkboardLocation) //if the student has made it to the location
			{
				breakSpeech.SetActive(false);
				EndAction(true);
			}
		}

		protected override void OnStop() {
			
		}

		
		protected override void OnPause() {
			
		}
	}
}