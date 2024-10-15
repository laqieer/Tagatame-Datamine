// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerRankingGuildMemberFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008BC")]
  public sealed class JSON_CombatPowerRankingGuildMemberFormatter : 
    IMessagePackFormatter<JSON_CombatPowerRankingGuildMember>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001608")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001609")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002382")]
    [Address(RVA = "0xDB11A0", Offset = "0xDAFFA0", VA = "0x10DB11A0")]
    public JSON_CombatPowerRankingGuildMemberFormatter()
    {
    }

    [Token(Token = "0x6002383")]
    [Address(RVA = "0xDB0D10", Offset = "0xDAFB10", VA = "0x10DB0D10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerRankingGuildMember value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002384")]
    [Address(RVA = "0xDB0600", Offset = "0xDAF400", VA = "0x10DB0600", Slot = "5")]
    public JSON_CombatPowerRankingGuildMember Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerRankingGuildMember) null;
    }
  }
}
