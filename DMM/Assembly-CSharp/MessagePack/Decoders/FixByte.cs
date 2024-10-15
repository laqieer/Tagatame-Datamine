// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003BB")]
  internal sealed class FixByte : IByteDecoder
  {
    [Token(Token = "0x4000E1B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IByteDecoder Instance;

    [Token(Token = "0x6001388")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixByte()
    {
    }

    [Token(Token = "0x6001389")]
    [Address(RVA = "0x5BECA0", Offset = "0x5BDAA0", VA = "0x105BECA0", Slot = "4")]
    public byte Read(byte[] bytes, int offset, out int readSize) => new byte();

    [Token(Token = "0x600138A")]
    [Address(RVA = "0x5BECD0", Offset = "0x5BDAD0", VA = "0x105BECD0")]
    static FixByte()
    {
    }
  }
}
