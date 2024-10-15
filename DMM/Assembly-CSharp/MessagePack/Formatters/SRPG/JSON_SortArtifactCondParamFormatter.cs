// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SortArtifactCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000672")]
  public sealed class JSON_SortArtifactCondParamFormatter : 
    IMessagePackFormatter<JSON_SortArtifactCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400117C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400117D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CA4")]
    [Address(RVA = "0xBED220", Offset = "0xBEC020", VA = "0x10BED220")]
    public JSON_SortArtifactCondParamFormatter()
    {
    }

    [Token(Token = "0x6001CA5")]
    [Address(RVA = "0xBED000", Offset = "0xBEBE00", VA = "0x10BED000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SortArtifactCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CA6")]
    [Address(RVA = "0xBECC10", Offset = "0xBEBA10", VA = "0x10BECC10", Slot = "5")]
    public JSON_SortArtifactCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SortArtifactCondParam) null;
    }
  }
}
