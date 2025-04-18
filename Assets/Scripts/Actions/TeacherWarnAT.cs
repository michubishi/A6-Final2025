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
			warningSpeech.SetActive(true); //make the UI visible 
            timePassed += Time.deltaTime;

			if(elapsedTime >= 6) //if it has been 6 seconds
			{
				isWarned.value = true; //the student has been warned
				warningSpeech.SetActive(false); //turn the UI off
                timePassed = 0; //reset the timer
				EndAction(true);
			}
		}

	}
}