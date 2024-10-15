// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidTrainingBtlLog_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200092C")]
  public sealed class FlowNode_ReqGuildRaidTrainingBtlLog_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidTrainingBtlLog.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016E8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016E9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024D2")]
    [Address(RVA = "0xDF67A0", Offset = "0xDF55A0", VA = "0x10DF67A0")]
    public FlowNode_ReqGuildRaidTrainingBtlLog_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024D3")]
    [Address(RVA = "0xDF64B0", Offset = "0xDF52B0", VA = "0x10DF64B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidTrainingBtlLog.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024D4")]
    [Address(RVA = "0xDF6080", Offset = "0xDF4E80", VA = "0x10DF6080", Slot = "5")]
    public FlowNode_ReqGuildRaidTrainingBtlLog.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidTrainingBtlLog.MP_Response) null;
    }
  }
}
