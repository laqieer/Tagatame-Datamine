// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqAdventureParty_MP_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AB2")]
  public sealed class FlowNode_ReqAdventureParty_MP_ResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqAdventureParty.MP_Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002964")]
    [Address(RVA = "0xF04560", Offset = "0xF03360", VA = "0x10F04560")]
    public FlowNode_ReqAdventureParty_MP_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002965")]
    [Address(RVA = "0xF04270", Offset = "0xF03070", VA = "0x10F04270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqAdventureParty.MP_Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002966")]
    [Address(RVA = "0xF03E40", Offset = "0xF02C40", VA = "0x10F03E40", Slot = "5")]
    public FlowNode_ReqAdventureParty.MP_Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqAdventureParty.MP_Response) null;
    }
  }
}
