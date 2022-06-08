using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;
public class Unit : MonoBehaviour
{
    private CancellationTokenSource _tokenSource;
    private void Start()
    {
        _tokenSource = new CancellationTokenSource();
    }
    private void OnDisable()
    {
        _tokenSource.Cancel();
    }
    public void CustomDebug(string message)  {
        Debug.Log(message);
    }
    public void CustomInstantiation(GameObject instantiableGameObject)  {
        Instantiate(instantiableGameObject, transform.position + Random.insideUnitSphere * 10.0f, Quaternion.identity);
    }
    public async void CustomRotation(GameObject objectToRotate, float rotationDuration, Vector3 rotationTarget)  {
        float time = Time.time + rotationDuration;
        while (Time.time < time)
        {
            if (_tokenSource.IsCancellationRequested) return;
            objectToRotate.transform.Rotate(new Vector3(0.0f, rotationTarget.y * Time.deltaTime, 0.0f));
            await Task.Yield();
        }
    }
}