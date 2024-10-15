// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidExtHeader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200043A")]
  internal sealed class InvalidExtHeader : IExtHeaderDecoder
  {
    [Token(Token = "0x4000E8B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtHeaderDecoder Instance;

    [Token(Token = "0x60014E7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidExtHeader()
    {
    }

    [Token(Token = "0x60014E8")]
    [Address(RVA = "0x5C33D0", Offset = "0x5C21D0", VA = "0x105C33D0", Slot = "4")]
    public ExtensionHeader Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionHeader();
    }

    [Token(Token = "0x60014E9")]
    [Address(RVA = "0x5C3490", Offset = "0x5C2290", VA = "0x105C3490")]
    static InvalidExtHeader()
    {
    }
  }
}
