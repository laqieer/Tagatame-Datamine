// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterArtifactParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000671")]
  public sealed class JSON_FilterArtifactParamFormatter : 
    IMessagePackFormatter<JSON_FilterArtifactParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400117A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400117B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CA1")]
    [Address(RVA = "0xBE2960", Offset = "0xBE1760", VA = "0x10BE2960")]
    public JSON_FilterArtifactParamFormatter()
    {
    }

    [Token(Token = "0x6001CA2")]
    [Address(RVA = "0xBE2630", Offset = "0xBE1430", VA = "0x10BE2630", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterArtifactParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CA3")]
    [Address(RVA = "0xBE21C0", Offset = "0xBE0FC0", VA = "0x10BE21C0", Slot = "5")]
    public JSON_FilterArtifactParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterArtifactParam) null;
    }
  }
}
