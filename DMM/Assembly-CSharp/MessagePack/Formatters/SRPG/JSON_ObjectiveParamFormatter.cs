// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ObjectiveParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000985")]
  public sealed class JSON_ObjectiveParamFormatter : 
    IMessagePackFormatter<JSON_ObjectiveParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400179A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400179B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025DD")]
    [Address(RVA = "0xE3AD10", Offset = "0xE39B10", VA = "0x10E3AD10")]
    public JSON_ObjectiveParamFormatter()
    {
    }

    [Token(Token = "0x60025DE")]
    [Address(RVA = "0xE3AB30", Offset = "0xE39930", VA = "0x10E3AB30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ObjectiveParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025DF")]
    [Address(RVA = "0xE3A7F0", Offset = "0xE395F0", VA = "0x10E3A7F0", Slot = "5")]
    public JSON_ObjectiveParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ObjectiveParam) null;
    }
  }
}
