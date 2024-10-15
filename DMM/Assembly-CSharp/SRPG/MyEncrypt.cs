// Decompiled with JetBrains decompiler
// Type: SRPG.MyEncrypt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001954")]
  public class MyEncrypt
  {
    [Token(Token = "0x4005C1C")]
    [FieldOffset(Offset = "0x0")]
    public static int EncryptCount;
    [Token(Token = "0x4005C1D")]
    [FieldOffset(Offset = "0x4")]
    public static int DecryptCount;

    [Token(Token = "0x600673D")]
    [Address(RVA = "0x321E60", Offset = "0x320C60", VA = "0x10321E60")]
    public static byte[] Encrypt(int seed, string msg, bool compress = false) => (byte[]) null;

    [Token(Token = "0x600673E")]
    [Address(RVA = "0x321D30", Offset = "0x320B30", VA = "0x10321D30")]
    public static string Decrypt(int seed, byte[] data, bool decompress = false) => (string) null;

    [Token(Token = "0x600673F")]
    [Address(RVA = "0x321DF0", Offset = "0x320BF0", VA = "0x10321DF0")]
    public static byte[] Encrypt(byte[] msg) => (byte[]) null;

    [Token(Token = "0x6006740")]
    [Address(RVA = "0x321D80", Offset = "0x320B80", VA = "0x10321D80")]
    public static byte[] Decrypt(byte[] data) => (byte[]) null;

    [Token(Token = "0x6006741")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MyEncrypt()
    {
    }
  }
}
