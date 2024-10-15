// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidMail_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A9A")]
  public sealed class FlowNode_ReqGuildRaidMail_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidMail.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600291C")]
    [Address(RVA = "0xEED470", Offset = "0xEEC270", VA = "0x10EED470")]
    public FlowNode_ReqGuildRaidMail_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600291D")]
    [Address(RVA = "0xEED180", Offset = "0xEEBF80", VA = "0x10EED180", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidMail.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600291E")]
    [Address(RVA = "0xEECD50", Offset = "0xEEBB50", VA = "0x10EECD50", Slot = "5")]
    public FlowNode_ReqGuildRaidMail.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidMail.MP_Response) null;
    }
  }
}
