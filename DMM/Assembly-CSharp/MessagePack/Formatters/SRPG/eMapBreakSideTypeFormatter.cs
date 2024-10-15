// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.eMapBreakSideTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200058B")]
  public sealed class eMapBreakSideTypeFormatter : 
    IMessagePackFormatter<eMapBreakSideType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019EF")]
    [Address(RVA = "0x7A4EB0", Offset = "0x7A3CB0", VA = "0x107A4EB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      eMapBreakSideType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019F0")]
    [Address(RVA = "0x7A4E60", Offset = "0x7A3C60", VA = "0x107A4E60", Slot = "5")]
    public eMapBreakSideType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new eMapBreakSideType();
    }

    [Token(Token = "0x60019F1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public eMapBreakSideTypeFormatter()
    {
    }
  }
}
