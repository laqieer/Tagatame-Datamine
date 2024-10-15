// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MagnificationParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200095A")]
  public sealed class JSON_MagnificationParamFormatter : 
    IMessagePackFormatter<JSON_MagnificationParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001744")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001745")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600255C")]
    [Address(RVA = "0xE16340", Offset = "0xE15140", VA = "0x10E16340")]
    public JSON_MagnificationParamFormatter()
    {
    }

    [Token(Token = "0x600255D")]
    [Address(RVA = "0xE161E0", Offset = "0xE14FE0", VA = "0x10E161E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MagnificationParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600255E")]
    [Address(RVA = "0xE15EA0", Offset = "0xE14CA0", VA = "0x10E15EA0", Slot = "5")]
    public JSON_MagnificationParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MagnificationParam) null;
    }
  }
}
