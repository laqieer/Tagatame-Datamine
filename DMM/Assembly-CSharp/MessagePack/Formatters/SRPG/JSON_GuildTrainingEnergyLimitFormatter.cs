// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildTrainingEnergyLimitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000637")]
  public sealed class JSON_GuildTrainingEnergyLimitFormatter : 
    IMessagePackFormatter<JSON_GuildTrainingEnergyLimit>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001106")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001107")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BF3")]
    [Address(RVA = "0xBD7580", Offset = "0xBD6380", VA = "0x10BD7580")]
    public JSON_GuildTrainingEnergyLimitFormatter()
    {
    }

    [Token(Token = "0x6001BF4")]
    [Address(RVA = "0xBD7480", Offset = "0xBD6280", VA = "0x10BD7480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildTrainingEnergyLimit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BF5")]
    [Address(RVA = "0xBD71A0", Offset = "0xBD5FA0", VA = "0x10BD71A0", Slot = "5")]
    public JSON_GuildTrainingEnergyLimit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildTrainingEnergyLimit) null;
    }
  }
}
