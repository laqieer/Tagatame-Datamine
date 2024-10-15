// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int32Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E0")]
  internal sealed class Int32Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E3B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013ED")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int32Double()
    {
    }

    [Token(Token = "0x60013EE")]
    [Address(RVA = "0x5C21B0", Offset = "0x5C0FB0", VA = "0x105C21B0", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013EF")]
    [Address(RVA = "0x5C2240", Offset = "0x5C1040", VA = "0x105C2240")]
    static Int32Double()
    {
    }
  }
}
