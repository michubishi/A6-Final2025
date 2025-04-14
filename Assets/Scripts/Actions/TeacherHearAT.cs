using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherHearAT : ActionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Action task. Makes the UI of the sus bubble appear.
		 */

        public BBParameter<int> foodSound;
        public BBParameter<GameObject> player;
        public BBParameter<int> eatingCounter;
		public GameObject susSpeech;

        public NavMeshAgent navAgent;
		public float elaspedTime;

		

        protected override string OnInit() {
			return null;
		}

		
		
		protected override void OnUpdate() {
			susSpeech.SetActive(true);
            elaspedTime += Time.deltaTime;
			foodSound.value += 10;
			Debug.Log(foodSound.value);
			navAgent.speed = 0;
			EndAction(true); 
		}

		

	}
}