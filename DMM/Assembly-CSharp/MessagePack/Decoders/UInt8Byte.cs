// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8Byte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003BC")]
  internal sealed class UInt8Byte : IByteDecoder
  {
    [Token(Token = "0x4000E1C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IByteDecoder Instance;

    [Token(Token = "0x600138B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8Byte()
    {
    }

    [Token(Token = "0x600138C")]
    [Address(RVA = "0x5C2AF0", Offset = "0x5C18F0", VA = "0x105C2AF0", Slot = "4")]
    public byte Read(byte[] bytes, int offset, out int readSize) => new byte();

    [Token(Token = "0x600138D")]
    [Address(RVA = "0x5CC730", Offset = "0x5CB530", VA = "0x105CC730")]
    static UInt8Byte()
    {
    }
  }
}
