// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideItemDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006EB")]
  public sealed class JSON_RunePrideItemDataFormatter : 
    IMessagePackFormatter<JSON_RunePrideItemData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400126E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400126F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E0F")]
    [Address(RVA = "0xC30480", Offset = "0xC2F280", VA = "0x10C30480")]
    public JSON_RunePrideItemDataFormatter()
    {
    }

    [Token(Token = "0x6001E10")]
    [Address(RVA = "0xC30320", Offset = "0xC2F120", VA = "0x10C30320", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideItemData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E11")]
    [Address(RVA = "0xC2FFD0", Offset = "0xC2EDD0", VA = "0x10C2FFD0", Slot = "5")]
    public JSON_RunePrideItemData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideItemData) null;
    }
  }
}
