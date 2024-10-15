// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidBytes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C3")]
  internal sealed class InvalidBytes : IBytesDecoder
  {
    [Token(Token = "0x4000E22")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesDecoder Instance;

    [Token(Token = "0x600139E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidBytes()
    {
    }

    [Token(Token = "0x600139F")]
    [Address(RVA = "0x5C3070", Offset = "0x5C1E70", VA = "0x105C3070", Slot = "4")]
    public byte[] Read(byte[] bytes, int offset, out int readSize) => (byte[]) null;

    [Token(Token = "0x60013A0")]
    [Address(RVA = "0x5C3130", Offset = "0x5C1F30", VA = "0x105C3130")]
    static InvalidBytes()
    {
    }
  }
}
