// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceUInt16BlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C2")]
  public sealed class ForceUInt16BlockArrayFormatter : 
    IMessagePackFormatter<ushort[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F55")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceUInt16BlockArrayFormatter Instance;

    [Token(Token = "0x6001744")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceUInt16BlockArrayFormatter()
    {
    }

    [Token(Token = "0x6001745")]
    [Address(RVA = "0x69DDA0", Offset = "0x69CBA0", VA = "0x1069DDA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ushort[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001746")]
    [Address(RVA = "0x69DB90", Offset = "0x69C990", VA = "0x1069DB90", Slot = "5")]
    public ushort[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ushort[]) null;
    }

    [Token(Token = "0x6001747")]
    [Address(RVA = "0x69DF50", Offset = "0x69CD50", VA = "0x1069DF50")]
    static ForceUInt16BlockArrayFormatter()
    {
    }
  }
}
