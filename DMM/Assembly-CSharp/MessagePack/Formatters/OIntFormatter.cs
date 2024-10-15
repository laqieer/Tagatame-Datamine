// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OIntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200052E")]
  public sealed class OIntFormatter : IMessagePackFormatter<OInt>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FB8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FB9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018D8")]
    [Address(RVA = "0x6A5D40", Offset = "0x6A4B40", VA = "0x106A5D40")]
    public OIntFormatter()
    {
    }

    [Token(Token = "0x60018D9")]
    [Address(RVA = "0x6A5CF0", Offset = "0x6A4AF0", VA = "0x106A5CF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OInt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018DA")]
    [Address(RVA = "0x6A5A50", Offset = "0x6A4850", VA = "0x106A5A50", Slot = "5")]
    public OInt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OInt();
    }
  }
}
