// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGPartyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C8")]
  public sealed class JSON_GvGPartyFormatter : 
    IMessagePackFormatter<JSON_GvGParty>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001028")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001029")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AA6")]
    [Address(RVA = "0x953A10", Offset = "0x952810", VA = "0x10953A10")]
    public JSON_GvGPartyFormatter()
    {
    }

    [Token(Token = "0x6001AA7")]
    [Address(RVA = "0x9535C0", Offset = "0x9523C0", VA = "0x109535C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGParty value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AA8")]
    [Address(RVA = "0x953090", Offset = "0x951E90", VA = "0x10953090", Slot = "5")]
    public JSON_GvGParty Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGParty) null;
    }
  }
}
