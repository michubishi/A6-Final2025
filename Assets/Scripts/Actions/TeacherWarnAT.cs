using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TeacherWarnAT : ActionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Warns the student with a speech bubble.
		 */

		public BBParameter<bool> isWarned;
		public GameObject warningSpeech;
		public float timePassed;
		protected override string OnInit() {
			return null;
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

	}
}