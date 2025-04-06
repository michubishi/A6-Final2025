using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class WaitAT : ActionTask {


        public float elaspedTime;
        public float timePassed;

        protected override string OnInit()
        {
            return null;
        }


        protected override void OnExecute()
        {

        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {
            elaspedTime += Time.deltaTime;
            if (elaspedTime > timePassed)
            {
                elaspedTime = 0;
                EndAction(true);
            }
        }

    }
}