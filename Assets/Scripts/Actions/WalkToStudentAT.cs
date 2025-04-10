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
            deskLocation = new Vector3(0.45f, 0.5f, -3.7f);
        }
		protected override void OnUpdate() {
			navAgent.SetDestination(deskLocation);
		}

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}