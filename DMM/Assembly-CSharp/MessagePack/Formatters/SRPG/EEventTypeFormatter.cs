// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EEventTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000587")]
  public sealed class EEventTypeFormatter : IMessagePackFormatter<EEventType>, IMessagePackFormatter
  {
    [Token(Token = "0x60019E3")]
    [Address(RVA = "0x78DD30", Offset = "0x78CB30", VA = "0x1078DD30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EEventType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019E4")]
    [Address(RVA = "0x78DCE0", Offset = "0x78CAE0", VA = "0x1078DCE0", Slot = "5")]
    public EEventType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EEventType();
    }

    [Token(Token = "0x60019E5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EEventTypeFormatter()
    {
    }
  }
}
