using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class CallTeacherAT : ActionTask {

		public BBParameter<bool> askedHelp;
		
		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			
		}

		
		protected override void OnUpdate() {
			askedHelp.value = true;
			EndAction(true);
		}

		
		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}