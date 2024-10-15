// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ArtifactParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000787")]
  public sealed class ArtifactParamFormatter : 
    IMessagePackFormatter<ArtifactParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013A6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013A7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FE3")]
    [Address(RVA = "0xCC03B0", Offset = "0xCBF1B0", VA = "0x10CC03B0")]
    public ArtifactParamFormatter()
    {
    }

    [Token(Token = "0x6001FE4")]
    [Address(RVA = "0xCBF300", Offset = "0xCBE100", VA = "0x10CBF300", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ArtifactParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FE5")]
    [Address(RVA = "0xCBE1B0", Offset = "0xCBCFB0", VA = "0x10CBE1B0", Slot = "5")]
    public ArtifactParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ArtifactParam) null;
    }
  }
}
