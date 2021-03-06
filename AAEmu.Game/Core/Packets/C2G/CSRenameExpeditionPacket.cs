using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRenameExpeditionPacket : GamePacket
    {
        public CSRenameExpeditionPacket() : base(0x009, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var id = stream.ReadUInt32(); // type(id)
            var name = stream.ReadString();

            _log.Debug("RenameExpedition, Id: {0}, Name: {1}", id, name);
        }
    }
}
