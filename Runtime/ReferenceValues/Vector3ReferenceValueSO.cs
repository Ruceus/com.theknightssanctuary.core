using UnityEngine;
using UnityEngine.Events;

namespace TheKnightsSanctuary.Core
{
    [CreateAssetMenu(menuName = "Reference Values/Vector3 Reference Value", fileName = "Vector3Reference")]
    public class Vector3ReferenceValueSO : GenericReferenceValueSO<Vector3>
    {
        public static Vector3ReferenceValueSO operator +(Vector3ReferenceValueSO channel, UnityAction<Vector3> listener)
        {
            channel.onEventRaised += listener;
            return channel;
        }

        public static Vector3ReferenceValueSO operator -(Vector3ReferenceValueSO channel, UnityAction<Vector3> listener)
        {
            channel.onEventRaised -= listener;
            return channel;
        }
    }
}
