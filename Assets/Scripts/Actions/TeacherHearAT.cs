using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherHearAT : ActionTask {

        public BBParameter<int> foodSound;
        public BBParameter<GameObject> player;
        public BBParameter<int> eatingCounter;

        public NavMeshAgent navAgent;
		public float elaspedTime;

		

        protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			
		}

		
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;
			foodSound.value += 10;
			Debug.Log(foodSound.value);
			navAgent.speed = 0;
			EndAction(true); 
		}

		
		protected override void OnStop() {
			
		}

	
		protected override void OnPause() {
			
		}

		

	}
}