// Decompiled with JetBrains decompiler
// Type: SRPG.LoginBonusMonthParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026DE")]
  public class LoginBonusMonthParam
  {
    [Token(Token = "0x400B6BD")]
    [FieldOffset(Offset = "0x8")]
    private LoginBonusMonthState m_State;
    [Token(Token = "0x400B6BE")]
    [FieldOffset(Offset = "0xC")]
    private int m_Day;

    [Token(Token = "0x1700181B")]
    public LoginBonusMonthState State
    {
      [Token(Token = "0x600AE15"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new LoginBonusMonthState();
      }
    }

    [Token(Token = "0x1700181C")]
    public int Day
    {
      [Token(Token = "0x600AE16"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600AE17")]
    [Address(RVA = "0x721420", Offset = "0x720220", VA = "0x10721420")]
    public LoginBonusMonthParam(LoginBonusMonthState state, int day)
    {
    }
  }
}
