using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWorkAT : ActionTask {

		public BBParameter<GameObject> desk;
		public NavMeshAgent navAgent;
		public Vector3 deskLocation;

        protected override string OnInit() {
			return null;
		}

	
		protected override void OnExecute() {
			
		}

		protected override void OnUpdate() {
			deskLocation = new Vector3(-5.2f, 0.5f, 0);
			navAgent.SetDestination(deskLocation);
			if(navAgent.transform.position.z >= deskLocation.z)
			{
				navAgent.speed = 0;
				EndAction(true);
			}
		}

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}