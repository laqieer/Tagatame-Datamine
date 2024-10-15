// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventureEnd_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B30")]
  public sealed class FlowNode_ReqAdventureEnd_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventureEnd.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AF0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AF1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002ADE")]
    [Address(RVA = "0xF5E2D0", Offset = "0xF5D0D0", VA = "0x10F5E2D0")]
    public FlowNode_ReqAdventureEnd_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002ADF")]
    [Address(RVA = "0xF5DFE0", Offset = "0xF5CDE0", VA = "0x10F5DFE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventureEnd.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002AE0")]
    [Address(RVA = "0xF5DBB0", Offset = "0xF5C9B0", VA = "0x10F5DBB0", Slot = "5")]
    public FlowNode_ReqAdventureEnd.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventureEnd.MP_Response) null;
    }
  }
}
