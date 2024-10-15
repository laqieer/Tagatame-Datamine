// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_GuildTrainingRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009DE")]
  public sealed class Json_GuildTrainingRewardFormatter : 
    IMessagePackFormatter<Json_GuildTrainingReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400184C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400184D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026E8")]
    [Address(RVA = "0xE893D0", Offset = "0xE881D0", VA = "0x10E893D0")]
    public Json_GuildTrainingRewardFormatter()
    {
    }

    [Token(Token = "0x60026E9")]
    [Address(RVA = "0xE89270", Offset = "0xE88070", VA = "0x10E89270", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_GuildTrainingReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026EA")]
    [Address(RVA = "0xE88F20", Offset = "0xE87D20", VA = "0x10E88F20", Slot = "5")]
    public Json_GuildTrainingReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_GuildTrainingReward) null;
    }
  }
}
