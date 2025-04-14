using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class HeardStudentAT : ActionTask {

		public NavMeshAgent navAgent;
		public Vector3 studentLocation;
		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			navAgent.speed = 3;
		}

		
		protected override void OnUpdate() {
			studentLocation = new Vector3(0.8f, 0.5f, 3);
			navAgent.SetDestination(studentLocation);
			EndAction(true);
		}

	}
}