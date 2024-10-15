// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqRuneFavorite_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A5A")]
  public sealed class FlowNode_ReqRuneFavorite_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqRuneFavorite.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001944")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001945")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600285C")]
    [Address(RVA = "0xEC3860", Offset = "0xEC2660", VA = "0x10EC3860")]
    public FlowNode_ReqRuneFavorite_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x600285D")]
    [Address(RVA = "0xEC3570", Offset = "0xEC2370", VA = "0x10EC3570", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqRuneFavorite.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600285E")]
    [Address(RVA = "0xEC3140", Offset = "0xEC1F40", VA = "0x10EC3140", Slot = "5")]
    public FlowNode_ReqRuneFavorite.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqRuneFavorite.MP_Response) null;
    }
  }
}
