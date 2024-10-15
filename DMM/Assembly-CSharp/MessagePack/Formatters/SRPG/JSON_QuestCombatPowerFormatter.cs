// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestCombatPowerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000732")]
  public sealed class JSON_QuestCombatPowerFormatter : 
    IMessagePackFormatter<JSON_QuestCombatPower>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012FC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012FD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EE4")]
    [Address(RVA = "0xC85BE0", Offset = "0xC849E0", VA = "0x10C85BE0")]
    public JSON_QuestCombatPowerFormatter()
    {
    }

    [Token(Token = "0x6001EE5")]
    [Address(RVA = "0xC85AB0", Offset = "0xC848B0", VA = "0x10C85AB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestCombatPower value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EE6")]
    [Address(RVA = "0xC857A0", Offset = "0xC845A0", VA = "0x10C857A0", Slot = "5")]
    public JSON_QuestCombatPower Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestCombatPower) null;
    }
  }
}
