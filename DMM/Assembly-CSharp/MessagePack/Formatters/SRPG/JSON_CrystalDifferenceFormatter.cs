// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalDifferenceFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000726")]
  public sealed class JSON_CrystalDifferenceFormatter : 
    IMessagePackFormatter<JSON_CrystalDifference>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012E4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012E5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EC0")]
    [Address(RVA = "0xC540E0", Offset = "0xC52EE0", VA = "0x10C540E0")]
    public JSON_CrystalDifferenceFormatter()
    {
    }

    [Token(Token = "0x6001EC1")]
    [Address(RVA = "0xC53FE0", Offset = "0xC52DE0", VA = "0x10C53FE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalDifference value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EC2")]
    [Address(RVA = "0xC53D10", Offset = "0xC52B10", VA = "0x10C53D10", Slot = "5")]
    public JSON_CrystalDifference Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalDifference) null;
    }
  }
}
