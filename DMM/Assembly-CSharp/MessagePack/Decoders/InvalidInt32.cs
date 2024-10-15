// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidInt32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003FA")]
  internal sealed class InvalidInt32 : IInt32Decoder
  {
    [Token(Token = "0x4000E53")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x6001437")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidInt32()
    {
    }

    [Token(Token = "0x6001438")]
    [Address(RVA = "0x5C3730", Offset = "0x5C2530", VA = "0x105C3730", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x6001439")]
    [Address(RVA = "0x5C37F0", Offset = "0x5C25F0", VA = "0x105C37F0")]
    static InvalidInt32()
    {
    }
  }
}
