// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitCombatPowersFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007FE")]
  public sealed class UnitCombatPowersFormatter : 
    IMessagePackFormatter<UnitCombatPowers>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400148C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400148D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002148")]
    [Address(RVA = "0xD3E140", Offset = "0xD3CF40", VA = "0x10D3E140")]
    public UnitCombatPowersFormatter()
    {
    }

    [Token(Token = "0x6002149")]
    [Address(RVA = "0xD3E040", Offset = "0xD3CE40", VA = "0x10D3E040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitCombatPowers value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600214A")]
    [Address(RVA = "0xD3DD20", Offset = "0xD3CB20", VA = "0x10D3DD20", Slot = "5")]
    public UnitCombatPowers Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitCombatPowers) null;
    }
  }
}
