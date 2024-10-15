// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitShieldFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B2")]
  public sealed class Unit_UnitShieldFormatter : 
    IMessagePackFormatter<Unit.UnitShield>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002064")]
    [Address(RVA = "0xD12AA0", Offset = "0xD118A0", VA = "0x10D12AA0")]
    public Unit_UnitShieldFormatter()
    {
    }

    [Token(Token = "0x6002065")]
    [Address(RVA = "0xD125A0", Offset = "0xD113A0", VA = "0x10D125A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitShield value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002066")]
    [Address(RVA = "0xD11F00", Offset = "0xD10D00", VA = "0x10D11F00", Slot = "5")]
    public Unit.UnitShield Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitShield) null;
    }
  }
}
