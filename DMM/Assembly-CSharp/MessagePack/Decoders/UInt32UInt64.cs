// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt32UInt64
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000416")]
  internal sealed class UInt32UInt64 : IUInt64Decoder
  {
    [Token(Token = "0x4000E6B")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly IUInt64Decoder Instance;

    [Token(Token = "0x6001483")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32UInt64()
    {
    }

    [Token(Token = "0x6001484")]
    [Address(RVA = "0x5CC1E0", Offset = "0x5CAFE0", VA = "0x105CC1E0", Slot = "4")]
    public ulong Read(byte[] bytes, int offset, out int readSize) => new ulong();

    [Token(Token = "0x6001485")]
    [Address(RVA = "0x5CC280", Offset = "0x5CB080", VA = "0x105CC280")]
    static UInt32UInt64()
    {
    }
  }
}
