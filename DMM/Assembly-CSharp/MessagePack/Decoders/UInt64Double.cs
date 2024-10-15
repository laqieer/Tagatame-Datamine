// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt64Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E5")]
  internal sealed class UInt64Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E40")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013FC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt64Double()
    {
    }

    [Token(Token = "0x60013FD")]
    [Address(RVA = "0x5CC2E0", Offset = "0x5CB0E0", VA = "0x105CC2E0", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013FE")]
    [Address(RVA = "0x5CC370", Offset = "0x5CB170", VA = "0x105CC370")]
    static UInt64Double()
    {
    }
  }
}
