﻿using ProtoBuf;

namespace Protogame
{
    [NetworkMessage("entity:create"), ProtoContract]
    public class EntityCreateMessage : INetworkMessage
    {
        [ProtoMember(1)]
        public int EntityID;

        [ProtoMember(2)]
        public string EntityType;
    }
}