using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class WalkToStudentAT : ActionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Walks to the player's desk.
		 */


		public NavMeshAgent navAgent;
		public Vector3 deskLocation;
		
		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			navAgent.speed = 5; //make the teacher faster
            deskLocation = new Vector3(2f, navAgent.transform.position.y, -4f); //set the player desk location
        }
		protected override void OnUpdate() {
			navAgent.SetDestination(deskLocation); //go to the player's desk

			if (navAgent.transform.position == deskLocation) //checks if the teacher has reached the player desk location
			{
				EndAction(true);
			}
		}

	}
}