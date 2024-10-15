// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt64Int64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000401")]
  internal sealed class UInt64Int64 : IInt64Decoder
  {
    [Token(Token = "0x4000E59")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x600144A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt64Int64()
    {
    }

    [Token(Token = "0x600144B")]
    [Address(RVA = "0x5CC3D0", Offset = "0x5CB1D0", VA = "0x105CC3D0", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x600144C")]
    [Address(RVA = "0x5CC590", Offset = "0x5CB390", VA = "0x105CC590")]
    static UInt64Int64()
    {
    }
  }
}
