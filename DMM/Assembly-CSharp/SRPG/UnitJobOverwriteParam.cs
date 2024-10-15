// Decompiled with JetBrains decompiler
// Type: SRPG.UnitJobOverwriteParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E87")]
  public class UnitJobOverwriteParam
  {
    [Token(Token = "0x4007EAE")]
    [FieldOffset(Offset = "0x8")]
    private StatusParam status;
    [Token(Token = "0x4007EAF")]
    [FieldOffset(Offset = "0xC")]
    public string mUnitIname;
    [Token(Token = "0x4007EB0")]
    [FieldOffset(Offset = "0x10")]
    public string mJobIname;
    [Token(Token = "0x4007EB1")]
    [FieldOffset(Offset = "0x14")]
    public int mAvoid;
    [Token(Token = "0x4007EB2")]
    [FieldOffset(Offset = "0x18")]
    public int mInimp;

    [Token(Token = "0x1700117B")]
    public StatusParam mStatus
    {
      [Token(Token = "0x6007D2E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (StatusParam) null;
      }
    }

    [Token(Token = "0x6007D2F")]
    [Address(RVA = "0x3F14F0", Offset = "0x3F02F0", VA = "0x103F14F0")]
    public bool Deserialize(JSON_UnitJobOverwriteParam json) => new bool();

    [Token(Token = "0x6007D30")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitJobOverwriteParam()
    {
    }
  }
}
