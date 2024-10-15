// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixNegativeInt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003EA")]
  internal sealed class FixNegativeInt16 : IInt16Decoder
  {
    [Token(Token = "0x4000E44")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x6001409")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixNegativeInt16()
    {
    }

    [Token(Token = "0x600140A")]
    [Address(RVA = "0x5C0310", Offset = "0x5BF110", VA = "0x105C0310", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x600140B")]
    [Address(RVA = "0x5C0340", Offset = "0x5BF140", VA = "0x105C0340")]
    static FixNegativeInt16()
    {
    }
  }
}
