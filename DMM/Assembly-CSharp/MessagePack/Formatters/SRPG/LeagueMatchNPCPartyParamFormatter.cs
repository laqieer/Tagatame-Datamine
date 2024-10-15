// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LeagueMatchNPCPartyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B25")]
  public sealed class LeagueMatchNPCPartyParamFormatter : 
    IMessagePackFormatter<LeagueMatchNPCPartyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001ADA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001ADB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002ABD")]
    [Address(RVA = "0xF3E860", Offset = "0xF3D660", VA = "0x10F3E860")]
    public LeagueMatchNPCPartyParamFormatter()
    {
    }

    [Token(Token = "0x6002ABE")]
    [Address(RVA = "0xF3E440", Offset = "0xF3D240", VA = "0x10F3E440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LeagueMatchNPCPartyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002ABF")]
    [Address(RVA = "0xF3E0F0", Offset = "0xF3CEF0", VA = "0x10F3E0F0", Slot = "5")]
    public LeagueMatchNPCPartyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LeagueMatchNPCPartyParam) null;
    }
  }
}
