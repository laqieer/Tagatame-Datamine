// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ELineTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000541")]
  public sealed class ELineTypeFormatter : IMessagePackFormatter<ELineType>, IMessagePackFormatter
  {
    [Token(Token = "0x6001911")]
    [Address(RVA = "0x69B900", Offset = "0x69A700", VA = "0x1069B900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ELineType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001912")]
    [Address(RVA = "0x69B8B0", Offset = "0x69A6B0", VA = "0x1069B8B0", Slot = "5")]
    public ELineType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ELineType();
    }

    [Token(Token = "0x6001913")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ELineTypeFormatter()
    {
    }
  }
}
