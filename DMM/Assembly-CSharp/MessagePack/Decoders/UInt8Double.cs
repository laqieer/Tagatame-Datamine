// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt8Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E2")]
  internal sealed class UInt8Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E3D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013F3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt8Double()
    {
    }

    [Token(Token = "0x60013F4")]
    [Address(RVA = "0x5CC790", Offset = "0x5CB590", VA = "0x105CC790", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013F5")]
    [Address(RVA = "0x5CC820", Offset = "0x5CB620", VA = "0x105CC820")]
    static UInt8Double()
    {
    }
  }
}
