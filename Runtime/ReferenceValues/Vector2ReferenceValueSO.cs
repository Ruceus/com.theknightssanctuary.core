using UnityEngine;

namespace TheKnightsSanctuary.Core
{
    [CreateAssetMenu(menuName = "Reference Values/Vector2 Reference Value", fileName = "Vector2Reference")]
    public class Vector2ReferenceValueSO : GenericReferenceValueSO<Vector2>
    {
        public static implicit operator Vector3(Vector2ReferenceValueSO referenceValue) => new Vector3(referenceValue.value.x, referenceValue.value.y, 0f);
    }
}