// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidInt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F0")]
  internal sealed class InvalidInt16 : IInt16Decoder
  {
    [Token(Token = "0x4000E4A")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt16Decoder Instance;

    [Token(Token = "0x600141B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidInt16()
    {
    }

    [Token(Token = "0x600141C")]
    [Address(RVA = "0x5C3610", Offset = "0x5C2410", VA = "0x105C3610", Slot = "4")]
    public short Read(byte[] bytes, int offset, out int readSize) => new short();

    [Token(Token = "0x600141D")]
    [Address(RVA = "0x5C36D0", Offset = "0x5C24D0", VA = "0x105C36D0")]
    static InvalidInt16()
    {
    }
  }
}
