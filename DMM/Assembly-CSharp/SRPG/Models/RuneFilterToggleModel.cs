// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneFilterToggleModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003398")]
  public class RuneFilterToggleModel
  {
    [Token(Token = "0x400F434")]
    private const string SYS_TEXT_HEAD = "sys.";
    [Token(Token = "0x400F435")]
    [FieldOffset(Offset = "0x8")]
    private FilterUtility.FilterBindData mData;
    [Token(Token = "0x400F436")]
    [FieldOffset(Offset = "0xC")]
    private FilterRuneConditionParam mParam;
    [Token(Token = "0x400F437")]
    [FieldOffset(Offset = "0x10")]
    private string mName;
    [Token(Token = "0x400F438")]
    [FieldOffset(Offset = "0x14")]
    private string mStatusName;

    [Token(Token = "0x600E5F1")]
    [Address(RVA = "0xAC3D00", Offset = "0xAC2B00", VA = "0x10AC3D00")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600E5F2")]
    [Address(RVA = "0xAC3D90", Offset = "0xAC2B90", VA = "0x10AC3D90")]
    public void Initialize(FilterRuneConditionParam param)
    {
    }

    [Token(Token = "0x600E5F3")]
    [Address(RVA = "0xAC4070", Offset = "0xAC2E70", VA = "0x10AC4070")]
    public void SetName()
    {
    }

    [Token(Token = "0x600E5F4")]
    [Address(RVA = "0xAC40D0", Offset = "0xAC2ED0", VA = "0x10AC40D0")]
    public void SetStatusName()
    {
    }

    [Token(Token = "0x600E5F5")]
    [Address(RVA = "0xAC3C30", Offset = "0xAC2A30", VA = "0x10AC3C30")]
    public string GetParentIname() => (string) null;

    [Token(Token = "0x600E5F6")]
    [Address(RVA = "0xAC3BD0", Offset = "0xAC29D0", VA = "0x10AC3BD0")]
    public string GetConditionIname() => (string) null;

    [Token(Token = "0x600E5F7")]
    [Address(RVA = "0xAA87D0", Offset = "0xAA75D0", VA = "0x10AA87D0")]
    public int GetRarity() => new int();

    [Token(Token = "0x600E5F8")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public string GetName() => (string) null;

    [Token(Token = "0x600E5F9")]
    [Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")]
    public string GetStatusName() => (string) null;

    [Token(Token = "0x600E5FA")]
    [Address(RVA = "0xAC3C10", Offset = "0xAC2A10", VA = "0x10AC3C10")]
    public ArtifactTypes GetEquipType() => new ArtifactTypes();

    [Token(Token = "0x600E5FB")]
    [Address(RVA = "0xAC3CE0", Offset = "0xAC2AE0", VA = "0x10AC3CE0")]
    public byte GetRuneSetEffectType() => new byte();

    [Token(Token = "0x600E5FC")]
    [Address(RVA = "0xAC3C80", Offset = "0xAC2A80", VA = "0x10AC3C80")]
    public string GetRuneSetEffectIconIndex() => (string) null;

    [Token(Token = "0x600E5FD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneFilterToggleModel()
    {
    }
  }
}
