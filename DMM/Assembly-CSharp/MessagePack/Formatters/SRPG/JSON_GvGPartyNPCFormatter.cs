// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGPartyNPCFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C4")]
  public sealed class JSON_GvGPartyNPCFormatter : 
    IMessagePackFormatter<JSON_GvGPartyNPC>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001020")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001021")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A9A")]
    [Address(RVA = "0x954270", Offset = "0x953070", VA = "0x10954270")]
    public JSON_GvGPartyNPCFormatter()
    {
    }

    [Token(Token = "0x6001A9B")]
    [Address(RVA = "0x954170", Offset = "0x952F70", VA = "0x10954170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGPartyNPC value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A9C")]
    [Address(RVA = "0x953E90", Offset = "0x952C90", VA = "0x10953E90", Slot = "5")]
    public JSON_GvGPartyNPC Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGPartyNPC) null;
    }
  }
}
