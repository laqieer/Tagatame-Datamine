// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NonGenericInterfaceDictionaryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200049F")]
  public sealed class NonGenericInterfaceDictionaryFormatter : 
    IMessagePackFormatter<IDictionary>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F43")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<IDictionary> Instance;

    [Token(Token = "0x60016BD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NonGenericInterfaceDictionaryFormatter()
    {
    }

    [Token(Token = "0x60016BE")]
    [Address(RVA = "0x6A1D00", Offset = "0x6A0B00", VA = "0x106A1D00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      IDictionary value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60016BF")]
    [Address(RVA = "0x6A1AC0", Offset = "0x6A08C0", VA = "0x106A1AC0", Slot = "5")]
    public IDictionary Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (IDictionary) null;
    }

    [Token(Token = "0x60016C0")]
    [Address(RVA = "0x6A20D0", Offset = "0x6A0ED0", VA = "0x106A20D0")]
    static NonGenericInterfaceDictionaryFormatter()
    {
    }
  }
}
