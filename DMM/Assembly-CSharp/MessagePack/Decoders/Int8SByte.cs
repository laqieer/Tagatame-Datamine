// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int8SByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003CC")]
  internal sealed class Int8SByte : ISByteDecoder
  {
    [Token(Token = "0x4000E29")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISByteDecoder Instance;

    [Token(Token = "0x60013B5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int8SByte()
    {
    }

    [Token(Token = "0x60013B6")]
    [Address(RVA = "0x5C2AF0", Offset = "0x5C18F0", VA = "0x105C2AF0", Slot = "4")]
    public sbyte Read(byte[] bytes, int offset, out int readSize) => new sbyte();

    [Token(Token = "0x60013B7")]
    [Address(RVA = "0x5C2B20", Offset = "0x5C1920", VA = "0x105C2B20")]
    static Int8SByte()
    {
    }
  }
}
