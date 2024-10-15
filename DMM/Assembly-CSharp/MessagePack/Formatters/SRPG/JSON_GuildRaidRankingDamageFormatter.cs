// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidRankingDamageFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000864")]
  public sealed class JSON_GuildRaidRankingDamageFormatter : 
    IMessagePackFormatter<JSON_GuildRaidRankingDamage>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001558")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001559")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600227A")]
    [Address(RVA = "0xD8A350", Offset = "0xD89150", VA = "0x10D8A350")]
    public JSON_GuildRaidRankingDamageFormatter()
    {
    }

    [Token(Token = "0x600227B")]
    [Address(RVA = "0xD8A040", Offset = "0xD88E40", VA = "0x10D8A040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidRankingDamage value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600227C")]
    [Address(RVA = "0xD89B40", Offset = "0xD88940", VA = "0x10D89B40", Slot = "5")]
    public JSON_GuildRaidRankingDamage Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidRankingDamage) null;
    }
  }
}
