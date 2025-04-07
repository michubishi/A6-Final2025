using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class CallTeacherAT : ActionTask {

		public BBParameter<bool> askedHelp;
		public float elaspedTime;
		
		protected override string OnInit() {
			return null;
		}

		
		protected override void OnExecute() {
			
		}

		
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;
            askedHelp.value = true;
            if (elapsedTime > 10)
			{
				askedHelp.value = false;
                EndAction(true);
            }
			
			
		}

		
		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}