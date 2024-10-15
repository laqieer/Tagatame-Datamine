// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitRevivalFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B7")]
  public sealed class Unit_UnitRevivalFormatter : 
    IMessagePackFormatter<Unit.UnitRevival>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013FE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013FF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002073")]
    [Address(RVA = "0xD11D10", Offset = "0xD10B10", VA = "0x10D11D10")]
    public Unit_UnitRevivalFormatter()
    {
    }

    [Token(Token = "0x6002074")]
    [Address(RVA = "0xD11BA0", Offset = "0xD109A0", VA = "0x10D11BA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitRevival value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002075")]
    [Address(RVA = "0xD11850", Offset = "0xD10650", VA = "0x10D11850", Slot = "5")]
    public Unit.UnitRevival Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitRevival) null;
    }
  }
}
