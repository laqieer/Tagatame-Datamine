// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceInt32BlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004BC")]
  public sealed class ForceInt32BlockArrayFormatter : 
    IMessagePackFormatter<int[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F4F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceInt32BlockArrayFormatter Instance;

    [Token(Token = "0x600172C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceInt32BlockArrayFormatter()
    {
    }

    [Token(Token = "0x600172D")]
    [Address(RVA = "0x69CD50", Offset = "0x69BB50", VA = "0x1069CD50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      int[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600172E")]
    [Address(RVA = "0x69CB50", Offset = "0x69B950", VA = "0x1069CB50", Slot = "5")]
    public int[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (int[]) null;
    }

    [Token(Token = "0x600172F")]
    [Address(RVA = "0x69CF50", Offset = "0x69BD50", VA = "0x1069CF50")]
    static ForceInt32BlockArrayFormatter()
    {
    }
  }
}
