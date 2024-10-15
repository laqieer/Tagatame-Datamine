// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportUnitRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B1")]
  public sealed class JSON_SupportUnitRankingFormatter : 
    IMessagePackFormatter<JSON_SupportUnitRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002361")]
    [Address(RVA = "0xDB8FD0", Offset = "0xDB7DD0", VA = "0x10DB8FD0")]
    public JSON_SupportUnitRankingFormatter()
    {
    }

    [Token(Token = "0x6002362")]
    [Address(RVA = "0xDB8E10", Offset = "0xDB7C10", VA = "0x10DB8E10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportUnitRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002363")]
    [Address(RVA = "0xDB8A70", Offset = "0xDB7870", VA = "0x10DB8A70", Slot = "5")]
    public JSON_SupportUnitRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportUnitRanking) null;
    }
  }
}
