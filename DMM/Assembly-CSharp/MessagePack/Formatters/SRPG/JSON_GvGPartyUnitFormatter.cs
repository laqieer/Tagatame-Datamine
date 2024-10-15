// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGPartyUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C3")]
  public sealed class JSON_GvGPartyUnitFormatter : 
    IMessagePackFormatter<JSON_GvGPartyUnit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400101E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400101F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A97")]
    [Address(RVA = "0x955E50", Offset = "0x954C50", VA = "0x10955E50")]
    public JSON_GvGPartyUnitFormatter()
    {
    }

    [Token(Token = "0x6001A98")]
    [Address(RVA = "0x954F70", Offset = "0x953D70", VA = "0x10954F70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGPartyUnit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A99")]
    [Address(RVA = "0x9543F0", Offset = "0x9531F0", VA = "0x109543F0", Slot = "5")]
    public JSON_GvGPartyUnit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGPartyUnit) null;
    }
  }
}
