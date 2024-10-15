// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESexFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000554")]
  public sealed class ESexFormatter : IMessagePackFormatter<ESex>, IMessagePackFormatter
  {
    [Token(Token = "0x600194A")]
    [Address(RVA = "0x69BA40", Offset = "0x69A840", VA = "0x1069BA40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESex value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600194B")]
    [Address(RVA = "0x69B9F0", Offset = "0x69A7F0", VA = "0x1069B9F0", Slot = "5")]
    public ESex Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESex();
    }

    [Token(Token = "0x600194C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESexFormatter()
    {
    }
  }
}
