// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ProductParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B2A")]
  public sealed class JSON_ProductParamFormatter : 
    IMessagePackFormatter<JSON_ProductParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AE4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AE5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002ACC")]
    [Address(RVA = "0xF67770", Offset = "0xF66570", VA = "0x10F67770")]
    public JSON_ProductParamFormatter()
    {
    }

    [Token(Token = "0x6002ACD")]
    [Address(RVA = "0xF67380", Offset = "0xF66180", VA = "0x10F67380", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ProductParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002ACE")]
    [Address(RVA = "0xF66E50", Offset = "0xF65C50", VA = "0x10F66E50", Slot = "5")]
    public JSON_ProductParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ProductParam) null;
    }
  }
}
