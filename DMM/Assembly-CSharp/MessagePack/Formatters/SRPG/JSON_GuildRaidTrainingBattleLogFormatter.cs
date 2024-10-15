// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidTrainingBattleLogFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000873")]
  public sealed class JSON_GuildRaidTrainingBattleLogFormatter : 
    IMessagePackFormatter<JSON_GuildRaidTrainingBattleLog>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001576")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001577")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022A7")]
    [Address(RVA = "0xD9EBB0", Offset = "0xD9D9B0", VA = "0x10D9EBB0")]
    public JSON_GuildRaidTrainingBattleLogFormatter()
    {
    }

    [Token(Token = "0x60022A8")]
    [Address(RVA = "0xD9E970", Offset = "0xD9D770", VA = "0x10D9E970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidTrainingBattleLog value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022A9")]
    [Address(RVA = "0xD9E550", Offset = "0xD9D350", VA = "0x10D9E550", Slot = "5")]
    public JSON_GuildRaidTrainingBattleLog Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidTrainingBattleLog) null;
    }
  }
}
