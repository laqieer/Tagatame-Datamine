// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eMapBreakAITypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200058A")]
  public sealed class eMapBreakAITypeFormatter : 
    IMessagePackFormatter<eMapBreakAIType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019EC")]
    [Address(RVA = "0x7A4CD0", Offset = "0x7A3AD0", VA = "0x107A4CD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eMapBreakAIType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019ED")]
    [Address(RVA = "0x7A4C80", Offset = "0x7A3A80", VA = "0x107A4C80", Slot = "5")]
    public eMapBreakAIType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eMapBreakAIType();
    }

    [Token(Token = "0x60019EE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eMapBreakAITypeFormatter()
    {
    }
  }
}
