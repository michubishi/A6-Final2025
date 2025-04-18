using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWalkAT : ActionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Sets the teacher to walk to a specified area.
		 */

		public NavMeshAgent navAgent;
		public BBParameter<Vector3> location;
		public float locationX;
		public float locationZ;

		protected override string OnInit() {
			return null;
		}

		protected override void OnUpdate() {
            navAgent.speed = 3;
			location = new Vector3(locationX, navAgent.transform.position.y, locationZ); //set specified area
            navAgent.SetDestination(location.value); //go to the area
			
			if(navAgent.transform.position == location.value) //checks if the teacher reaches the area 
			{
                EndAction(true);
            }
        }

	}
}