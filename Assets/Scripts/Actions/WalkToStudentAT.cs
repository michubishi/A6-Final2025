using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class WalkToStudentAT : ActionTask {

		public NavMeshAgent navAgent;
		public Vector3 deskLocation;
		
		protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			navAgent.speed = 5;
            deskLocation = new Vector3(2f, navAgent.transform.position.y, -4f);
        }
		protected override void OnUpdate() {
			navAgent.SetDestination(deskLocation);

			if (navAgent.transform.position == deskLocation)
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