// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007A0")]
  public sealed class RunePrideDataFormatter : 
    IMessagePackFormatter<RunePrideData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013D8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013D9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600202E")]
    [Address(RVA = "0xCDFD60", Offset = "0xCDEB60", VA = "0x10CDFD60")]
    public RunePrideDataFormatter()
    {
    }

    [Token(Token = "0x600202F")]
    [Address(RVA = "0xCDFB30", Offset = "0xCDE930", VA = "0x10CDFB30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002030")]
    [Address(RVA = "0xCDF820", Offset = "0xCDE620", VA = "0x10CDF820", Slot = "5")]
    public RunePrideData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideData) null;
    }
  }
}
