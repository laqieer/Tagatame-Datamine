// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdventureBookFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008DD")]
  public sealed class JSON_AdventureBookFormatter : 
    IMessagePackFormatter<JSON_AdventureBook>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400164A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400164B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60023E5")]
    [Address(RVA = "0xDCBAD0", Offset = "0xDCA8D0", VA = "0x10DCBAD0")]
    public JSON_AdventureBookFormatter()
    {
    }

    [Token(Token = "0x60023E6")]
    [Address(RVA = "0xDCB8F0", Offset = "0xDCA6F0", VA = "0x10DCB8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdventureBook value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60023E7")]
    [Address(RVA = "0xDCB5B0", Offset = "0xDCA3B0", VA = "0x10DCB5B0", Slot = "5")]
    public JSON_AdventureBook Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdventureBook) null;
    }
  }
}
