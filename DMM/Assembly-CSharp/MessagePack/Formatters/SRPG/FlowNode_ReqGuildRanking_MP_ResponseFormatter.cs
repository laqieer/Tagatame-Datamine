// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000944")]
  public sealed class FlowNode_ReqGuildRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001718")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001719")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600251A")]
    [Address(RVA = "0xE0EEF0", Offset = "0xE0DCF0", VA = "0x10E0EEF0")]
    public FlowNode_ReqGuildRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600251B")]
    [Address(RVA = "0xE0EC00", Offset = "0xE0DA00", VA = "0x10E0EC00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600251C")]
    [Address(RVA = "0xE0E7D0", Offset = "0xE0D5D0", VA = "0x10E0E7D0", Slot = "5")]
    public FlowNode_ReqGuildRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRanking.MP_Response) null;
    }
  }
}
