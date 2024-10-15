// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidBattlePointFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A62")]
  public sealed class JSON_GuildRaidBattlePointFormatter : 
    IMessagePackFormatter<JSON_GuildRaidBattlePoint>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001954")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001955")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002874")]
    [Address(RVA = "0xEC5C60", Offset = "0xEC4A60", VA = "0x10EC5C60")]
    public JSON_GuildRaidBattlePointFormatter()
    {
    }

    [Token(Token = "0x6002875")]
    [Address(RVA = "0xEC5B00", Offset = "0xEC4900", VA = "0x10EC5B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidBattlePoint value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002876")]
    [Address(RVA = "0xEC57B0", Offset = "0xEC45B0", VA = "0x10EC57B0", Slot = "5")]
    public JSON_GuildRaidBattlePoint Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidBattlePoint) null;
    }
  }
}
