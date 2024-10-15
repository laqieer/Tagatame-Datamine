// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_UnitDropFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007B0")]
  public sealed class Unit_UnitDropFormatter : 
    IMessagePackFormatter<Unit.UnitDrop>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013F2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013F3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600205E")]
    [Address(RVA = "0xD0E720", Offset = "0xD0D520", VA = "0x10D0E720")]
    public Unit_UnitDropFormatter()
    {
    }

    [Token(Token = "0x600205F")]
    [Address(RVA = "0xD0E490", Offset = "0xD0D290", VA = "0x10D0E490", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.UnitDrop value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002060")]
    [Address(RVA = "0xD0E050", Offset = "0xD0CE50", VA = "0x10D0E050", Slot = "5")]
    public Unit.UnitDrop Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.UnitDrop) null;
    }
  }
}
