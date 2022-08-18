using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class Save 
{
    [DataMember]
    public float posx;
    [DataMember]
    public float posy;
    [DataMember]
    public float posz;
    [DataMember]
    public float rotx;
    [DataMember]
    public float roty;
    [DataMember]
    public float rotz;
    [DataMember]
    public float timing;
    [DataMember]
    public float item1x = 0;
    [DataMember]
    public float item1y = 0;
    [DataMember]
    public float item1z = 0;
    [DataMember]
    public float item2x = 0;
    [DataMember]
    public float item2y = 0;
    [DataMember]
    public float item2z = 0;
    [DataMember]
    public float item3x = 0;
    [DataMember]
    public float item3y = 0;
    [DataMember]
    public float item3z = 0;
    [DataMember]
    public float item4x = 0;
    [DataMember]
    public float item4y = 0;
    [DataMember]
    public float item4z = 0;
    [DataMember]
    public float item5x = 0;
    [DataMember]
    public float item5y = 0;
    [DataMember]
    public float item5z = 0;
}
