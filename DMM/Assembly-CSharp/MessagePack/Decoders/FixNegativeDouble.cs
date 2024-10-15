// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixNegativeDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003DC")]
  internal sealed class FixNegativeDouble : IDoubleDecoder
  {
    [Token(Token = "0x4000E37")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013E1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixNegativeDouble()
    {
    }

    [Token(Token = "0x60013E2")]
    [Address(RVA = "0x5C0140", Offset = "0x5BEF40", VA = "0x105C0140", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013E3")]
    [Address(RVA = "0x5C01D0", Offset = "0x5BEFD0", VA = "0x105C01D0")]
    static FixNegativeDouble()
    {
    }
  }
}
