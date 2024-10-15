// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCombatPowersFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000734")]
  public sealed class JSON_QuestCombatPowersFormatter : 
    IMessagePackFormatter<JSON_QuestCombatPowers>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001300")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001301")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EEA")]
    [Address(RVA = "0xC862D0", Offset = "0xC850D0", VA = "0x10C862D0")]
    public JSON_QuestCombatPowersFormatter()
    {
    }

    [Token(Token = "0x6001EEB")]
    [Address(RVA = "0xC860A0", Offset = "0xC84EA0", VA = "0x10C860A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCombatPowers value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EEC")]
    [Address(RVA = "0xC85D60", Offset = "0xC84B60", VA = "0x10C85D60", Slot = "5")]
    public JSON_QuestCombatPowers Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCombatPowers) null;
    }
  }
}
