// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerPlayerRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007FC")]
  public sealed class JSON_CombatPowerPlayerRankingFormatter : 
    IMessagePackFormatter<JSON_CombatPowerPlayerRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001488")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001489")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002142")]
    [Address(RVA = "0xD2D580", Offset = "0xD2C380", VA = "0x10D2D580")]
    public JSON_CombatPowerPlayerRankingFormatter()
    {
    }

    [Token(Token = "0x6002143")]
    [Address(RVA = "0xD2D310", Offset = "0xD2C110", VA = "0x10D2D310", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerPlayerRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002144")]
    [Address(RVA = "0xD2CF90", Offset = "0xD2BD90", VA = "0x10D2CF90", Slot = "5")]
    public JSON_CombatPowerPlayerRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerPlayerRanking) null;
    }
  }
}
