﻿using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_Ladder : MyObjectBuilder_CubeBlock
    {
    }
}
