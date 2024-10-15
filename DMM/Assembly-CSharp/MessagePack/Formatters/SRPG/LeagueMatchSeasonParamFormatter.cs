// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchSeasonParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B17")]
  public sealed class LeagueMatchSeasonParamFormatter : 
    IMessagePackFormatter<LeagueMatchSeasonParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ABE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ABF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A93")]
    [Address(RVA = "0xF40910", Offset = "0xF3F710", VA = "0x10F40910")]
    public LeagueMatchSeasonParamFormatter()
    {
    }

    [Token(Token = "0x6002A94")]
    [Address(RVA = "0xF403C0", Offset = "0xF3F1C0", VA = "0x10F403C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchSeasonParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A95")]
    [Address(RVA = "0xF40010", Offset = "0xF3EE10", VA = "0x10F40010", Slot = "5")]
    public LeagueMatchSeasonParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchSeasonParam) null;
    }
  }
}
