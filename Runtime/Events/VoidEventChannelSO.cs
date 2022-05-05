using UnityEngine;
using UnityEngine.Events;

namespace TheKnightsSanctuary.Core
{
    [CreateAssetMenu(menuName = "Events/Event Channel/Void Event Channel")]
    public class VoidEventChannelSO : ScriptableObject
    {
        private UnityAction onEventRaised;
        public void RaiseEvent()
        {
            if (onEventRaised != null)
            {
                onEventRaised.Invoke();
            }
            else
            {
                Debug.LogWarning($"Void Event Channel {name} has no listeners");
            }
        }

        public static VoidEventChannelSO operator +(VoidEventChannelSO channel, UnityAction listener)
        {
            channel.onEventRaised += listener;
            return channel;
        }

        public static VoidEventChannelSO operator -(VoidEventChannelSO channel, UnityAction listener)
        {
            channel.onEventRaised -= listener;
            return channel;
        }
    }
}