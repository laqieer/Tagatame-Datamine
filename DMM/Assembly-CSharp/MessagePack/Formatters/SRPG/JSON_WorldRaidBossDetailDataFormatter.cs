// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBossDetailDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000891")]
  public sealed class JSON_WorldRaidBossDetailDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBossDetailData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015B2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015B3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002301")]
    [Address(RVA = "0xDA1040", Offset = "0xD9FE40", VA = "0x10DA1040")]
    public JSON_WorldRaidBossDetailDataFormatter()
    {
    }

    [Token(Token = "0x6002302")]
    [Address(RVA = "0xDA0E10", Offset = "0xD9FC10", VA = "0x10DA0E10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBossDetailData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002303")]
    [Address(RVA = "0xDA0A70", Offset = "0xD9F870", VA = "0x10DA0A70", Slot = "5")]
    public JSON_WorldRaidBossDetailData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBossDetailData) null;
    }
  }
}
