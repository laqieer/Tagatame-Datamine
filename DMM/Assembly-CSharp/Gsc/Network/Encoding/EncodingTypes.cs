// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Encoding.EncodingTypes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network.Encoding
{
  [Token(Token = "0x20035A5")]
  public class EncodingTypes
  {
    [Token(Token = "0x400FD87")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string BASE;
    [Token(Token = "0x400FD88")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string BCT_JSON_SERIALIZED;
    [Token(Token = "0x400FD89")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string BCT_MESSAGE_PACK_SERIALIZED;
    [Token(Token = "0x400FD8A")]
    [FieldOffset(Offset = "0xC")]
    private static readonly string BCT_AES_ENCRYPTED;
    [Token(Token = "0x400FD8B")]
    [FieldOffset(Offset = "0x10")]
    public static readonly string BCT_JSON_AES;
    [Token(Token = "0x400FD8C")]
    [FieldOffset(Offset = "0x14")]
    public static readonly string BCT_MESSAGEPACK;
    [Token(Token = "0x400FD8D")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string BCT_MESSAGEPACK_AES;
    [Token(Token = "0x400FD8E")]
    [FieldOffset(Offset = "0x1C")]
    public static readonly string BCT_NO_EXTRA_KEY_SALT;

    [Token(Token = "0x600EE30")]
    [Address(RVA = "0xB05A90", Offset = "0xB04890", VA = "0x10B05A90")]
    public static CompressMode GetCompressModeFromSerializeCompressMethod(
      EncodingTypes.ESerializeCompressMethod method)
    {
      return new CompressMode();
    }

    [Token(Token = "0x600EE31")]
    [Address(RVA = "0x39DD30", Offset = "0x39CB30", VA = "0x1039DD30")]
    public static bool IsJsonSerializeCompressSelected(EncodingTypes.ESerializeCompressMethod method)
    {
      return new bool();
    }

    [Token(Token = "0x600EE32")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EncodingTypes()
    {
    }

    [Token(Token = "0x600EE33")]
    [Address(RVA = "0xB05AA0", Offset = "0xB048A0", VA = "0x10B05AA0")]
    static EncodingTypes()
    {
    }

    [Token(Token = "0x20035A6")]
    public enum ESerializeCompressMethod
    {
      [Token(Token = "0x400FD90")] JSON,
      [Token(Token = "0x400FD91")] TYPED_MESSAGE_PACK,
      [Token(Token = "0x400FD92")] TYPED_MESSAGE_PACK_LZ4,
    }
  }
}
