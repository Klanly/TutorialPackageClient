//This code create by CodeEngine

using System;
 using Module.Log;
 using Google.ProtocolBuffers;
 using System.Collections;
namespace SPacket.SocketInstance
 {
 public class CG_ASK_LOUDSPEAKER_POOLHandler : Ipacket
 {
 public uint Execute(PacketDistributed ipacket)
 {
 CG_ASK_LOUDSPEAKER_POOL packet = (CG_ASK_LOUDSPEAKER_POOL )ipacket;
 if (null == packet) return (uint)PACKET_EXE.PACKET_EXE_ERROR;
 //enter your logic
 return (uint)PACKET_EXE.PACKET_EXE_CONTINUE;
 }
 }
 }