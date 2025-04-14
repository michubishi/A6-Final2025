using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWalkAT : ActionTask {

		public NavMeshAgent navAgent;
		public BBParameter<Vector3> location;
		public float locationX;
		public float locationZ;

		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			
		}

		protected override void OnUpdate() {
            navAgent.speed = 3;
			location = new Vector3(locationX, navAgent.transform.position.y, locationZ);
            navAgent.SetDestination(location.value);
			
			if(navAgent.transform.position == location.value)
			{
                EndAction(true);
            }
        }

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}