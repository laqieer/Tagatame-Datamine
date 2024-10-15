// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FixConceptCardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009BC")]
  public sealed class FixConceptCardParamFormatter : 
    IMessagePackFormatter<FixConceptCardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001808")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001809")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002682")]
    [Address(RVA = "0xE675F0", Offset = "0xE663F0", VA = "0x10E675F0")]
    public FixConceptCardParamFormatter()
    {
    }

    [Token(Token = "0x6002683")]
    [Address(RVA = "0xE67580", Offset = "0xE66380", VA = "0x10E67580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FixConceptCardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002684")]
    [Address(RVA = "0xE67310", Offset = "0xE66110", VA = "0x10E67310", Slot = "5")]
    public FixConceptCardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FixConceptCardParam) null;
    }
  }
}
