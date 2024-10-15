// Decompiled with JetBrains decompiler
// Type: SRPG.VersusMatchingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EC7")]
  public class VersusMatchingParam
  {
    [Token(Token = "0x4008127")]
    [FieldOffset(Offset = "0x0")]
    public static string TOWER_KEY;
    [Token(Token = "0x4008128")]
    [FieldOffset(Offset = "0x4")]
    public static string FREE_KEY;
    [Token(Token = "0x4008129")]
    [FieldOffset(Offset = "0x8")]
    public static string FRIEND_KEY;
    [Token(Token = "0x400812A")]
    [FieldOffset(Offset = "0xC")]
    public static string RANKMATCH_KEY;
    [Token(Token = "0x400812B")]
    [FieldOffset(Offset = "0x8")]
    public string MatchKey;
    [Token(Token = "0x400812C")]
    [FieldOffset(Offset = "0xC")]
    public string MatchKeyHash;
    [Token(Token = "0x400812D")]
    [FieldOffset(Offset = "0x10")]
    public int MatchLinePoint;

    [Token(Token = "0x6007E00")]
    [Address(RVA = "0x3FAEC0", Offset = "0x3F9CC0", VA = "0x103FAEC0")]
    public void Deserialize(JSON_VersusMatchingParam json)
    {
    }

    [Token(Token = "0x6007E01")]
    [Address(RVA = "0x3FADA0", Offset = "0x3F9BA0", VA = "0x103FADA0")]
    public static string CalcHash(string msg) => (string) null;

    [Token(Token = "0x6007E02")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusMatchingParam()
    {
    }

    [Token(Token = "0x6007E03")]
    [Address(RVA = "0x3FB050", Offset = "0x3F9E50", VA = "0x103FB050")]
    static VersusMatchingParam()
    {
    }
  }
}
