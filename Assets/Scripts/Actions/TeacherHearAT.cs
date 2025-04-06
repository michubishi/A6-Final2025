using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherHearAT : ActionTask {

        public BBParameter<int> foodSound;

        protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			
		}

		
		protected override void OnUpdate() {
			foodSound.value += 10;
			Debug.Log(foodSound.value);
			EndAction(true);
		}

		
		protected override void OnStop() {
			
		}

	
		protected override void OnPause() {
			
		}

		

	}
}