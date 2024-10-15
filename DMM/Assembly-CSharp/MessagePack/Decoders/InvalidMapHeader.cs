// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidMapHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003B0")]
  internal sealed class InvalidMapHeader : IMapHeaderDecoder
  {
    [Token(Token = "0x4000E13")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IMapHeaderDecoder Instance;

    [Token(Token = "0x600136D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidMapHeader()
    {
    }

    [Token(Token = "0x600136E")]
    [Address(RVA = "0x5C3970", Offset = "0x5C2770", VA = "0x105C3970", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x600136F")]
    [Address(RVA = "0x5C3A30", Offset = "0x5C2830", VA = "0x105C3A30")]
    static InvalidMapHeader()
    {
    }
  }
}
