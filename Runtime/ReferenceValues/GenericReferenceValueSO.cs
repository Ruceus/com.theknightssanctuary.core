using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace TheKnightsSanctuary.Core
{
    public class GenericReferenceValueSO<T> : GenericEventChannelSO<T>
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
            }
        }

        public static implicit operator T(GenericReferenceValueSO<T> referenceValue) => referenceValue.value;
    }
}