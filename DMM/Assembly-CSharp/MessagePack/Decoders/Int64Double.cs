// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Int64Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E1")]
  internal sealed class Int64Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E3C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Int64Double()
    {
    }

    [Token(Token = "0x60013F1")]
    [Address(RVA = "0x5C24E0", Offset = "0x5C12E0", VA = "0x105C24E0", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013F2")]
    [Address(RVA = "0x5C2570", Offset = "0x5C1370", VA = "0x105C2570")]
    static Int64Double()
    {
    }
  }
}
