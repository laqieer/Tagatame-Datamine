// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000406")]
  internal sealed class InvalidInt64 : IInt64Decoder
  {
    [Token(Token = "0x4000E5E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt64Decoder Instance;

    [Token(Token = "0x6001459")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidInt64()
    {
    }

    [Token(Token = "0x600145A")]
    [Address(RVA = "0x5C3850", Offset = "0x5C2650", VA = "0x105C3850", Slot = "4")]
    public long Read(byte[] bytes, int offset, out int readSize) => new long();

    [Token(Token = "0x600145B")]
    [Address(RVA = "0x5C3910", Offset = "0x5C2710", VA = "0x105C3910")]
    static InvalidInt64()
    {
    }
  }
}
