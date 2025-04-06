using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class TeacherTimePassedCT : ConditionTask {

		public BBParameter<float> deskTimer;

		protected override string OnInit(){
			return null;
		}

		
		protected override void OnEnable() {

		}

		
		protected override void OnDisable() {
			
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