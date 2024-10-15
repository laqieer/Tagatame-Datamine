// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OByteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000533")]
  public sealed class OByteFormatter : IMessagePackFormatter<OByte>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FC2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FC3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018E7")]
    [Address(RVA = "0x6A59C0", Offset = "0x6A47C0", VA = "0x106A59C0")]
    public OByteFormatter()
    {
    }

    [Token(Token = "0x60018E8")]
    [Address(RVA = "0x6A5970", Offset = "0x6A4770", VA = "0x106A5970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OByte value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018E9")]
    [Address(RVA = "0x6A56D0", Offset = "0x6A44D0", VA = "0x106A56D0", Slot = "5")]
    public OByte Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OByte();
    }
  }
}
