// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EElementFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000547")]
  public sealed class EElementFormatter : IMessagePackFormatter<EElement>, IMessagePackFormatter
  {
    [Token(Token = "0x6001923")]
    [Address(RVA = "0x69B5E0", Offset = "0x69A3E0", VA = "0x1069B5E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EElement value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001924")]
    [Address(RVA = "0x69B590", Offset = "0x69A390", VA = "0x1069B590", Slot = "5")]
    public EElement Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EElement();
    }

    [Token(Token = "0x6001925")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EElementFormatter()
    {
    }
  }
}
