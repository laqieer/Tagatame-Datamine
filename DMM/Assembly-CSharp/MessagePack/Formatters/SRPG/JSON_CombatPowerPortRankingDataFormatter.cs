// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerPortRankingDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007FB")]
  public sealed class JSON_CombatPowerPortRankingDataFormatter : 
    IMessagePackFormatter<JSON_CombatPowerPortRankingData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001486")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001487")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600213F")]
    [Address(RVA = "0xD2E2A0", Offset = "0xD2D0A0", VA = "0x10D2E2A0")]
    public JSON_CombatPowerPortRankingDataFormatter()
    {
    }

    [Token(Token = "0x6002140")]
    [Address(RVA = "0xD2E170", Offset = "0xD2CF70", VA = "0x10D2E170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerPortRankingData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002141")]
    [Address(RVA = "0xD2DE60", Offset = "0xD2CC60", VA = "0x10D2DE60", Slot = "5")]
    public JSON_CombatPowerPortRankingData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerPortRankingData) null;
    }
  }
}
