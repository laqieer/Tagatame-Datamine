// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidBossParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009C2")]
  public sealed class JSON_GuildRaidBossParamFormatter : 
    IMessagePackFormatter<JSON_GuildRaidBossParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001814")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001815")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002694")]
    [Address(RVA = "0xE6F2D0", Offset = "0xE6E0D0", VA = "0x10E6F2D0")]
    public JSON_GuildRaidBossParamFormatter()
    {
    }

    [Token(Token = "0x6002695")]
    [Address(RVA = "0xE6ED50", Offset = "0xE6DB50", VA = "0x10E6ED50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidBossParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002696")]
    [Address(RVA = "0xE6E650", Offset = "0xE6D450", VA = "0x10E6E650", Slot = "5")]
    public JSON_GuildRaidBossParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidBossParam) null;
    }
  }
}
