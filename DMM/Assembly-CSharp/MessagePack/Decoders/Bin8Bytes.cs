// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Bin8Bytes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C0")]
  internal sealed class Bin8Bytes : IBytesDecoder
  {
    [Token(Token = "0x4000E1F")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesDecoder Instance;

    [Token(Token = "0x6001395")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Bin8Bytes()
    {
    }

    [Token(Token = "0x6001396")]
    [Address(RVA = "0x5BD000", Offset = "0x5BBE00", VA = "0x105BD000", Slot = "4")]
    public byte[] Read(byte[] bytes, int offset, out int readSize) => (byte[]) null;

    [Token(Token = "0x6001397")]
    [Address(RVA = "0x5BD080", Offset = "0x5BBE80", VA = "0x105BD080")]
    static Bin8Bytes()
    {
    }
  }
}
