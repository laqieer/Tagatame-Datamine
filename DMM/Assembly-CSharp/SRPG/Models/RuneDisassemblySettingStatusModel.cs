// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDisassemblySettingStatusModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200338E")]
  public class RuneDisassemblySettingStatusModel
  {
    [Token(Token = "0x400F3FB")]
    [FieldOffset(Offset = "0x8")]
    private string _message;
    [Token(Token = "0x400F3FC")]
    [FieldOffset(Offset = "0xC")]
    private string _name;
    [Token(Token = "0x400F3FD")]
    [FieldOffset(Offset = "0x10")]
    private float _max;
    [Token(Token = "0x400F3FE")]
    [FieldOffset(Offset = "0x14")]
    private float _min;
    [Token(Token = "0x400F3FF")]
    [FieldOffset(Offset = "0x18")]
    private float _val;
    [Token(Token = "0x400F400")]
    [FieldOffset(Offset = "0x1C")]
    private bool _isCheckbox;
    [Token(Token = "0x400F401")]
    [FieldOffset(Offset = "0x20")]
    private AutoRuneDisassemblyStatesCondParam _statesParam;

    [Token(Token = "0x17001FF6")]
    public AutoRuneDisassemblyStatesCondParam StatesParam
    {
      [Token(Token = "0x600E597"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (AutoRuneDisassemblyStatesCondParam) null;
      }
    }

    [Token(Token = "0x17001FF7")]
    public string Message
    {
      [Token(Token = "0x600E598"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FF8")]
    public string Name
    {
      [Token(Token = "0x600E599"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FF9")]
    public float Max
    {
      [Token(Token = "0x600E59A"), Address(RVA = "0x2CD710", Offset = "0x2CC510", VA = "0x102CD710")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001FFA")]
    public float Min
    {
      [Token(Token = "0x600E59B"), Address(RVA = "0x2C72E0", Offset = "0x2C60E0", VA = "0x102C72E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001FFB")]
    public float Val
    {
      [Token(Token = "0x600E59C"), Address(RVA = "0x3A3980", Offset = "0x3A2780", VA = "0x103A3980")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001FFC")]
    public bool IsCheckbox
    {
      [Token(Token = "0x600E59D"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E59E"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] set
      {
      }
    }

    [Token(Token = "0x600E59F")]
    [Address(RVA = "0xAC2750", Offset = "0xAC1550", VA = "0x10AC2750")]
    public void Initialize(
      AutoRuneDisassemblyParam param,
      AutoRuneSettingCondParam condParam,
      AutoRuneDisassemblyStatesCondParam statesParam)
    {
    }

    [Token(Token = "0x600E5A0")]
    [Address(RVA = "0xAC2D60", Offset = "0xAC1B60", VA = "0x10AC2D60")]
    public void RefreshMessage(float value)
    {
    }

    [Token(Token = "0x600E5A1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDisassemblySettingStatusModel()
    {
    }
  }
}
