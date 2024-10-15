// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.Ext32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x200042F")]
  internal sealed class Ext32 : IExtDecoder
  {
    [Token(Token = "0x4000E81")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IExtDecoder Instance;

    [Token(Token = "0x60014C8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private Ext32()
    {
    }

    [Token(Token = "0x60014C9")]
    [Address(RVA = "0x5BE1D0", Offset = "0x5BCFD0", VA = "0x105BE1D0", Slot = "4")]
    public ExtensionResult Read(byte[] bytes, int offset, out int readSize)
    {
      return new ExtensionResult();
    }

    [Token(Token = "0x60014CA")]
    [Address(RVA = "0x5BE310", Offset = "0x5BD110", VA = "0x105BE310")]
    static Ext32()
    {
    }
  }
}
