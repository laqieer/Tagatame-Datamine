// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D3")]
  public sealed class UnitFormatter : IMessagePackFormatter<Unit>, IMessagePackFormatter
  {
    [Token(Token = "0x4001436")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001437")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020C7")]
    [Address(RVA = "0xD23530", Offset = "0xD22330", VA = "0x10D23530")]
    public UnitFormatter()
    {
    }

    [Token(Token = "0x60020C8")]
    [Address(RVA = "0xD1F260", Offset = "0xD1E060", VA = "0x10D1F260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020C9")]
    [Address(RVA = "0xD1D350", Offset = "0xD1C150", VA = "0x10D1D350", Slot = "5")]
    public Unit Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit) null;
    }
  }
}
