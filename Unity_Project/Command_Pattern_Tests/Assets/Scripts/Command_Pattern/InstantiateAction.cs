using UnityEngine;

namespace CommandPattern
{
    public class InstantiateAction : ActionBase
    {
        private GameObject objectToInstantiate;
        public InstantiateAction(Unit unit, GameObject objectToInstantiate) : base(unit)
        {
            this.objectToInstantiate = objectToInstantiate;
        }

        public override void Execute()  {
            unit.CustomInstantiation(objectToInstantiate);
        }

        public override void Undo()
        {
            unit.CustomInstantiation(objectToInstantiate);
        }
    }
}