// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000770")]
  public sealed class ItemParamFormatter : IMessagePackFormatter<ItemParam>, IMessagePackFormatter
  {
    [Token(Token = "0x4001378")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001379")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F9E")]
    [Address(RVA = "0xCB0E90", Offset = "0xCAFC90", VA = "0x10CB0E90")]
    public ItemParamFormatter()
    {
    }

    [Token(Token = "0x6001F9F")]
    [Address(RVA = "0xCB0340", Offset = "0xCAF140", VA = "0x10CB0340", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FA0")]
    [Address(RVA = "0xCAF890", Offset = "0xCAE690", VA = "0x10CAF890", Slot = "5")]
    public ItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ItemParam) null;
    }
  }
}
