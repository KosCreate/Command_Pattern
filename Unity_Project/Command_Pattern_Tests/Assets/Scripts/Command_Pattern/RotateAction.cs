using UnityEngine;

namespace CommandPattern
{
    public class RotateAction : ActionBase
    {
        private GameObject rotatingObject;
        private float rotationDuration;
        private Vector3 rotationTarget;
        public RotateAction(Unit unit, float rotationDuration, GameObject rotatingObject, Vector3 rotationTarget) : base(unit)
        {
            this.rotatingObject = rotatingObject;
            this.rotationDuration = rotationDuration;
            this.rotationTarget = rotationTarget;
        }
        public override void Execute()
        {
            unit.CustomRotation(rotatingObject, rotationDuration, rotationTarget);
        }

        public override void Undo()
        {
            unit.CustomRotation(rotatingObject, rotationDuration, -rotationTarget);
        }
    }
}