// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelSeasonParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000806")]
  public sealed class JSON_DuelSeasonParamFormatter : 
    IMessagePackFormatter<JSON_DuelSeasonParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400149C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400149D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002160")]
    [Address(RVA = "0xD435D0", Offset = "0xD423D0", VA = "0x10D435D0")]
    public JSON_DuelSeasonParamFormatter()
    {
    }

    [Token(Token = "0x6002161")]
    [Address(RVA = "0xD43160", Offset = "0xD41F60", VA = "0x10D43160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelSeasonParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002162")]
    [Address(RVA = "0xD42BB0", Offset = "0xD419B0", VA = "0x10D42BB0", Slot = "5")]
    public JSON_DuelSeasonParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelSeasonParam) null;
    }
  }
}
