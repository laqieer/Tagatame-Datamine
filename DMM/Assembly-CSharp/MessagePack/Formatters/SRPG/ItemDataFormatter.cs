// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ItemDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200078B")]
  public sealed class ItemDataFormatter : IMessagePackFormatter<ItemData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FEF")]
    [Address(RVA = "0xCDD110", Offset = "0xCDBF10", VA = "0x10CDD110")]
    public ItemDataFormatter()
    {
    }

    [Token(Token = "0x6001FF0")]
    [Address(RVA = "0xCDCA20", Offset = "0xCDB820", VA = "0x10CDCA20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ItemData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FF1")]
    [Address(RVA = "0xCDC4B0", Offset = "0xCDB2B0", VA = "0x10CDC4B0", Slot = "5")]
    public ItemData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ItemData) null;
    }
  }
}
