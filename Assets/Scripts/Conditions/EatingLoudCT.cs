using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class EatingLoudCT : ConditionTask {

		public BBParameter<float> heardSound;
		
		protected override string OnInit(){
			return null;
		}

		protected override bool OnCheck() {
			if(heardSound.value >= 80)
			{
				return true;
			}
			return false;
		}
	}
}