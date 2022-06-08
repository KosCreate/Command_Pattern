using System.ComponentModel;
using UnityEngine;

namespace CommandPattern  {
    public abstract class ActionBase
    {
        protected readonly Unit unit;
        protected ActionBase(Unit unit)
        {
            this.unit = unit;
        }
        public abstract void Execute();
        public abstract void Undo();
    }
}