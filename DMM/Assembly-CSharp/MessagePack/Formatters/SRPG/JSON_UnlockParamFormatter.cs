// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_UnlockParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005F1")]
  public sealed class JSON_UnlockParamFormatter : 
    IMessagePackFormatter<JSON_UnlockParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400107A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400107B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B21")]
    [Address(RVA = "0xB9FEC0", Offset = "0xB9ECC0", VA = "0x10B9FEC0")]
    public JSON_UnlockParamFormatter()
    {
    }

    [Token(Token = "0x6001B22")]
    [Address(RVA = "0xB9FC90", Offset = "0xB9EA90", VA = "0x10B9FC90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_UnlockParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B23")]
    [Address(RVA = "0xB9F890", Offset = "0xB9E690", VA = "0x10B9F890", Slot = "5")]
    public JSON_UnlockParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_UnlockParam) null;
    }
  }
}
