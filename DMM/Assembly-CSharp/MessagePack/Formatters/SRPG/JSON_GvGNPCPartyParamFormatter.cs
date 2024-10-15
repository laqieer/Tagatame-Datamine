// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNPCPartyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A80")]
  public sealed class JSON_GvGNPCPartyParamFormatter : 
    IMessagePackFormatter<JSON_GvGNPCPartyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001990")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001991")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028CE")]
    [Address(RVA = "0xEDDF00", Offset = "0xEDCD00", VA = "0x10EDDF00")]
    public JSON_GvGNPCPartyParamFormatter()
    {
    }

    [Token(Token = "0x60028CF")]
    [Address(RVA = "0xEDDD60", Offset = "0xEDCB60", VA = "0x10EDDD60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNPCPartyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028D0")]
    [Address(RVA = "0xEDDA50", Offset = "0xEDC850", VA = "0x10EDDA50", Slot = "5")]
    public JSON_GvGNPCPartyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNPCPartyParam) null;
    }
  }
}
