// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGvGParty_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC8")]
  public sealed class FlowNode_ReqGvGParty_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGvGParty.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A20")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A21")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029A6")]
    [Address(RVA = "0xF097E0", Offset = "0xF085E0", VA = "0x10F097E0")]
    public FlowNode_ReqGvGParty_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60029A7")]
    [Address(RVA = "0xF094F0", Offset = "0xF082F0", VA = "0x10F094F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGvGParty.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029A8")]
    [Address(RVA = "0xF090C0", Offset = "0xF07EC0", VA = "0x10F090C0", Slot = "5")]
    public FlowNode_ReqGvGParty.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGvGParty.MP_Response) null;
    }
  }
}
