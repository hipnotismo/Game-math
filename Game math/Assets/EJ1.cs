using UnityEngine;
using CustomMath;

public class EJ1 : MonoBehaviour
{
    [SerializeField] float lerpSpeed = .2f;
    [SerializeField] int exerciseIndex = 1;
    [SerializeField] Vector3 vectorA;
    [SerializeField] Vector3 vectorB;

    Vec3 vecA = Vec3.Zero;
    Vec3 vecB = Vec3.Zero;
    Vec3 vecC = Vec3.Zero;

    float lerpTimeExercise5 = 0;

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

        switch (exerciseIndex)
        {
            case 1: // Suma de vectores
                vecC = vecA + vecB;
                break;
            case 2:
                vecC = vecB - vecA;
                break;
            case 3:
                vecC = new Vec3(vecA.x * vecB.x, vecA.y * vecB.y, vecA.z * vecB.z);
                break;
            case 4:
                vecC = -Vec3.Cross(vecA, vecB);
                break;
            case 5:
                lerpTimeExercise5 = lerpTimeExercise5 > 1 ? 0 : lerpTimeExercise5 + Time.deltaTime;

                vecC = Vec3.Lerp(vecA, vecB, lerpTimeExercise5);
                break;
            case 6:
                vecC = Vec3.Max(vecA, vecB);
                break;
            case 7:
                vecC = Vec3.Project(vecA, vecB);
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
