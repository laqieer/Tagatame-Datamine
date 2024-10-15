// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ReplacePeriodFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200069A")]
  public sealed class JSON_ReplacePeriodFormatter : 
    IMessagePackFormatter<JSON_ReplacePeriod>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D1C")]
    [Address(RVA = "0xC010A0", Offset = "0xBFFEA0", VA = "0x10C010A0")]
    public JSON_ReplacePeriodFormatter()
    {
    }

    [Token(Token = "0x6001D1D")]
    [Address(RVA = "0xC00EF0", Offset = "0xBFFCF0", VA = "0x10C00EF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ReplacePeriod value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D1E")]
    [Address(RVA = "0xC00B60", Offset = "0xBFF960", VA = "0x10C00B60", Slot = "5")]
    public JSON_ReplacePeriod Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ReplacePeriod) null;
    }
  }
}
