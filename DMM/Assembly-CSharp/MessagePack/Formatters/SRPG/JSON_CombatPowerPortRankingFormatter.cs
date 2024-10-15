// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerPortRankingFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007FD")]
  public sealed class JSON_CombatPowerPortRankingFormatter : 
    IMessagePackFormatter<JSON_CombatPowerPortRanking>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400148A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400148B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002145")]
    [Address(RVA = "0xD2EB10", Offset = "0xD2D910", VA = "0x10D2EB10")]
    public JSON_CombatPowerPortRankingFormatter()
    {
    }

    [Token(Token = "0x6002146")]
    [Address(RVA = "0xD2E880", Offset = "0xD2D680", VA = "0x10D2E880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerPortRanking value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002147")]
    [Address(RVA = "0xD2E420", Offset = "0xD2D220", VA = "0x10D2E420", Slot = "5")]
    public JSON_CombatPowerPortRanking Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerPortRanking) null;
    }
  }
}
