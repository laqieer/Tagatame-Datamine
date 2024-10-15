// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Str32String
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200041E")]
  internal sealed class Str32String : IStringDecoder
  {
    [Token(Token = "0x4000E72")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringDecoder Instance;

    [Token(Token = "0x6001499")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Str32String()
    {
    }

    [Token(Token = "0x600149A")]
    [Address(RVA = "0x5CA5A0", Offset = "0x5C93A0", VA = "0x105CA5A0", Slot = "4")]
    public string Read(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x600149B")]
    [Address(RVA = "0x5CA680", Offset = "0x5C9480", VA = "0x105CA680")]
    static Str32String()
    {
    }
  }
}
