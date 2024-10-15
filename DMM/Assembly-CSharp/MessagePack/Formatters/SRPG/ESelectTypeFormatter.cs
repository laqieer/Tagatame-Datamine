// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ESelectTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000542")]
  public sealed class ESelectTypeFormatter : 
    IMessagePackFormatter<ESelectType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001914")]
    [Address(RVA = "0x69B9A0", Offset = "0x69A7A0", VA = "0x1069B9A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ESelectType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001915")]
    [Address(RVA = "0x69B950", Offset = "0x69A750", VA = "0x1069B950", Slot = "5")]
    public ESelectType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ESelectType();
    }

    [Token(Token = "0x6001916")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ESelectTypeFormatter()
    {
    }
  }
}
