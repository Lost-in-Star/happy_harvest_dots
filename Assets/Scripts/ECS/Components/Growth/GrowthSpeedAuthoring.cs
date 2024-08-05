using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class GrowthSpeedAuthoring : MonoBehaviour
{
    public float growthSpeed;
}

public class GrowthSpeedBaker : Baker<GrowthSpeedAuthoring>
{
    public override void Bake(GrowthSpeedAuthoring authoring)
    {
        var entity = GetEntity(TransformUsageFlags.Dynamic);
        AddComponent(entity, new GrowthSpeed
        {
            Value = authoring.growthSpeed
        });
    }
}
