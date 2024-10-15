// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchMissionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200081A")]
  public sealed class JSON_LeagueMatchMissionFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchMission>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600219C")]
    [Address(RVA = "0xD45CC0", Offset = "0xD44AC0", VA = "0x10D45CC0")]
    public JSON_LeagueMatchMissionFormatter()
    {
    }

    [Token(Token = "0x600219D")]
    [Address(RVA = "0xD45B60", Offset = "0xD44960", VA = "0x10D45B60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchMission value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600219E")]
    [Address(RVA = "0xD45810", Offset = "0xD44610", VA = "0x10D45810", Slot = "5")]
    public JSON_LeagueMatchMission Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchMission) null;
    }
  }
}
