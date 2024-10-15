// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureAreaParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A89")]
  public sealed class JSON_AdventureAreaParamFormatter : 
    IMessagePackFormatter<JSON_AdventureAreaParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028E9")]
    [Address(RVA = "0xED5DF0", Offset = "0xED4BF0", VA = "0x10ED5DF0")]
    public JSON_AdventureAreaParamFormatter()
    {
    }

    [Token(Token = "0x60028EA")]
    [Address(RVA = "0xED59E0", Offset = "0xED47E0", VA = "0x10ED59E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureAreaParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028EB")]
    [Address(RVA = "0xED54B0", Offset = "0xED42B0", VA = "0x10ED54B0", Slot = "5")]
    public JSON_AdventureAreaParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureAreaParam) null;
    }
  }
}
