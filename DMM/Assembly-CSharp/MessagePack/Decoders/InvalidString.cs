// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidString
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200041F")]
  internal sealed class InvalidString : IStringDecoder
  {
    [Token(Token = "0x4000E73")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IStringDecoder Instance;

    [Token(Token = "0x600149C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidString()
    {
    }

    [Token(Token = "0x600149D")]
    [Address(RVA = "0x5C3DF0", Offset = "0x5C2BF0", VA = "0x105C3DF0", Slot = "4")]
    public string Read(byte[] bytes, int offset, out int readSize) => (string) null;

    [Token(Token = "0x600149E")]
    [Address(RVA = "0x5C3EB0", Offset = "0x5C2CB0", VA = "0x105C3EB0")]
    static InvalidString()
    {
    }
  }
}
