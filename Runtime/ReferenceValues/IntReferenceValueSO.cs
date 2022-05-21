using UnityEngine;
using UnityEngine.Events;

namespace TheKnightsSanctuary.Core
{
    [CreateAssetMenu(menuName = "Reference Values/Int Reference Value", fileName = "IntReference")]
    public class IntReferenceValueSO : GenericReferenceValueSO<int>
    {
        public static IntReferenceValueSO operator +(IntReferenceValueSO channel, UnityAction<int> listener)
        {
            channel.onEventRaised += listener;
            return channel;
        }

        public static IntReferenceValueSO operator -(IntReferenceValueSO channel, UnityAction<int> listener)
        {
            channel.onEventRaised -= listener;
            return channel;
        }
    }
}
