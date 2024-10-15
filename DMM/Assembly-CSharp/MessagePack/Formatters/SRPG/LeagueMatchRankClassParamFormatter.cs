// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchRankClassParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B08")]
  public sealed class LeagueMatchRankClassParamFormatter : 
    IMessagePackFormatter<LeagueMatchRankClassParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AA0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AA1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A66")]
    [Address(RVA = "0xF3F4C0", Offset = "0xF3E2C0", VA = "0x10F3F4C0")]
    public LeagueMatchRankClassParamFormatter()
    {
    }

    [Token(Token = "0x6002A67")]
    [Address(RVA = "0xF3F100", Offset = "0xF3DF00", VA = "0x10F3F100", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchRankClassParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A68")]
    [Address(RVA = "0xF3EDB0", Offset = "0xF3DBB0", VA = "0x10F3EDB0", Slot = "5")]
    public LeagueMatchRankClassParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchRankClassParam) null;
    }
  }
}
