// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OStringFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000530")]
  public sealed class OStringFormatter : IMessagePackFormatter<OString>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FBC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FBD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018DE")]
    [Address(RVA = "0x6A7140", Offset = "0x6A5F40", VA = "0x106A7140")]
    public OStringFormatter()
    {
    }

    [Token(Token = "0x60018DF")]
    [Address(RVA = "0x6A70F0", Offset = "0x6A5EF0", VA = "0x106A70F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OString value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018E0")]
    [Address(RVA = "0x6A6E80", Offset = "0x6A5C80", VA = "0x106A6E80", Slot = "5")]
    public OString Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OString();
    }
  }
}
