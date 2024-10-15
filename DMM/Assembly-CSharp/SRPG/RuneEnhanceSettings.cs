// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEnhanceSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029BB")]
  public class RuneEnhanceSettings
  {
    [Token(Token = "0x400CA67")]
    [FieldOffset(Offset = "0x8")]
    private RuneEnhanceSettings.eEnhanceMode mMode;
    [Token(Token = "0x400CA68")]
    [FieldOffset(Offset = "0xC")]
    private RuneEnhanceSettings.eEnhanceMode mStartedMode;
    [Token(Token = "0x400CA69")]
    [FieldOffset(Offset = "0x10")]
    private int mValue;
    [Token(Token = "0x400CA6A")]
    [FieldOffset(Offset = "0x14")]
    private bool mUseGauge;

    [Token(Token = "0x1700199D")]
    public RuneEnhanceSettings.eEnhanceMode Mode
    {
      [Token(Token = "0x600BDCA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new RuneEnhanceSettings.eEnhanceMode();
      }
    }

    [Token(Token = "0x1700199E")]
    public RuneEnhanceSettings.eEnhanceMode StartedMode
    {
      [Token(Token = "0x600BDCB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new RuneEnhanceSettings.eEnhanceMode();
      }
    }

    [Token(Token = "0x1700199F")]
    public int Value
    {
      [Token(Token = "0x600BDCC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170019A0")]
    public bool UseGauge
    {
      [Token(Token = "0x600BDCD"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BDCE")]
    [Address(RVA = "0x856270", Offset = "0x855070", VA = "0x10856270")]
    public void Setup(RuneEnhanceSettings.eEnhanceMode mode, int value, bool use_gauge)
    {
    }

    [Token(Token = "0x600BDCF")]
    [Address(RVA = "0x856240", Offset = "0x855040", VA = "0x10856240")]
    public void Reset(bool is_all = false)
    {
    }

    [Token(Token = "0x600BDD0")]
    [Address(RVA = "0x8561D0", Offset = "0x854FD0", VA = "0x108561D0")]
    public void Decrement()
    {
    }

    [Token(Token = "0x600BDD1")]
    [Address(RVA = "0x8561F0", Offset = "0x854FF0", VA = "0x108561F0")]
    public bool IsEnableContinueEnhance(RuneData rune) => new bool();

    [Token(Token = "0x600BDD2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneEnhanceSettings()
    {
    }

    [Token(Token = "0x20029BC")]
    public enum eEnhanceMode
    {
      [Token(Token = "0x400CA6C")] Normal,
      [Token(Token = "0x400CA6D")] Limit_PlusCount,
      [Token(Token = "0x400CA6E")] Limit_EnhanceCount,
    }
  }
}
