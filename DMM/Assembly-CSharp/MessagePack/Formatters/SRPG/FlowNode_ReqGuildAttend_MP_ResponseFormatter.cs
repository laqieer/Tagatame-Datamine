// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqGuildAttend_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A1C")]
  public sealed class FlowNode_ReqGuildAttend_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqGuildAttend.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018C8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018C9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027A2")]
    [Address(RVA = "0xE99C10", Offset = "0xE98A10", VA = "0x10E99C10")]
    public FlowNode_ReqGuildAttend_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x60027A3")]
    [Address(RVA = "0xE99920", Offset = "0xE98720", VA = "0x10E99920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqGuildAttend.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027A4")]
    [Address(RVA = "0xE994F0", Offset = "0xE982F0", VA = "0x10E994F0", Slot = "5")]
    public FlowNode_ReqGuildAttend.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqGuildAttend.MP_Response) null;
    }
  }
}
