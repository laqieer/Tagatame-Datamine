// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqLeagueMatchMission_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AE8")]
  public sealed class FlowNode_ReqLeagueMatchMission_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqLeagueMatchMission.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A60")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A61")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A06")]
    [Address(RVA = "0xF20360", Offset = "0xF1F160", VA = "0x10F20360")]
    public FlowNode_ReqLeagueMatchMission_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A07")]
    [Address(RVA = "0xF20070", Offset = "0xF1EE70", VA = "0x10F20070", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqLeagueMatchMission.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A08")]
    [Address(RVA = "0xF1FC40", Offset = "0xF1EA40", VA = "0x10F1FC40", Slot = "5")]
    public FlowNode_ReqLeagueMatchMission.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqLeagueMatchMission.MP_Response) null;
    }
  }
}
