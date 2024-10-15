// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixNegativeInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F2")]
  internal sealed class FixNegativeInt32 : IInt32Decoder
  {
    [Token(Token = "0x4000E4B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x600141F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixNegativeInt32()
    {
    }

    [Token(Token = "0x6001420")]
    [Address(RVA = "0x5C03A0", Offset = "0x5BF1A0", VA = "0x105C03A0", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001421")]
    [Address(RVA = "0x5C03D0", Offset = "0x5BF1D0", VA = "0x105C03D0")]
    static FixNegativeInt32()
    {
    }
  }
}
