// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Str16String
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200041D")]
  internal sealed class Str16String : IStringDecoder
  {
    [Token(Token = "0x4000E71")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringDecoder Instance;

    [Token(Token = "0x6001496")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Str16String()
    {
    }

    [Token(Token = "0x6001497")]
    [Address(RVA = "0x5CA360", Offset = "0x5C9160", VA = "0x105CA360", Slot = "4")]
    public string Read(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x6001498")]
    [Address(RVA = "0x5CA410", Offset = "0x5C9210", VA = "0x105CA410")]
    static Str16String()
    {
    }
  }
}
