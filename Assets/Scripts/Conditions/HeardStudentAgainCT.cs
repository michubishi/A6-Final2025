using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class HeardStudentAgainCT : ConditionTask {

		public BBParameter<bool> ateAgain;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if (ateAgain.value == true)
			{
				ateAgain.value = false;
				return true;
			}
			return false;
		}
	}
}