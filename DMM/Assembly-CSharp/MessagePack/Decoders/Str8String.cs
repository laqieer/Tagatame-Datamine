// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Str8String
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200041C")]
  internal sealed class Str8String : IStringDecoder
  {
    [Token(Token = "0x4000E70")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringDecoder Instance;

    [Token(Token = "0x6001493")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Str8String()
    {
    }

    [Token(Token = "0x6001494")]
    [Address(RVA = "0x5CA7C0", Offset = "0x5C95C0", VA = "0x105CA7C0", Slot = "4")]
    public string Read(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x6001495")]
    [Address(RVA = "0x5CA850", Offset = "0x5C9650", VA = "0x105CA850")]
    static Str8String()
    {
    }
  }
}
