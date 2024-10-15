// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ArtifactParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005DF")]
  public sealed class JSON_ArtifactParamFormatter : 
    IMessagePackFormatter<JSON_ArtifactParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001056")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001057")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AEB")]
    [Address(RVA = "0xB39F70", Offset = "0xB38D70", VA = "0x10B39F70")]
    public JSON_ArtifactParamFormatter()
    {
    }

    [Token(Token = "0x6001AEC")]
    [Address(RVA = "0xB38CD0", Offset = "0xB37AD0", VA = "0x10B38CD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ArtifactParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AED")]
    [Address(RVA = "0xB378C0", Offset = "0xB366C0", VA = "0x10B378C0", Slot = "5")]
    public JSON_ArtifactParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ArtifactParam) null;
    }
  }
}
