// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitMhmDamageFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B4")]
  public sealed class Unit_UnitMhmDamageFormatter : 
    IMessagePackFormatter<Unit.UnitMhmDamage>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600206A")]
    [Address(RVA = "0xD10870", Offset = "0xD0F670", VA = "0x10D10870")]
    public Unit_UnitMhmDamageFormatter()
    {
    }

    [Token(Token = "0x600206B")]
    [Address(RVA = "0xD106F0", Offset = "0xD0F4F0", VA = "0x10D106F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitMhmDamage value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600206C")]
    [Address(RVA = "0xD103A0", Offset = "0xD0F1A0", VA = "0x10D103A0", Slot = "5")]
    public Unit.UnitMhmDamage Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitMhmDamage) null;
    }
  }
}
