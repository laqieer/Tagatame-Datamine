// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FilterRuneParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200066D")]
  public sealed class JSON_FilterRuneParamFormatter : 
    IMessagePackFormatter<JSON_FilterRuneParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001172")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001173")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C95")]
    [Address(RVA = "0xBE5E50", Offset = "0xBE4C50", VA = "0x10BE5E50")]
    public JSON_FilterRuneParamFormatter()
    {
    }

    [Token(Token = "0x6001C96")]
    [Address(RVA = "0xBE5B80", Offset = "0xBE4980", VA = "0x10BE5B80", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FilterRuneParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C97")]
    [Address(RVA = "0xBE5770", Offset = "0xBE4570", VA = "0x10BE5770", Slot = "5")]
    public JSON_FilterRuneParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FilterRuneParam) null;
    }
  }
}
