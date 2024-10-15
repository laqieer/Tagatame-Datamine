// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Bin32Bytes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C2")]
  internal sealed class Bin32Bytes : IBytesDecoder
  {
    [Token(Token = "0x4000E21")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesDecoder Instance;

    [Token(Token = "0x600139B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Bin32Bytes()
    {
    }

    [Token(Token = "0x600139C")]
    [Address(RVA = "0x5BCDF0", Offset = "0x5BBBF0", VA = "0x105BCDF0", Slot = "4")]
    public byte[] Read(byte[] bytes, int offset, out int readSize) => (byte[]) null;

    [Token(Token = "0x600139D")]
    [Address(RVA = "0x5BCEC0", Offset = "0x5BBCC0", VA = "0x105BCEC0")]
    static Bin32Bytes()
    {
    }
  }
}
