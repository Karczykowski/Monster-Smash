[System.Serializable]
public class AttributeInfo
{
    public AttributeType type;
    public float value;
    public float minValue;
    public float maxValue;

    public AttributeInfo(AttributeType type, float value, float minValue = 0, float maxValue = 99)
    {
        this.type = type;
        this.value = value;
        this.minValue = minValue;
        this.maxValue = maxValue;
    }
}
