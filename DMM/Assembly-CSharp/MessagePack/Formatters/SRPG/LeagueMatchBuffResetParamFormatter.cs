// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchBuffResetParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009D3")]
  public sealed class LeagueMatchBuffResetParamFormatter : 
    IMessagePackFormatter<LeagueMatchBuffResetParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001836")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001837")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60026C7")]
    [Address(RVA = "0xE74D20", Offset = "0xE73B20", VA = "0x10E74D20")]
    public LeagueMatchBuffResetParamFormatter()
    {
    }

    [Token(Token = "0x60026C8")]
    [Address(RVA = "0xE74C20", Offset = "0xE73A20", VA = "0x10E74C20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchBuffResetParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60026C9")]
    [Address(RVA = "0xE74960", Offset = "0xE73760", VA = "0x10E74960", Slot = "5")]
    public LeagueMatchBuffResetParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchBuffResetParam) null;
    }
  }
}
