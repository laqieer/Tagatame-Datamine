// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidBtlLog_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC0")]
  public sealed class FlowNode_ReqGuildRaidBtlLog_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidBtlLog.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A10")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A11")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600298E")]
    [Address(RVA = "0xF078F0", Offset = "0xF066F0", VA = "0x10F078F0")]
    public FlowNode_ReqGuildRaidBtlLog_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600298F")]
    [Address(RVA = "0xF07600", Offset = "0xF06400", VA = "0x10F07600", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidBtlLog.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002990")]
    [Address(RVA = "0xF071D0", Offset = "0xF05FD0", VA = "0x10F071D0", Slot = "5")]
    public FlowNode_ReqGuildRaidBtlLog.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidBtlLog.MP_Response) null;
    }
  }
}
