// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EEventTriggerFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000586")]
  public sealed class EEventTriggerFormatter : 
    IMessagePackFormatter<EEventTrigger>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019E0")]
    [Address(RVA = "0x78DC90", Offset = "0x78CA90", VA = "0x1078DC90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EEventTrigger value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019E1")]
    [Address(RVA = "0x78DC40", Offset = "0x78CA40", VA = "0x1078DC40", Slot = "5")]
    public EEventTrigger Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EEventTrigger();
    }

    [Token(Token = "0x60019E2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EEventTriggerFormatter()
    {
    }
  }
}
