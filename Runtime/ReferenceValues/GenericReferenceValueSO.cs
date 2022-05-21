using UnityEngine;
using UnityEngine.Events;

namespace TheKnightsSanctuary.Core
{
    public abstract class GenericReferenceValueSO<T> : GenericEventChannelSO<T>
    {
        [SerializeField] protected T value;
        [SerializeField] private bool privateSet = false;
        virtual public T Value
        {
            get => value;
            set
            {
                if (privateSet)
                {
                    Debug.Log($"{this.name} has a private setter! Value remains unchanged!");
                    return;
                }
                this.value = value;
                RaiseEvent(value);
            }
        }

        public static implicit operator T(GenericReferenceValueSO<T> referenceValue) => referenceValue.value;

        public static GenericReferenceValueSO<T> operator +(GenericReferenceValueSO<T> channel, UnityAction<T> listener)
        {
            channel.onEventRaised += listener;
            return channel;
        }

        public static GenericReferenceValueSO<T> operator -(GenericReferenceValueSO<T> channel, UnityAction<T> listener)
        {
            channel.onEventRaised -= listener;
            return channel;
        }
    }
}