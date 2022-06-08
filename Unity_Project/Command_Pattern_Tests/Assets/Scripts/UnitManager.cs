using System.Collections;
using System.Collections.Generic;
using CommandPattern;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
   [SerializeField] private Unit unit;
   [SerializeField] private ActionRecorder _actionRecorder;

   [Header("Instantiation testing...")] 
   [SerializeField] private GameObject objectToInstantiate;

   [Header("Rotation testing...")] 
   [SerializeField] private GameObject objectToRotate;
   [SerializeField] private float rotationDuration;
   [SerializeField] private Vector3 rotationTarget;
   
   public void OnDebugLog()
   {
      DebugAction debugAction = new DebugAction(unit, "Testing If It Works");
      _actionRecorder.Record(debugAction);
   }

   public void OnInstantiateObject()
   {
      InstantiateAction instantiateAction = new InstantiateAction(unit, objectToRotate);
      _actionRecorder.Record(instantiateAction);
   }

   public void OnRotateObject()
   {
      RotateAction rotateAction = new RotateAction(unit, rotationDuration, objectToRotate, rotationTarget);
      _actionRecorder.Record(rotateAction);
   }

   public void Undo()
   {
      _actionRecorder.Undo();
   }
}
