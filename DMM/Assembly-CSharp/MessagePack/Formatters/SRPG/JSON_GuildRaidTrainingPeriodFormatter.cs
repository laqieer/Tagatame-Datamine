// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidTrainingPeriodFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200093B")]
  public sealed class JSON_GuildRaidTrainingPeriodFormatter : 
    IMessagePackFormatter<JSON_GuildRaidTrainingPeriod>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001706")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001707")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024FF")]
    [Address(RVA = "0xE15050", Offset = "0xE13E50", VA = "0x10E15050")]
    public JSON_GuildRaidTrainingPeriodFormatter()
    {
    }

    [Token(Token = "0x6002500")]
    [Address(RVA = "0xE14EF0", Offset = "0xE13CF0", VA = "0x10E14EF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidTrainingPeriod value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002501")]
    [Address(RVA = "0xE14BA0", Offset = "0xE139A0", VA = "0x10E14BA0", Slot = "5")]
    public JSON_GuildRaidTrainingPeriod Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidTrainingPeriod) null;
    }
  }
}
