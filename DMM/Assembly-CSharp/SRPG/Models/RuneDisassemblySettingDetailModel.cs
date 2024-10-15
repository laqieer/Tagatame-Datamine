// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDisassemblySettingDetailModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200338D")]
  public class RuneDisassemblySettingDetailModel
  {
    [Token(Token = "0x400F3F4")]
    [FieldOffset(Offset = "0x8")]
    private string _title;
    [Token(Token = "0x400F3F5")]
    [FieldOffset(Offset = "0xC")]
    private bool _isSelect;
    [Token(Token = "0x400F3F6")]
    [FieldOffset(Offset = "0xD")]
    private bool _isStateTab;
    [Token(Token = "0x400F3F7")]
    [FieldOffset(Offset = "0x10")]
    private string _setEffectIconKey;
    [Token(Token = "0x400F3F8")]
    [FieldOffset(Offset = "0x14")]
    private AutoRuneDisassemblyParam _param;
    [Token(Token = "0x400F3F9")]
    [FieldOffset(Offset = "0x18")]
    private AutoRuneSettingCondParam _condParam;
    [Token(Token = "0x400F3FA")]
    [FieldOffset(Offset = "0x1C")]
    private List<RuneDisassemblySettingStatusModel> _statusModels;

    [Token(Token = "0x17001FEF")]
    public AutoRuneDisassemblyParam Param
    {
      [Token(Token = "0x600E589"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (AutoRuneDisassemblyParam) null;
      }
    }

    [Token(Token = "0x17001FF0")]
    public AutoRuneSettingCondParam CondParam
    {
      [Token(Token = "0x600E58A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (AutoRuneSettingCondParam) null;
      }
    }

    [Token(Token = "0x17001FF1")]
    public string Title
    {
      [Token(Token = "0x600E58B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FF2")]
    public string SetEffectIconKey
    {
      [Token(Token = "0x600E58C"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FF3")]
    public bool IsSelect
    {
      [Token(Token = "0x600E58D"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E58E"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
      {
      }
    }

    [Token(Token = "0x17001FF4")]
    public bool IsStateTab
    {
      [Token(Token = "0x600E58F"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
      [Token(Token = "0x600E590"), Address(RVA = "0x3DA470", Offset = "0x3D9270", VA = "0x103DA470")] set
      {
      }
    }

    [Token(Token = "0x17001FF5")]
    public List<RuneDisassemblySettingStatusModel> StatusModels
    {
      [Token(Token = "0x600E591"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<RuneDisassemblySettingStatusModel>) null;
      }
      [Token(Token = "0x600E592"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x600E593")]
    [Address(RVA = "0xAC24E0", Offset = "0xAC12E0", VA = "0x10AC24E0")]
    public void Initialize(AutoRuneDisassemblyParam param, bool isSelect)
    {
    }

    [Token(Token = "0x600E594")]
    [Address(RVA = "0xAC22C0", Offset = "0xAC10C0", VA = "0x10AC22C0")]
    public void Initialize(AutoRuneDisassemblyParam param, AutoRuneSettingCondParam condParam)
    {
    }

    [Token(Token = "0x600E595")]
    [Address(RVA = "0xAC2660", Offset = "0xAC1460", VA = "0x10AC2660")]
    private bool IsSetData() => new bool();

    [Token(Token = "0x600E596")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDisassemblySettingDetailModel()
    {
    }
  }
}
