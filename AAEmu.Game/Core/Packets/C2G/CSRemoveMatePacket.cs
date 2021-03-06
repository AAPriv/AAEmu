using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRemoveMatePacket : GamePacket
    {
        public CSRemoveMatePacket() : base(0x0a2, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var tl = stream.ReadUInt16();
            
            _log.Warn("RemoveMate, TlId: {0}", tl);
        }
    }
}
