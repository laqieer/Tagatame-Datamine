// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.DynamicTransformUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007D1")]
  public sealed class DynamicTransformUnitParamFormatter : 
    IMessagePackFormatter<DynamicTransformUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001432")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001433")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020C1")]
    [Address(RVA = "0xD15150", Offset = "0xD13F50", VA = "0x10D15150")]
    public DynamicTransformUnitParamFormatter()
    {
    }

    [Token(Token = "0x60020C2")]
    [Address(RVA = "0xD14A10", Offset = "0xD13810", VA = "0x10D14A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DynamicTransformUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020C3")]
    [Address(RVA = "0xD146B0", Offset = "0xD134B0", VA = "0x10D146B0", Slot = "5")]
    public DynamicTransformUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (DynamicTransformUnitParam) null;
    }
  }
}
