// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchMissionParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000987")]
  public sealed class JSON_LeagueMatchMissionParamFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchMissionParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400179E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400179F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025E3")]
    [Address(RVA = "0xE3A450", Offset = "0xE39250", VA = "0x10E3A450")]
    public JSON_LeagueMatchMissionParamFormatter()
    {
    }

    [Token(Token = "0x60025E4")]
    [Address(RVA = "0xE3A1A0", Offset = "0xE38FA0", VA = "0x10E3A1A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchMissionParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025E5")]
    [Address(RVA = "0xE39D30", Offset = "0xE38B30", VA = "0x10E39D30", Slot = "5")]
    public JSON_LeagueMatchMissionParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchMissionParam) null;
    }
  }
}
