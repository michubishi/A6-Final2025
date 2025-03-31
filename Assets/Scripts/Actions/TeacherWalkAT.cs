using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWalkAT : ActionTask {

		public NavMeshAgent navAgent;
		public BBParameter<Vector3> location;

		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			
		}

		protected override void OnUpdate() {
			navAgent.SetDestination(location.value);



			if(navAgent.transform.position.x == location.value.x)
			{
				Debug.Log("Persona");
                EndAction(true);
            }
        }

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}