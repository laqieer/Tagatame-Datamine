// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideUsedItemDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000912")]
  public sealed class JSON_RunePrideUsedItemDataFormatter : 
    IMessagePackFormatter<JSON_RunePrideUsedItemData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002484")]
    [Address(RVA = "0xDFF9B0", Offset = "0xDFE7B0", VA = "0x10DFF9B0")]
    public JSON_RunePrideUsedItemDataFormatter()
    {
    }

    [Token(Token = "0x6002485")]
    [Address(RVA = "0xDFF880", Offset = "0xDFE680", VA = "0x10DFF880", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideUsedItemData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002486")]
    [Address(RVA = "0xDFF570", Offset = "0xDFE370", VA = "0x10DFF570", Slot = "5")]
    public JSON_RunePrideUsedItemData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideUsedItemData) null;
    }
  }
}
