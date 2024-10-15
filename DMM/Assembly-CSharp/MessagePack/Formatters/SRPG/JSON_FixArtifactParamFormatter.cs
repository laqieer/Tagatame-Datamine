// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FixArtifactParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005D7")]
  public sealed class JSON_FixArtifactParamFormatter : 
    IMessagePackFormatter<JSON_FixArtifactParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001046")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001047")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AD3")]
    [Address(RVA = "0x94F0B0", Offset = "0x94DEB0", VA = "0x1094F0B0")]
    public JSON_FixArtifactParamFormatter()
    {
    }

    [Token(Token = "0x6001AD4")]
    [Address(RVA = "0x94ECD0", Offset = "0x94DAD0", VA = "0x1094ECD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FixArtifactParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AD5")]
    [Address(RVA = "0x94E700", Offset = "0x94D500", VA = "0x1094E700", Slot = "5")]
    public JSON_FixArtifactParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FixArtifactParam) null;
    }
  }
}
