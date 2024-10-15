// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitStealFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B1")]
  public sealed class Unit_UnitStealFormatter : 
    IMessagePackFormatter<Unit.UnitSteal>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013F4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013F5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002061")]
    [Address(RVA = "0xD13EF0", Offset = "0xD12CF0", VA = "0x10D13EF0")]
    public Unit_UnitStealFormatter()
    {
    }

    [Token(Token = "0x6002062")]
    [Address(RVA = "0xD13CF0", Offset = "0xD12AF0", VA = "0x10D13CF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitSteal value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002063")]
    [Address(RVA = "0xD13940", Offset = "0xD12740", VA = "0x10D13940", Slot = "5")]
    public Unit.UnitSteal Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitSteal) null;
    }
  }
}
