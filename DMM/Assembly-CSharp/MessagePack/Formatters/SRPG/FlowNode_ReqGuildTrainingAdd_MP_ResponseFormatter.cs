// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildTrainingAdd_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B1D")]
  public sealed class FlowNode_ReqGuildTrainingAdd_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildTrainingAdd.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ACA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ACB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002AA5")]
    [Address(RVA = "0xF34710", Offset = "0xF33510", VA = "0x10F34710")]
    public FlowNode_ReqGuildTrainingAdd_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002AA6")]
    [Address(RVA = "0xF34420", Offset = "0xF33220", VA = "0x10F34420", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildTrainingAdd.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AA7")]
    [Address(RVA = "0xF33FF0", Offset = "0xF32DF0", VA = "0x10F33FF0", Slot = "5")]
    public FlowNode_ReqGuildTrainingAdd.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildTrainingAdd.MP_Response) null;
    }
  }
}
