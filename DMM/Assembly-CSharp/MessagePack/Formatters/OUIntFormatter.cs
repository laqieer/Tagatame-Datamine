// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OUIntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000536")]
  public sealed class OUIntFormatter : IMessagePackFormatter<OUInt>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FC8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FC9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018F0")]
    [Address(RVA = "0x6A74C0", Offset = "0x6A62C0", VA = "0x106A74C0")]
    public OUIntFormatter()
    {
    }

    [Token(Token = "0x60018F1")]
    [Address(RVA = "0x6A7470", Offset = "0x6A6270", VA = "0x106A7470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OUInt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018F2")]
    [Address(RVA = "0x6A71D0", Offset = "0x6A5FD0", VA = "0x106A71D0", Slot = "5")]
    public OUInt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OUInt();
    }
  }
}
