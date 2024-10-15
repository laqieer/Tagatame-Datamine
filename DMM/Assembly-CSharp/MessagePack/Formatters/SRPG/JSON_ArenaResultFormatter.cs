// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArenaResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F4")]
  public sealed class JSON_ArenaResultFormatter : 
    IMessagePackFormatter<JSON_ArenaResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001080")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001081")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B2A")]
    [Address(RVA = "0xBA1750", Offset = "0xBA0550", VA = "0x10BA1750")]
    public JSON_ArenaResultFormatter()
    {
    }

    [Token(Token = "0x6001B2B")]
    [Address(RVA = "0xBA1210", Offset = "0xBA0010", VA = "0x10BA1210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArenaResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B2C")]
    [Address(RVA = "0xBA0B40", Offset = "0xB9F940", VA = "0x10BA0B40", Slot = "5")]
    public JSON_ArenaResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArenaResult) null;
    }
  }
}
