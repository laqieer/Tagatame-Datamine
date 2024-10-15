// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildRaidTraining_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200093D")]
  public sealed class FlowNode_ReqGuildRaidTraining_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildRaidTraining.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400170A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400170B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002505")]
    [Address(RVA = "0xE0E4A0", Offset = "0xE0D2A0", VA = "0x10E0E4A0")]
    public FlowNode_ReqGuildRaidTraining_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002506")]
    [Address(RVA = "0xE0E1B0", Offset = "0xE0CFB0", VA = "0x10E0E1B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildRaidTraining.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002507")]
    [Address(RVA = "0xE0DD80", Offset = "0xE0CB80", VA = "0x10E0DD80", Slot = "5")]
    public FlowNode_ReqGuildRaidTraining.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildRaidTraining.MP_Response) null;
    }
  }
}
