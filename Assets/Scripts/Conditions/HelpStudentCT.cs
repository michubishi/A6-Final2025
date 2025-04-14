using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class HelpStudentCT : ConditionTask {

		public BBParameter<bool> askedHelp;
		protected override string OnInit(){
			return null;
		}
		protected override bool OnCheck() {
			if(askedHelp.value == true)
			{
				return true;
			}
			return false;
		}
	}
}