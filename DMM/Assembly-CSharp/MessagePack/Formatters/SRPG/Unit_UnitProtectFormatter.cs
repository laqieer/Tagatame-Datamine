// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitProtectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B3")]
  public sealed class Unit_UnitProtectFormatter : 
    IMessagePackFormatter<Unit.UnitProtect>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002067")]
    [Address(RVA = "0xD113D0", Offset = "0xD101D0", VA = "0x10D113D0")]
    public Unit_UnitProtectFormatter()
    {
    }

    [Token(Token = "0x6002068")]
    [Address(RVA = "0xD10FA0", Offset = "0xD0FDA0", VA = "0x10D10FA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitProtect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002069")]
    [Address(RVA = "0xD109F0", Offset = "0xD0F7F0", VA = "0x10D109F0", Slot = "5")]
    public Unit.UnitProtect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitProtect) null;
    }
  }
}
