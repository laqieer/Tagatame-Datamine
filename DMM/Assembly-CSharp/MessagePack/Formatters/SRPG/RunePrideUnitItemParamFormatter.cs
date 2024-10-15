// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideUnitItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000986")]
  public sealed class RunePrideUnitItemParamFormatter : 
    IMessagePackFormatter<RunePrideUnitItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400179C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400179D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025E0")]
    [Address(RVA = "0xE4D2A0", Offset = "0xE4C0A0", VA = "0x10E4D2A0")]
    public RunePrideUnitItemParamFormatter()
    {
    }

    [Token(Token = "0x60025E1")]
    [Address(RVA = "0xE4D030", Offset = "0xE4BE30", VA = "0x10E4D030", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideUnitItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025E2")]
    [Address(RVA = "0xE4CCC0", Offset = "0xE4BAC0", VA = "0x10E4CCC0", Slot = "5")]
    public RunePrideUnitItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideUnitItemParam) null;
    }
  }
}
