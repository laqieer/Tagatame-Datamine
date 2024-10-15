// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OLongFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000531")]
  public sealed class OLongFormatter : IMessagePackFormatter<OLong>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FBE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FBF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018E1")]
    [Address(RVA = "0x6A66F0", Offset = "0x6A54F0", VA = "0x106A66F0")]
    public OLongFormatter()
    {
    }

    [Token(Token = "0x60018E2")]
    [Address(RVA = "0x6A66A0", Offset = "0x6A54A0", VA = "0x106A66A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OLong value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018E3")]
    [Address(RVA = "0x6A6400", Offset = "0x6A5200", VA = "0x106A6400", Slot = "5")]
    public OLong Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OLong();
    }
  }
}
