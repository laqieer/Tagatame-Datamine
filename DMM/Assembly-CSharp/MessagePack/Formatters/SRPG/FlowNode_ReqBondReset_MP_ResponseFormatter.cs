// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqBondReset_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B41")]
  public sealed class FlowNode_ReqBondReset_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqBondReset.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001B12")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001B13")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002B11")]
    [Address(RVA = "0xF5ED20", Offset = "0xF5DB20", VA = "0x10F5ED20")]
    public FlowNode_ReqBondReset_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002B12")]
    [Address(RVA = "0xF5EA30", Offset = "0xF5D830", VA = "0x10F5EA30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqBondReset.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002B13")]
    [Address(RVA = "0xF5E600", Offset = "0xF5D400", VA = "0x10F5E600", Slot = "5")]
    public FlowNode_ReqBondReset.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqBondReset.MP_Response) null;
    }
  }
}
