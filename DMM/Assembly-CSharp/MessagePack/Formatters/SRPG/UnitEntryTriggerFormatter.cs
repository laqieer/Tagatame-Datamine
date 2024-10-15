// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.UnitEntryTriggerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007CB")]
  public sealed class UnitEntryTriggerFormatter : 
    IMessagePackFormatter<UnitEntryTrigger>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001426")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001427")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020AF")]
    [Address(RVA = "0xD0C820", Offset = "0xD0B620", VA = "0x10D0C820")]
    public UnitEntryTriggerFormatter()
    {
    }

    [Token(Token = "0x60020B0")]
    [Address(RVA = "0xD0C5B0", Offset = "0xD0B3B0", VA = "0x10D0C5B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      UnitEntryTrigger value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020B1")]
    [Address(RVA = "0xD0C170", Offset = "0xD0AF70", VA = "0x10D0C170", Slot = "5")]
    public UnitEntryTrigger Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (UnitEntryTrigger) null;
    }
  }
}
