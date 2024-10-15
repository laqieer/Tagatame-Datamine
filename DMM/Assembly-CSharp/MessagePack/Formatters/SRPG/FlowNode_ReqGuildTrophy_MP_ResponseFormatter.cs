// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildTrophy_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF7")]
  public sealed class FlowNode_ReqGuildTrophy_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildTrophy.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A7E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A7F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A33")]
    [Address(RVA = "0xF1E470", Offset = "0xF1D270", VA = "0x10F1E470")]
    public FlowNode_ReqGuildTrophy_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002A34")]
    [Address(RVA = "0xF1E180", Offset = "0xF1CF80", VA = "0x10F1E180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildTrophy.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A35")]
    [Address(RVA = "0xF1DD50", Offset = "0xF1CB50", VA = "0x10F1DD50", Slot = "5")]
    public FlowNode_ReqGuildTrophy.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildTrophy.MP_Response) null;
    }
  }
}
