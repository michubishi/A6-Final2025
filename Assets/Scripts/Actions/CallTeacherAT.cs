using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class CallTeacherAT : ActionTask {

		public BBParameter<bool> askedHelp;
		public GameObject helpSpeech;
		public float elaspedTime;
		public GameObject thankSpeech;
		
		protected override string OnInit() {
			return null;
		}
		
		protected override void OnUpdate() {
            elaspedTime += Time.deltaTime;
			helpSpeech.SetActive(true);
            askedHelp.value = true;

			if(elapsedTime > 8)
			{
                helpSpeech.SetActive(false);
                thankSpeech.SetActive(true);
			}

            if (elapsedTime > 10)
			{
				thankSpeech.SetActive(false);
				askedHelp.value = false;
                EndAction(true);
            }
			
			
		}

	}
}