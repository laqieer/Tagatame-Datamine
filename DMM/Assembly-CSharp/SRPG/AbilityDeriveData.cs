// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityDeriveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E24")]
  public class AbilityDeriveData
  {
    [Token(Token = "0x4007AB8")]
    [FieldOffset(Offset = "0x8")]
    private AbilityDeriveParam m_Param;
    [Token(Token = "0x4007AB9")]
    [FieldOffset(Offset = "0xC")]
    private bool m_IsAdd;
    [Token(Token = "0x4007ABA")]
    [FieldOffset(Offset = "0xD")]
    private bool m_IsDisable;

    [Token(Token = "0x1700110B")]
    public bool IsAdd
    {
      [Token(Token = "0x6007BB4"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007BB5"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
      {
      }
    }

    [Token(Token = "0x1700110C")]
    public bool IsDisable
    {
      [Token(Token = "0x6007BB6"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007BB7"), Address(RVA = "0x3DA470", Offset = "0x3D9270", VA = "0x103DA470")] set
      {
      }
    }

    [Token(Token = "0x1700110D")]
    public AbilityDeriveParam Param
    {
      [Token(Token = "0x6007BB8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (AbilityDeriveParam) null;
      }
    }

    [Token(Token = "0x6007BB9")]
    [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
    public AbilityDeriveData(AbilityDeriveParam param)
    {
    }
  }
}
