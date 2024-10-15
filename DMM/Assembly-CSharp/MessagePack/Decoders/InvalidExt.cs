// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.InvalidExt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000430")]
  internal sealed class InvalidExt : IExtDecoder
  {
    [Token(Token = "0x4000E82")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014CB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private InvalidExt()
    {
    }

    [Token(Token = "0x60014CC")]
    [Address(RVA = "0x5C34F0", Offset = "0x5C22F0", VA = "0x105C34F0", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014CD")]
    [Address(RVA = "0x5C35B0", Offset = "0x5C23B0", VA = "0x105C35B0")]
    static InvalidExt()
    {
    }
  }
}
