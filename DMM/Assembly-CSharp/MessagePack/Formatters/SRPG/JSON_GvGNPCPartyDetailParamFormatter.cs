// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNPCPartyDetailParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A7F")]
  public sealed class JSON_GvGNPCPartyDetailParamFormatter : 
    IMessagePackFormatter<JSON_GvGNPCPartyDetailParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400198E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400198F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028CB")]
    [Address(RVA = "0xEDD7F0", Offset = "0xEDC5F0", VA = "0x10EDD7F0")]
    public JSON_GvGNPCPartyDetailParamFormatter()
    {
    }

    [Token(Token = "0x60028CC")]
    [Address(RVA = "0xEDD690", Offset = "0xEDC490", VA = "0x10EDD690", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNPCPartyDetailParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028CD")]
    [Address(RVA = "0xEDD340", Offset = "0xEDC140", VA = "0x10EDD340", Slot = "5")]
    public JSON_GvGNPCPartyDetailParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNPCPartyDetailParam) null;
    }
  }
}
