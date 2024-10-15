// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt16Int32
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003F5")]
  internal sealed class UInt16Int32 : IInt32Decoder
  {
    [Token(Token = "0x4000E4E")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IInt32Decoder Instance;

    [Token(Token = "0x6001428")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16Int32()
    {
    }

    [Token(Token = "0x6001429")]
    [Address(RVA = "0x5BAB80", Offset = "0x5B9980", VA = "0x105BAB80", Slot = "4")]
    public int Read(byte[] bytes, int offset, out int readSize) => new int();

    [Token(Token = "0x600142A")]
    [Address(RVA = "0x5CBA50", Offset = "0x5CA850", VA = "0x105CBA50")]
    static UInt16Int32()
    {
    }
  }
}
