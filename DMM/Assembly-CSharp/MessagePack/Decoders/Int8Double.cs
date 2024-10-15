// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int8Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003DE")]
  internal sealed class Int8Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E39")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013E7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int8Double()
    {
    }

    [Token(Token = "0x60013E8")]
    [Address(RVA = "0x5C2850", Offset = "0x5C1650", VA = "0x105C2850", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013E9")]
    [Address(RVA = "0x5C28E0", Offset = "0x5C16E0", VA = "0x105C28E0")]
    static Int8Double()
    {
    }
  }
}
