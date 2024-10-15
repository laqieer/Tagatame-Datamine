// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E8")]
  internal sealed class InvalidDouble : IDoubleDecoder
  {
    [Token(Token = "0x4000E43")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x6001405")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidDouble()
    {
    }

    [Token(Token = "0x6001406")]
    [Address(RVA = "0x5C32B0", Offset = "0x5C20B0", VA = "0x105C32B0", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x6001407")]
    [Address(RVA = "0x5C3370", Offset = "0x5C2170", VA = "0x105C3370")]
    static InvalidDouble()
    {
    }
  }
}
