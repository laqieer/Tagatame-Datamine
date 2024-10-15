// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.FixMapHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003AD")]
  internal sealed class FixMapHeader : IMapHeaderDecoder
  {
    [Token(Token = "0x4000E10")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IMapHeaderDecoder Instance;

    [Token(Token = "0x6001364")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private FixMapHeader()
    {
    }

    [Token(Token = "0x6001365")]
    [Address(RVA = "0x5BEC10", Offset = "0x5BDA10", VA = "0x105BEC10", Slot = "4")]
    public uint Read(byte[] bytes, int offset, out int readSize) => new uint();

    [Token(Token = "0x6001366")]
    [Address(RVA = "0x5C00E0", Offset = "0x5BEEE0", VA = "0x105C00E0")]
    static FixMapHeader()
    {
    }
  }
}
