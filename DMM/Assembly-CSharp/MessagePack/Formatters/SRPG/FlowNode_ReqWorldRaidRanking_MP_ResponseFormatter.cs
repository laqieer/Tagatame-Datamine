// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqWorldRaidRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009AF")]
  public sealed class FlowNode_ReqWorldRaidRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqWorldRaidRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600265B")]
    [Address(RVA = "0xE39420", Offset = "0xE38220", VA = "0x10E39420")]
    public FlowNode_ReqWorldRaidRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600265C")]
    [Address(RVA = "0xE39130", Offset = "0xE37F30", VA = "0x10E39130", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqWorldRaidRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600265D")]
    [Address(RVA = "0xE38D00", Offset = "0xE37B00", VA = "0x10E38D00", Slot = "5")]
    public FlowNode_ReqWorldRaidRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqWorldRaidRanking.MP_Response) null;
    }
  }
}
