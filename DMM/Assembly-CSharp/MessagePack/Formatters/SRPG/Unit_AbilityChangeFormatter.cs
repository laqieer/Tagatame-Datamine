// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_AbilityChangeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D0")]
  public sealed class Unit_AbilityChangeFormatter : 
    IMessagePackFormatter<Unit.AbilityChange>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001430")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001431")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020BE")]
    [Address(RVA = "0xD27A40", Offset = "0xD26840", VA = "0x10D27A40")]
    public Unit_AbilityChangeFormatter()
    {
    }

    [Token(Token = "0x60020BF")]
    [Address(RVA = "0xD278D0", Offset = "0xD266D0", VA = "0x10D278D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.AbilityChange value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020C0")]
    [Address(RVA = "0xD27600", Offset = "0xD26400", VA = "0x10D27600", Slot = "5")]
    public Unit.AbilityChange Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.AbilityChange) null;
    }
  }
}
