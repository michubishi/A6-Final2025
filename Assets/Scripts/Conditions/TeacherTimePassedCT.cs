using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class TeacherTimePassedCT : ConditionTask {

		/**
		 * Author: Michelle Vuong
		 * Description: Checks if it has been 17 seconds to enable the working mode for the teacher.
		 */

		public BBParameter<float> deskTimer;

		protected override string OnInit(){
			return null;
		}
		
		protected override bool OnCheck() {
			deskTimer.value += Time.deltaTime;

			if(deskTimer.value >= 17)
			{
				deskTimer.value = 0;
				return true;
			}
			return false;
		}

	}
}