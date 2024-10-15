// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrophyResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000889")]
  public sealed class JSON_TrophyResponseFormatter : 
    IMessagePackFormatter<JSON_TrophyResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015A2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015A3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022E9")]
    [Address(RVA = "0xDA0280", Offset = "0xD9F080", VA = "0x10DA0280")]
    public JSON_TrophyResponseFormatter()
    {
    }

    [Token(Token = "0x60022EA")]
    [Address(RVA = "0xDA0110", Offset = "0xD9EF10", VA = "0x10DA0110", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrophyResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022EB")]
    [Address(RVA = "0xD9FE40", Offset = "0xD9EC40", VA = "0x10D9FE40", Slot = "5")]
    public JSON_TrophyResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrophyResponse) null;
    }
  }
}
