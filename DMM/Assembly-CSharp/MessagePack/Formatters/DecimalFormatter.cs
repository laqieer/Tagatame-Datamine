// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.DecimalFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000504")]
  public sealed class DecimalFormatter : IMessagePackFormatter<Decimal>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F94")]
    [FieldOffset(Offset = "0x0")]
    public static readonly DecimalFormatter Instance;

    [Token(Token = "0x6001841")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private DecimalFormatter()
    {
    }

    [Token(Token = "0x6001842")]
    [Address(RVA = "0x697F40", Offset = "0x696D40", VA = "0x10697F40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Decimal value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001843")]
    [Address(RVA = "0x697E80", Offset = "0x696C80", VA = "0x10697E80", Slot = "5")]
    public Decimal Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return 0M;
    }

    [Token(Token = "0x6001844")]
    [Address(RVA = "0x697FF0", Offset = "0x696DF0", VA = "0x10697FF0")]
    static DecimalFormatter()
    {
    }
  }
}
