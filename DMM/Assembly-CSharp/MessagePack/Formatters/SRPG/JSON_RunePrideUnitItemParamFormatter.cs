// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideUnitItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006EA")]
  public sealed class JSON_RunePrideUnitItemParamFormatter : 
    IMessagePackFormatter<JSON_RunePrideUnitItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400126C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400126D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E0C")]
    [Address(RVA = "0xC36980", Offset = "0xC35780", VA = "0x10C36980")]
    public JSON_RunePrideUnitItemParamFormatter()
    {
    }

    [Token(Token = "0x6001E0D")]
    [Address(RVA = "0xC367D0", Offset = "0xC355D0", VA = "0x10C367D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideUnitItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E0E")]
    [Address(RVA = "0xC36440", Offset = "0xC35240", VA = "0x10C36440", Slot = "5")]
    public JSON_RunePrideUnitItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideUnitItemParam) null;
    }
  }
}
