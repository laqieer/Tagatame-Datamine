// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_AbilityChange_DataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007CF")]
  public sealed class Unit_AbilityChange_DataFormatter : 
    IMessagePackFormatter<Unit.AbilityChange.Data>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400142E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400142F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020BB")]
    [Address(RVA = "0xD281A0", Offset = "0xD26FA0", VA = "0x10D281A0")]
    public Unit_AbilityChange_DataFormatter()
    {
    }

    [Token(Token = "0x60020BC")]
    [Address(RVA = "0xD27F60", Offset = "0xD26D60", VA = "0x10D27F60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.AbilityChange.Data value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020BD")]
    [Address(RVA = "0xD27B60", Offset = "0xD26960", VA = "0x10D27B60", Slot = "5")]
    public Unit.AbilityChange.Data Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.AbilityChange.Data) null;
    }
  }
}
