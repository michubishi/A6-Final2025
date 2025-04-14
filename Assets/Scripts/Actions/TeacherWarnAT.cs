using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWarnAT : ActionTask {

		public BBParameter<bool> isWarned;
		public GameObject warningSpeech;
		public float timePassed;
		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			//isWarned.value = true;
			//EndAction(true);
		}

		protected override void OnUpdate() {
			warningSpeech.SetActive(true);
            timePassed += Time.deltaTime;

			if(elapsedTime >= 6)
			{
				isWarned.value = true;
				warningSpeech.SetActive(false);
                timePassed = 0;
				EndAction(true);
			}
		}

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}