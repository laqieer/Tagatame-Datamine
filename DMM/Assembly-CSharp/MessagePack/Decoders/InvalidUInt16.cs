// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidUInt16
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200040B")]
  internal sealed class InvalidUInt16 : IUInt16Decoder
  {
    [Token(Token = "0x4000E62")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt16Decoder Instance;

    [Token(Token = "0x6001466")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidUInt16()
    {
    }

    [Token(Token = "0x6001467")]
    [Address(RVA = "0x5C3F10", Offset = "0x5C2D10", VA = "0x105C3F10", Slot = "4")]
    public ushort Read(byte[] bytes, int offset, out int readSize) => new ushort();

    [Token(Token = "0x6001468")]
    [Address(RVA = "0x5C3FD0", Offset = "0x5C2DD0", VA = "0x105C3FD0")]
    static InvalidUInt16()
    {
    }
  }
}
