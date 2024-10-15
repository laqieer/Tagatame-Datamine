// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerRankingViewGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008BA")]
  public sealed class JSON_CombatPowerRankingViewGuildFormatter : 
    IMessagePackFormatter<JSON_CombatPowerRankingViewGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001604")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001605")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600237C")]
    [Address(RVA = "0xDB20B0", Offset = "0xDB0EB0", VA = "0x10DB20B0")]
    public JSON_CombatPowerRankingViewGuildFormatter()
    {
    }

    [Token(Token = "0x600237D")]
    [Address(RVA = "0xDB1D80", Offset = "0xDB0B80", VA = "0x10DB1D80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerRankingViewGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600237E")]
    [Address(RVA = "0xDB1830", Offset = "0xDB0630", VA = "0x10DB1830", Slot = "5")]
    public JSON_CombatPowerRankingViewGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerRankingViewGuild) null;
    }
  }
}
