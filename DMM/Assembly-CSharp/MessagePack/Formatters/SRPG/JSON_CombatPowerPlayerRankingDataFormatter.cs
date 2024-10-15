// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerPlayerRankingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007FA")]
  public sealed class JSON_CombatPowerPlayerRankingDataFormatter : 
    IMessagePackFormatter<JSON_CombatPowerPlayerRankingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001484")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001485")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600213C")]
    [Address(RVA = "0xD2CBF0", Offset = "0xD2B9F0", VA = "0x10D2CBF0")]
    public JSON_CombatPowerPlayerRankingDataFormatter()
    {
    }

    [Token(Token = "0x600213D")]
    [Address(RVA = "0xD2C8B0", Offset = "0xD2B6B0", VA = "0x10D2C8B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerPlayerRankingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600213E")]
    [Address(RVA = "0xD2C430", Offset = "0xD2B230", VA = "0x10D2C430", Slot = "5")]
    public JSON_CombatPowerPlayerRankingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerPlayerRankingData) null;
    }
  }
}
