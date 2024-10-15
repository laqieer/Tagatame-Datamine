// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JukeBoxParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC1")]
  public sealed class JukeBoxParamFormatter : 
    IMessagePackFormatter<JukeBoxParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A12")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A13")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002991")]
    [Address(RVA = "0xF0EAC0", Offset = "0xF0D8C0", VA = "0x10F0EAC0")]
    public JukeBoxParamFormatter()
    {
    }

    [Token(Token = "0x6002992")]
    [Address(RVA = "0xF0E3B0", Offset = "0xF0D1B0", VA = "0x10F0E3B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JukeBoxParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002993")]
    [Address(RVA = "0xF0DFC0", Offset = "0xF0CDC0", VA = "0x10F0DFC0", Slot = "5")]
    public JukeBoxParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JukeBoxParam) null;
    }
  }
}
