// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidRankingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000894")]
  public sealed class JSON_WorldRaidRankingDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidRankingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600230A")]
    [Address(RVA = "0xDA2850", Offset = "0xDA1650", VA = "0x10DA2850")]
    public JSON_WorldRaidRankingDataFormatter()
    {
    }

    [Token(Token = "0x600230B")]
    [Address(RVA = "0xDA2480", Offset = "0xDA1280", VA = "0x10DA2480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidRankingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600230C")]
    [Address(RVA = "0xDA1FC0", Offset = "0xDA0DC0", VA = "0x10DA1FC0", Slot = "5")]
    public JSON_WorldRaidRankingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidRankingData) null;
    }
  }
}
