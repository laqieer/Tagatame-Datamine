// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.VS_MODEFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000596")]
  public sealed class VS_MODEFormatter : IMessagePackFormatter<VS_MODE>, IMessagePackFormatter
  {
    [Token(Token = "0x6001A10")]
    [Address(RVA = "0x7A4C30", Offset = "0x7A3A30", VA = "0x107A4C30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      VS_MODE value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A11")]
    [Address(RVA = "0x7A4BE0", Offset = "0x7A39E0", VA = "0x107A4BE0", Slot = "5")]
    public VS_MODE Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new VS_MODE();
    }

    [Token(Token = "0x6001A12")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VS_MODEFormatter()
    {
    }
  }
}
