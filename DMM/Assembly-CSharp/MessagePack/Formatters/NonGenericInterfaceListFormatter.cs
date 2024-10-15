// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NonGenericInterfaceListFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200049D")]
  public sealed class NonGenericInterfaceListFormatter : 
    IMessagePackFormatter<IList>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F42")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<IList> Instance;

    [Token(Token = "0x60016B6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NonGenericInterfaceListFormatter()
    {
    }

    [Token(Token = "0x60016B7")]
    [Address(RVA = "0x6A2330", Offset = "0x6A1130", VA = "0x106A2330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      IList value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60016B8")]
    [Address(RVA = "0x6A2130", Offset = "0x6A0F30", VA = "0x106A2130", Slot = "5")]
    public IList Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (IList) null;
    }

    [Token(Token = "0x60016B9")]
    [Address(RVA = "0x6A2650", Offset = "0x6A1450", VA = "0x106A2650")]
    static NonGenericInterfaceListFormatter()
    {
    }
  }
}
