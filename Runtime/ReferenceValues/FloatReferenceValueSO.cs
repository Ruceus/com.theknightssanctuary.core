using UnityEngine;
using UnityEngine.Events;

namespace TheKnightsSanctuary.Core
{
    [CreateAssetMenu(menuName = "Reference Values/Float Reference Value", fileName = "FloatReference")]
    public class FloatReferenceValueSO : GenericReferenceValueSO<float>
    {
        public static FloatReferenceValueSO operator +(FloatReferenceValueSO channel, UnityAction<float> listener)
        {
            channel.onEventRaised += listener;
            return channel;
        }

        public static FloatReferenceValueSO operator -(FloatReferenceValueSO channel, UnityAction<float> listener)
        {
            channel.onEventRaised -= listener;
            return channel;
        }
    }
}
