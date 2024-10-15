// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SupportRankingUnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008B2")]
  public sealed class JSON_SupportRankingUnitFormatter : 
    IMessagePackFormatter<JSON_SupportRankingUnit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002364")]
    [Address(RVA = "0xDB8260", Offset = "0xDB7060", VA = "0x10DB8260")]
    public JSON_SupportRankingUnitFormatter()
    {
    }

    [Token(Token = "0x6002365")]
    [Address(RVA = "0xDB80F0", Offset = "0xDB6EF0", VA = "0x10DB80F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SupportRankingUnit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002366")]
    [Address(RVA = "0xDB7E20", Offset = "0xDB6C20", VA = "0x10DB7E20", Slot = "5")]
    public JSON_SupportRankingUnit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SupportRankingUnit) null;
    }
  }
}
