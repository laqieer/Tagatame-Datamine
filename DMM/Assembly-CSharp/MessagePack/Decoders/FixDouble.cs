// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixDouble
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003DD")]
  internal sealed class FixDouble : IDoubleDecoder
  {
    [Token(Token = "0x4000E38")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IDoubleDecoder Instance;

    [Token(Token = "0x60013E4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixDouble()
    {
    }

    [Token(Token = "0x60013E5")]
    [Address(RVA = "0x5BED30", Offset = "0x5BDB30", VA = "0x105BED30", Slot = "4")]
    public double Read(byte[] bytes, int offset, out int readSize) => new double();

    [Token(Token = "0x60013E6")]
    [Address(RVA = "0x5BEDC0", Offset = "0x5BDBC0", VA = "0x105BEDC0")]
    static FixDouble()
    {
    }
  }
}
