// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyCategoryParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005EE")]
  public sealed class JSON_TrophyCategoryParamFormatter : 
    IMessagePackFormatter<JSON_TrophyCategoryParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001074")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001075")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B18")]
    [Address(RVA = "0xB9CD70", Offset = "0xB9BB70", VA = "0x10B9CD70")]
    public JSON_TrophyCategoryParamFormatter()
    {
    }

    [Token(Token = "0x6001B19")]
    [Address(RVA = "0xB9CA00", Offset = "0xB9B800", VA = "0x10B9CA00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyCategoryParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B1A")]
    [Address(RVA = "0xB9C4C0", Offset = "0xB9B2C0", VA = "0x10B9C4C0", Slot = "5")]
    public JSON_TrophyCategoryParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyCategoryParam) null;
    }
  }
}
