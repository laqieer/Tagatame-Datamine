// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003FD")]
  internal sealed class FixInt64 : IInt64Decoder
  {
    [Token(Token = "0x4000E55")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x600143E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixInt64()
    {
    }

    [Token(Token = "0x600143F")]
    [Address(RVA = "0x5C0050", Offset = "0x5BEE50", VA = "0x105C0050", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x6001440")]
    [Address(RVA = "0x5C0080", Offset = "0x5BEE80", VA = "0x105C0080")]
    static FixInt64()
    {
    }
  }
}
