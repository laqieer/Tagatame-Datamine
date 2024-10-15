// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGUsedItemsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D1")]
  public sealed class JSON_GvGUsedItemsFormatter : 
    IMessagePackFormatter<JSON_GvGUsedItems>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400103A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400103B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AC1")]
    [Address(RVA = "0x95A430", Offset = "0x959230", VA = "0x1095A430")]
    public JSON_GvGUsedItemsFormatter()
    {
    }

    [Token(Token = "0x6001AC2")]
    [Address(RVA = "0x95A250", Offset = "0x959050", VA = "0x1095A250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGUsedItems value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AC3")]
    [Address(RVA = "0x959EA0", Offset = "0x958CA0", VA = "0x10959EA0", Slot = "5")]
    public JSON_GvGUsedItems Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGUsedItems) null;
    }
  }
}
