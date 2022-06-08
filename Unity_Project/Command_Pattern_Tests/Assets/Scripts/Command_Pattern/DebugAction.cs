using UnityEngine;

namespace CommandPattern  {
    public class DebugAction : ActionBase
    {
        private string msg;
        public DebugAction(Unit unit,string msg) : base(unit)
        {
            this.msg = msg;
        }
        public override void Execute()
        {
            unit.CustomDebug(msg);
        }

        public override void Undo()
        {
            unit.CustomDebug(msg);
        }
    }
}