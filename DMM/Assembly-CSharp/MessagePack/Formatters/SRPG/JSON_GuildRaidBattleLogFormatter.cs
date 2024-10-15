// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GuildRaidBattleLogFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A65")]
  public sealed class JSON_GuildRaidBattleLogFormatter : 
    IMessagePackFormatter<JSON_GuildRaidBattleLog>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400195A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400195B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600287D")]
    [Address(RVA = "0xEC5550", Offset = "0xEC4350", VA = "0x10EC5550")]
    public JSON_GuildRaidBattleLogFormatter()
    {
    }

    [Token(Token = "0x600287E")]
    [Address(RVA = "0xEC53B0", Offset = "0xEC41B0", VA = "0x10EC53B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GuildRaidBattleLog value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600287F")]
    [Address(RVA = "0xEC5030", Offset = "0xEC3E30", VA = "0x10EC5030", Slot = "5")]
    public JSON_GuildRaidBattleLog Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GuildRaidBattleLog) null;
    }
  }
}
