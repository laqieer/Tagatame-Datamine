// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceSByteBlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004CD")]
  public sealed class ForceSByteBlockArrayFormatter : 
    IMessagePackFormatter<sbyte[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F60")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceSByteBlockArrayFormatter Instance;

    [Token(Token = "0x6001770")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceSByteBlockArrayFormatter()
    {
    }

    [Token(Token = "0x6001771")]
    [Address(RVA = "0x69D890", Offset = "0x69C690", VA = "0x1069D890", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      sbyte[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001772")]
    [Address(RVA = "0x69D6A0", Offset = "0x69C4A0", VA = "0x1069D6A0", Slot = "5")]
    public sbyte[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (sbyte[]) null;
    }

    [Token(Token = "0x6001773")]
    [Address(RVA = "0x69DA30", Offset = "0x69C830", VA = "0x1069DA30")]
    static ForceSByteBlockArrayFormatter()
    {
    }
  }
}
