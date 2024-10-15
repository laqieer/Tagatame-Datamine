// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OBoolFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200052F")]
  public sealed class OBoolFormatter : IMessagePackFormatter<OBool>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FBA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FBB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60018DB")]
    [Address(RVA = "0x6A5640", Offset = "0x6A4440", VA = "0x106A5640")]
    public OBoolFormatter()
    {
    }

    [Token(Token = "0x60018DC")]
    [Address(RVA = "0x6A55F0", Offset = "0x6A43F0", VA = "0x106A55F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      OBool value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018DD")]
    [Address(RVA = "0x6A5350", Offset = "0x6A4150", VA = "0x106A5350", Slot = "5")]
    public OBool Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new OBool();
    }
  }
}
