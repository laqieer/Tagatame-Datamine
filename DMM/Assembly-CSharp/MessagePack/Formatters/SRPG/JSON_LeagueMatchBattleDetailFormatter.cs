// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_LeagueMatchBattleDetailFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200082D")]
  public sealed class JSON_LeagueMatchBattleDetailFormatter : 
    IMessagePackFormatter<JSON_LeagueMatchBattleDetail>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60021D5")]
    [Address(RVA = "0xD6DC50", Offset = "0xD6CA50", VA = "0x10D6DC50")]
    public JSON_LeagueMatchBattleDetailFormatter()
    {
    }

    [Token(Token = "0x60021D6")]
    [Address(RVA = "0xD6DA30", Offset = "0xD6C830", VA = "0x10D6DA30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_LeagueMatchBattleDetail value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60021D7")]
    [Address(RVA = "0xD6D650", Offset = "0xD6C450", VA = "0x10D6D650", Slot = "5")]
    public JSON_LeagueMatchBattleDetail Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_LeagueMatchBattleDetail) null;
    }
  }
}
