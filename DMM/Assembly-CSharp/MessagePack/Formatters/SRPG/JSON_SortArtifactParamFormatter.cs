// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_SortArtifactParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000673")]
  public sealed class JSON_SortArtifactParamFormatter : 
    IMessagePackFormatter<JSON_SortArtifactParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400117E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400117F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CA7")]
    [Address(RVA = "0xBEDC10", Offset = "0xBECA10", VA = "0x10BEDC10")]
    public JSON_SortArtifactParamFormatter()
    {
    }

    [Token(Token = "0x6001CA8")]
    [Address(RVA = "0xBED920", Offset = "0xBEC720", VA = "0x10BED920", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_SortArtifactParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CA9")]
    [Address(RVA = "0xBED4F0", Offset = "0xBEC2F0", VA = "0x10BED4F0", Slot = "5")]
    public JSON_SortArtifactParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_SortArtifactParam) null;
    }
  }
}
