// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidRanking_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200091B")]
  public sealed class FlowNode_ReqGuildRaidRanking_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidRanking.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016C6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016C7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600249F")]
    [Address(RVA = "0xDF5D50", Offset = "0xDF4B50", VA = "0x10DF5D50")]
    public FlowNode_ReqGuildRaidRanking_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024A0")]
    [Address(RVA = "0xDF5A60", Offset = "0xDF4860", VA = "0x10DF5A60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidRanking.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024A1")]
    [Address(RVA = "0xDF5630", Offset = "0xDF4430", VA = "0x10DF5630", Slot = "5")]
    public FlowNode_ReqGuildRaidRanking.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidRanking.MP_Response) null;
    }
  }
}
