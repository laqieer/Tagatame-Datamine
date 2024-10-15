// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePridePanelPatternParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B1A")]
  public sealed class RunePridePanelPatternParamFormatter : 
    IMessagePackFormatter<RunePridePanelPatternParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AC4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AC5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A9C")]
    [Address(RVA = "0xF45810", Offset = "0xF44610", VA = "0x10F45810")]
    public RunePridePanelPatternParamFormatter()
    {
    }

    [Token(Token = "0x6002A9D")]
    [Address(RVA = "0xF45630", Offset = "0xF44430", VA = "0x10F45630", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePridePanelPatternParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A9E")]
    [Address(RVA = "0xF45320", Offset = "0xF44120", VA = "0x10F45320", Slot = "5")]
    public RunePridePanelPatternParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePridePanelPatternParam) null;
    }
  }
}
