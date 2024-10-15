// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneEnhanceLevelButtonModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003397")]
  public class RuneEnhanceLevelButtonModel
  {
    [Token(Token = "0x400F431")]
    [FieldOffset(Offset = "0x8")]
    private int mNum;
    [Token(Token = "0x400F432")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsOn;
    [Token(Token = "0x400F433")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsEnable;

    [Token(Token = "0x1700201C")]
    public int Num
    {
      [Token(Token = "0x600E5EA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700201D")]
    public bool IsOn
    {
      [Token(Token = "0x600E5EB"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700201E")]
    public bool IsEnable
    {
      [Token(Token = "0x600E5EC"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E5ED")]
    [Address(RVA = "0xAC3BB0", Offset = "0xAC29B0", VA = "0x10AC3BB0")]
    public void Initialize(int num, bool isOn = false)
    {
    }

    [Token(Token = "0x600E5EE")]
    [Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")]
    public void SetFlag(bool isOn)
    {
    }

    [Token(Token = "0x600E5EF")]
    [Address(RVA = "0x3DA470", Offset = "0x3D9270", VA = "0x103DA470")]
    public void SetEnable(bool enable)
    {
    }

    [Token(Token = "0x600E5F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneEnhanceLevelButtonModel()
    {
    }
  }
}
