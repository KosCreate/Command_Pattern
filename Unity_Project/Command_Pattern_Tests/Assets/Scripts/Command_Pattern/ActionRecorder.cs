using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern
{
    public class ActionRecorder : MonoBehaviour
    {
        private readonly Stack<ActionBase> actionsStack = new Stack<ActionBase>();
        public void Record(ActionBase action)  {
            actionsStack.Push(action);
            action.Execute();
        }
        public void Undo()
        {
            ActionBase action = actionsStack.Pop();
            action.Undo();
        }
    }
}