// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.NilBytes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003BF")]
  internal sealed class NilBytes : IBytesDecoder
  {
    [Token(Token = "0x4000E1E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IBytesDecoder Instance;

    [Token(Token = "0x6001392")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NilBytes()
    {
    }

    [Token(Token = "0x6001393")]
    [Address(RVA = "0x5C8E70", Offset = "0x5C7C70", VA = "0x105C8E70", Slot = "4")]
    public byte[] Read(byte[] bytes, int offset, out int readSize) => (byte[]) null;

    [Token(Token = "0x6001394")]
    [Address(RVA = "0x5C8E80", Offset = "0x5C7C80", VA = "0x105C8E80")]
    static NilBytes()
    {
    }
  }
}
