// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixSByte
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003CB")]
  internal sealed class FixSByte : ISByteDecoder
  {
    [Token(Token = "0x4000E28")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISByteDecoder Instance;

    [Token(Token = "0x60013B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixSByte()
    {
    }

    [Token(Token = "0x60013B3")]
    [Address(RVA = "0x5BECA0", Offset = "0x5BDAA0", VA = "0x105BECA0", Slot = "4")]
    public sbyte Read(byte[] bytes, int offset, out int readSize) => new sbyte();

    [Token(Token = "0x60013B4")]
    [Address(RVA = "0x5C04C0", Offset = "0x5BF2C0", VA = "0x105C04C0")]
    static FixSByte()
    {
    }
  }
}
