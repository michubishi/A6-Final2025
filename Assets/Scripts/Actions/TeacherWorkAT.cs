using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWorkAT : ActionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Action task. Makes the teacher go to the desk.
		 */

		public BBParameter<GameObject> desk;
		public NavMeshAgent navAgent;
		public GameObject deskSpeech;
		public Vector3 deskLocation;
		public float deskLocationX;
		public float deskLocationZ;

        protected override string OnInit() {
			return null;
		}

		protected override void OnUpdate() {
			
			deskSpeech.SetActive(true); //show the desk speech of the teacher.
            deskLocation = new Vector3(deskLocationX, navAgent.transform.position.y, deskLocationZ); //set desk location
			navAgent.SetDestination(deskLocation); //move to desk location
			if(navAgent.transform.position == deskLocation) //if they reach their location
			{
				deskSpeech.SetActive(false); //turn off the speech
				navAgent.speed = 0; //stop moving
			}
		}

	}
}