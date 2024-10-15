// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.BuffFlagsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000562")]
  public sealed class BuffFlagsFormatter : IMessagePackFormatter<BuffFlags>, IMessagePackFormatter
  {
    [Token(Token = "0x6001974")]
    [Address(RVA = "0x694A10", Offset = "0x693810", VA = "0x10694A10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BuffFlags value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001975")]
    [Address(RVA = "0x6949C0", Offset = "0x6937C0", VA = "0x106949C0", Slot = "5")]
    public BuffFlags Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new BuffFlags();
    }

    [Token(Token = "0x6001976")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuffFlagsFormatter()
    {
    }
  }
}
