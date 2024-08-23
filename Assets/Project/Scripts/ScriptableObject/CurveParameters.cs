using UnityEngine;

[CreateAssetMenu(fileName = "New Curve Parameter", menuName = "Data/Curve Parameter")]
public class CurveParameters : ScriptableObject
{
    public AnimationCurve positioning;
    public float positioningInfluence = .1f;
    public AnimationCurve rotation;
    public float rotationInfluence = 10f;
}
