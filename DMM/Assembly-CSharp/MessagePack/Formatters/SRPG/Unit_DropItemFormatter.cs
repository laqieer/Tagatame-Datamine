// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Unit_DropItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007AF")]
  public sealed class Unit_DropItemFormatter : 
    IMessagePackFormatter<Unit.DropItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013F0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013F1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600205B")]
    [Address(RVA = "0xD0D5A0", Offset = "0xD0C3A0", VA = "0x10D0D5A0")]
    public Unit_DropItemFormatter()
    {
    }

    [Token(Token = "0x600205C")]
    [Address(RVA = "0xD0D0C0", Offset = "0xD0BEC0", VA = "0x10D0D0C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Unit.DropItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600205D")]
    [Address(RVA = "0xD0CBC0", Offset = "0xD0B9C0", VA = "0x10D0CBC0", Slot = "5")]
    public Unit.DropItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Unit.DropItem) null;
    }
  }
}
