// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalReleaseAllConfirmWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003337")]
  public class CrystalReleaseAllConfirmWindowModel
  {
    [Token(Token = "0x400F1C0")]
    [FieldOffset(Offset = "0x8")]
    private UnitModel mIconModel;
    [Token(Token = "0x400F1C1")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsUseQuest;
    [Token(Token = "0x400F1C2")]
    [FieldOffset(Offset = "0xD")]
    private bool mIsUseArena;
    [Token(Token = "0x400F1C3")]
    [FieldOffset(Offset = "0xE")]
    private bool mIsUseSupport;
    [Token(Token = "0x400F1C4")]
    [FieldOffset(Offset = "0xF")]
    private bool mIsUseGvG;
    [Token(Token = "0x400F1C5")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsUseLeagueMatch;

    [Token(Token = "0x17001E31")]
    public UnitModel IconModel
    {
      [Token(Token = "0x600E260"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x17001E32")]
    public bool IsUseQuest
    {
      [Token(Token = "0x600E261"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E33")]
    public bool IsUseArena
    {
      [Token(Token = "0x600E262"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E34")]
    public bool IsUseSupport
    {
      [Token(Token = "0x600E263"), Address(RVA = "0x3E7F60", Offset = "0x3E6D60", VA = "0x103E7F60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E35")]
    public bool IsUseGvG
    {
      [Token(Token = "0x600E264"), Address(RVA = "0x3E7F50", Offset = "0x3E6D50", VA = "0x103E7F50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E36")]
    public bool IsUseLeagueMatch
    {
      [Token(Token = "0x600E265"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E266")]
    [Address(RVA = "0xAAFB80", Offset = "0xAAE980", VA = "0x10AAFB80")]
    public void Initialize(CrystalWindow.CrystalUseUnitState _data)
    {
    }

    [Token(Token = "0x600E267")]
    [Address(RVA = "0xAAFDA0", Offset = "0xAAEBA0", VA = "0x10AAFDA0")]
    private void SetData(UnitData unitData)
    {
    }

    [Token(Token = "0x600E268")]
    [Address(RVA = "0xAAFDA0", Offset = "0xAAEBA0", VA = "0x10AAFDA0")]
    private void SetIcon(UnitData unitData)
    {
    }

    [Token(Token = "0x600E269")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalReleaseAllConfirmWindowModel()
    {
    }
  }
}
