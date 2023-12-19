using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[System.Serializable]
public class Attributes
{
    public List<AttributeInfo> attributes = new List<AttributeInfo>();

    public Attributes(List<AttributeInfo> attributes)
    {
        this.attributes = attributes;
    }

    public Attributes CloneAttributes()
    {
        return new Attributes(new List<AttributeInfo>(attributes));
    }

    public void CombineAttributes(Attributes other) 
    {
        foreach (AttributeInfo attrib in other.attributes)
        {
            AddAttribute(attrib.type, attrib.value);
        }
    }

    public void AddAttribute(AttributeType type, float value)
    {
        foreach (AttributeInfo attribute in attributes)
        {
            if (attribute.type == type)
            {
                attribute.value += value;
                attribute.value = Mathf.Clamp(attribute.value, attribute.minValue, attribute.maxValue);
                return;
            }
        }

        AttributeInfo newAttribute = new AttributeInfo(type, value);
        newAttribute.value = Mathf.Clamp(newAttribute.value, newAttribute.minValue, newAttribute.maxValue);
        attributes.Add(newAttribute);
    }

    public float GetAttribute(AttributeType type)
    {
        foreach (AttributeInfo attribute in attributes)
        {
            if (attribute.type == type)
                return attribute.value;
        }

        return 0;
    }

    public float GetMinimum(AttributeType type)
    {
        foreach (AttributeInfo attribute in attributes)
        {
            if (attribute.type == type)
                return attribute.minValue;
        }

        return 0;
    }

    public float GetMaximum(AttributeType type)
    {
        foreach (AttributeInfo attribute in attributes)
        {
            if (attribute.type == type)
                return attribute.maxValue;
        }

        return 0;
    }
}
