// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.NilString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200041A")]
  internal sealed class NilString : IStringDecoder
  {
    [Token(Token = "0x4000E6E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringDecoder Instance;

    [Token(Token = "0x600148D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NilString()
    {
    }

    [Token(Token = "0x600148E")]
    [Address(RVA = "0x5C8E70", Offset = "0x5C7C70", VA = "0x105C8E70", Slot = "4")]
    public string Read(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x600148F")]
    [Address(RVA = "0x5C8FA0", Offset = "0x5C7DA0", VA = "0x105C8FA0")]
    static NilString()
    {
    }
  }
}
