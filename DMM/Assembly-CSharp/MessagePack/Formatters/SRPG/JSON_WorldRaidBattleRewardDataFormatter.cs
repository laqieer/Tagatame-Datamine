// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_WorldRaidBattleRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AF2")]
  public sealed class JSON_WorldRaidBattleRewardDataFormatter : 
    IMessagePackFormatter<JSON_WorldRaidBattleRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A74")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A75")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A24")]
    [Address(RVA = "0xF22A30", Offset = "0xF21830", VA = "0x10F22A30")]
    public JSON_WorldRaidBattleRewardDataFormatter()
    {
    }

    [Token(Token = "0x6002A25")]
    [Address(RVA = "0xF228D0", Offset = "0xF216D0", VA = "0x10F228D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_WorldRaidBattleRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A26")]
    [Address(RVA = "0xF22580", Offset = "0xF21380", VA = "0x10F22580", Slot = "5")]
    public JSON_WorldRaidBattleRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_WorldRaidBattleRewardData) null;
    }
  }
}
