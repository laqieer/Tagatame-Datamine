// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidBattleRewardWeightParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000622")]
  public sealed class JSON_RaidBattleRewardWeightParamFormatter : 
    IMessagePackFormatter<JSON_RaidBattleRewardWeightParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010DC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010DD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BB4")]
    [Address(RVA = "0xBBF920", Offset = "0xBBE720", VA = "0x10BBF920")]
    public JSON_RaidBattleRewardWeightParamFormatter()
    {
    }

    [Token(Token = "0x6001BB5")]
    [Address(RVA = "0xBBF7F0", Offset = "0xBBE5F0", VA = "0x10BBF7F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidBattleRewardWeightParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BB6")]
    [Address(RVA = "0xBBF4E0", Offset = "0xBBE2E0", VA = "0x10BBF4E0", Slot = "5")]
    public JSON_RaidBattleRewardWeightParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidBattleRewardWeightParam) null;
    }
  }
}
