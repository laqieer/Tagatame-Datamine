// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidUInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000418")]
  internal sealed class InvalidUInt64 : IUInt64Decoder
  {
    [Token(Token = "0x4000E6D")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt64Decoder Instance;

    [Token(Token = "0x6001489")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidUInt64()
    {
    }

    [Token(Token = "0x600148A")]
    [Address(RVA = "0x5C4150", Offset = "0x5C2F50", VA = "0x105C4150", Slot = "4")]
    public ulong Read(byte[] bytes, int offset, out int readSize) => new ulong();

    [Token(Token = "0x600148B")]
    [Address(RVA = "0x5C4210", Offset = "0x5C3010", VA = "0x105C4210")]
    static InvalidUInt64()
    {
    }
  }
}
