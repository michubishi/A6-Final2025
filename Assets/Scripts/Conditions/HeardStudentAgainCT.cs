using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class HeardStudentAgainCT : ConditionTask {

		public float elaspedTime;

		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			elaspedTime += Time.deltaTime;
			if (Input.GetKeyDown(KeyCode.E))
			{
				return true;
			}
			return false;
		}
	}
}