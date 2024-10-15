// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixUInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000413")]
  internal sealed class FixUInt64 : IUInt64Decoder
  {
    [Token(Token = "0x4000E68")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt64Decoder Instance;

    [Token(Token = "0x600147A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixUInt64()
    {
    }

    [Token(Token = "0x600147B")]
    [Address(RVA = "0x5C0050", Offset = "0x5BEE50", VA = "0x105C0050", Slot = "4")]
    public ulong Read(byte[] bytes, int offset, out int readSize) => new ulong();

    [Token(Token = "0x600147C")]
    [Address(RVA = "0x5C07B0", Offset = "0x5BF5B0", VA = "0x105C07B0")]
    static FixUInt64()
    {
    }
  }
}
