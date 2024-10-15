// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eMapBreakClashTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000589")]
  public sealed class eMapBreakClashTypeFormatter : 
    IMessagePackFormatter<eMapBreakClashType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019E9")]
    [Address(RVA = "0x7A4D70", Offset = "0x7A3B70", VA = "0x107A4D70", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eMapBreakClashType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019EA")]
    [Address(RVA = "0x7A4D20", Offset = "0x7A3B20", VA = "0x107A4D20", Slot = "5")]
    public eMapBreakClashType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eMapBreakClashType();
    }

    [Token(Token = "0x60019EB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eMapBreakClashTypeFormatter()
    {
    }
  }
}
