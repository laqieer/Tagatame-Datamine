// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CombatPowerQuestParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A87")]
  public sealed class JSON_CombatPowerQuestParamFormatter : 
    IMessagePackFormatter<JSON_CombatPowerQuestParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400199E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400199F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028E3")]
    [Address(RVA = "0xEDA020", Offset = "0xED8E20", VA = "0x10EDA020")]
    public JSON_CombatPowerQuestParamFormatter()
    {
    }

    [Token(Token = "0x60028E4")]
    [Address(RVA = "0xED9D70", Offset = "0xED8B70", VA = "0x10ED9D70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CombatPowerQuestParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028E5")]
    [Address(RVA = "0xED9900", Offset = "0xED8700", VA = "0x10ED9900", Slot = "5")]
    public JSON_CombatPowerQuestParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CombatPowerQuestParam) null;
    }
  }
}
