// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EItemTabTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000559")]
  public sealed class EItemTabTypeFormatter : 
    IMessagePackFormatter<EItemTabType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001959")]
    [Address(RVA = "0x69B7C0", Offset = "0x69A5C0", VA = "0x1069B7C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      EItemTabType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600195A")]
    [Address(RVA = "0x69B770", Offset = "0x69A570", VA = "0x1069B770", Slot = "5")]
    public EItemTabType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new EItemTabType();
    }

    [Token(Token = "0x600195B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EItemTabTypeFormatter()
    {
    }
  }
}
