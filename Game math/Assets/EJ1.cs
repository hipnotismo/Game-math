using UnityEngine;
using CustomMath;

public class EJ1 : MonoBehaviour
{
    [SerializeField, Range(.1f, 1)] float lerpSpeed = .2f;
    [SerializeField, Range(1, 10)] int exerciseIndex = 1;
    [SerializeField] Vector3 vectorA;
    [SerializeField] Vector3 vectorB;

    Vec3 vecA = Vec3.Zero;
    Vec3 vecB = Vec3.Zero;
    Vec3 vecC = Vec3.Zero;

    float lerpTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        MathDebbuger.Vector3Debugger.AddVector(transform.position, transform.position + vecA, Color.red, "VectorA");
        MathDebbuger.Vector3Debugger.AddVector(transform.position, transform.position + vecB, Color.green, "VectorB");
        MathDebbuger.Vector3Debugger.AddVector(transform.position, transform.position + vecC, Color.blue, "VectorC");
        MathDebbuger.Vector3Debugger.EnableEditorView();
    }

    private void OnValidate()
    {
        if (Application.isPlaying)
        {
            vecA = new Vec3(vectorA);
            vecB = new Vec3(vectorB);
        }
    }

    // Update is called once per frame
    void Update()
    {
        lerpTime = lerpTime > 1 ? 0 : lerpTime + Time.deltaTime * lerpSpeed;

        switch (exerciseIndex)
        {
            case 1: // Suma de vectores
                vecC = vecA + vecB;
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
            case 7:
                break;
            case 8:
                break;
            case 9:
                break;
            case 10:
                break;
        }

        MathDebbuger.Vector3Debugger.UpdatePosition("VectorA", transform.position, transform.position + vecA);
        MathDebbuger.Vector3Debugger.UpdatePosition("VectorB", transform.position, transform.position + vecB);
        MathDebbuger.Vector3Debugger.UpdatePosition("VectorC", transform.position, transform.position + vecC);
    }
}
