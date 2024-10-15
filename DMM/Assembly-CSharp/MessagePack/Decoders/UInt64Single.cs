// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.UInt64Single
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003D8")]
  internal sealed class UInt64Single : ISingleDecoder
  {
    [Token(Token = "0x4000E34")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly ISingleDecoder Instance;

    [Token(Token = "0x60013D7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt64Single()
    {
    }

    [Token(Token = "0x60013D8")]
    [Address(RVA = "0x5CC5F0", Offset = "0x5CB3F0", VA = "0x105CC5F0", Slot = "4")]
    public float Read(byte[] bytes, int offset, out int readSize) => new float();

    [Token(Token = "0x60013D9")]
    [Address(RVA = "0x5CC670", Offset = "0x5CB470", VA = "0x105CC670")]
    static UInt64Single()
    {
    }
  }
}
