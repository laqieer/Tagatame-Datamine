// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Bin16Bytes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003C1")]
  internal sealed class Bin16Bytes : IBytesDecoder
  {
    [Token(Token = "0x4000E20")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesDecoder Instance;

    [Token(Token = "0x6001398")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Bin16Bytes()
    {
    }

    [Token(Token = "0x6001399")]
    [Address(RVA = "0x5BCBD0", Offset = "0x5BB9D0", VA = "0x105BCBD0", Slot = "4")]
    public byte[] Read(byte[] bytes, int offset, out int readSize) => (byte[]) null;

    [Token(Token = "0x600139A")]
    [Address(RVA = "0x5BCC60", Offset = "0x5BBA60", VA = "0x105BCC60")]
    static Bin16Bytes()
    {
    }
  }
}
