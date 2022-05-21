using UnityEngine;
using UnityEngine.Events;

namespace TheKnightsSanctuary.Core
{
    [CreateAssetMenu(menuName = "Reference Values/String Reference Value", fileName = "StringReference")]
    public class StringReferenceValueSO : GenericReferenceValueSO<string>
    {
        public static StringReferenceValueSO operator +(StringReferenceValueSO channel, UnityAction<string> listener)
        {
            channel.onEventRaised += listener;
            return channel;
        }

        public static StringReferenceValueSO operator -(StringReferenceValueSO channel, UnityAction<string> listener)
        {
            channel.onEventRaised -= listener;
            return channel;
        }
    }
}
