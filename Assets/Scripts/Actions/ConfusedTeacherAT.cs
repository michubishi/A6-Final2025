using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class WaitTeacherAT : ActionTask {

        public float elaspedTime;
        protected override string OnInit() {
			return null;
		}

		protected override void OnExecute() {
			
		}

		
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;
            if (elapsedTime >= 3)
            {
                elaspedTime = 0;
                EndAction(true);
            }
        }

		protected override void OnStop() {
			
		}

		protected override void OnPause() {
			
		}
	}
}