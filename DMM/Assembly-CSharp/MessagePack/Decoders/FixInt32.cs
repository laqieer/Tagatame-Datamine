// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F3")]
  internal sealed class FixInt32 : IInt32Decoder
  {
    [Token(Token = "0x4000E4C")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x6001422")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixInt32()
    {
    }

    [Token(Token = "0x6001423")]
    [Address(RVA = "0x5BFF60", Offset = "0x5BED60", VA = "0x105BFF60", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001424")]
    [Address(RVA = "0x5BFFF0", Offset = "0x5BEDF0", VA = "0x105BFFF0")]
    static FixInt32()
    {
    }
  }
}
