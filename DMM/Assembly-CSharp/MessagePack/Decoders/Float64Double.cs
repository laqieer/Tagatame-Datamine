// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Float64Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E7")]
  internal sealed class Float64Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E42")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x6001402")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Float64Double()
    {
    }

    [Token(Token = "0x6001403")]
    [Address(RVA = "0x5C0900", Offset = "0x5BF700", VA = "0x105C0900", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x6001404")]
    [Address(RVA = "0x5C0940", Offset = "0x5BF740", VA = "0x105C0940")]
    static Float64Double()
    {
    }
  }
}
