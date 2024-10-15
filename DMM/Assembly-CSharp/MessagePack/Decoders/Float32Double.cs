// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Float32Double
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003E6")]
  internal sealed class Float32Double : IDoubleDecoder
  {
    [Token(Token = "0x4000E41")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013FF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Float32Double()
    {
    }

    [Token(Token = "0x6001400")]
    [Address(RVA = "0x5C0810", Offset = "0x5BF610", VA = "0x105C0810", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x6001401")]
    [Address(RVA = "0x5C0840", Offset = "0x5BF640", VA = "0x105C0840")]
    static Float32Double()
    {
    }
  }
}
