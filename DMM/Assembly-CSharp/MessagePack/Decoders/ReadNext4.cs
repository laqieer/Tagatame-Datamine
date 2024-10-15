// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ReadNext4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000444")]
  internal sealed class ReadNext4 : IReadNextDecoder
  {
    [Token(Token = "0x4000E93")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IReadNextDecoder Instance;

    [Token(Token = "0x6001501")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ReadNext4()
    {
    }

    [Token(Token = "0x6001502")]
    [Address(RVA = "0x5C9210", Offset = "0x5C8010", VA = "0x105C9210", Slot = "4")]
    public int Read(byte[] bytes, int offset) => new int();

    [Token(Token = "0x6001503")]
    [Address(RVA = "0x5C9220", Offset = "0x5C8020", VA = "0x105C9220")]
    static ReadNext4()
    {
    }
  }
}
