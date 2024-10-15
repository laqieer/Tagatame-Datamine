// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DynamicTransformUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000645")]
  public sealed class JSON_DynamicTransformUnitParamFormatter : 
    IMessagePackFormatter<JSON_DynamicTransformUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001122")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001123")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C1D")]
    [Address(RVA = "0xBD2FC0", Offset = "0xBD1DC0", VA = "0x10BD2FC0")]
    public JSON_DynamicTransformUnitParamFormatter()
    {
    }

    [Token(Token = "0x6001C1E")]
    [Address(RVA = "0xBD28C0", Offset = "0xBD16C0", VA = "0x10BD28C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DynamicTransformUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C1F")]
    [Address(RVA = "0xBD2030", Offset = "0xBD0E30", VA = "0x10BD2030", Slot = "5")]
    public JSON_DynamicTransformUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DynamicTransformUnitParam) null;
    }
  }
}
