// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEnhanceLevelButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200299E")]
  public class RuneEnhanceLevelButton : MonoBehaviour
  {
    [Token(Token = "0x400C940")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C941")]
    [FieldOffset(Offset = "0x10")]
    public RuneEnhanceLevelButtonModel mModel;

    [Token(Token = "0x1700198B")]
    public RuneEnhanceLevelButtonModel Model
    {
      [Token(Token = "0x600BCBC"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (RuneEnhanceLevelButtonModel) null;
      }
    }

    [Token(Token = "0x600BCBD")]
    [Address(RVA = "0x845CB0", Offset = "0x844AB0", VA = "0x10845CB0")]
    public void Initialize(int num, bool isOn = false)
    {
    }

    [Token(Token = "0x600BCBE")]
    [Address(RVA = "0x845D90", Offset = "0x844B90", VA = "0x10845D90")]
    public void Initialize(RuneEnhanceLevelButtonModel model)
    {
    }

    [Token(Token = "0x600BCBF")]
    [Address(RVA = "0x845F50", Offset = "0x844D50", VA = "0x10845F50")]
    public void SetFlag(bool isOn)
    {
    }

    [Token(Token = "0x600BCC0")]
    [Address(RVA = "0x845F00", Offset = "0x844D00", VA = "0x10845F00")]
    public void SetFlag(int num)
    {
    }

    [Token(Token = "0x600BCC1")]
    [Address(RVA = "0x845EB0", Offset = "0x844CB0", VA = "0x10845EB0")]
    public void SetEnable(bool enable)
    {
    }

    [Token(Token = "0x600BCC2")]
    [Address(RVA = "0x845E10", Offset = "0x844C10", VA = "0x10845E10")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BCC3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneEnhanceLevelButton()
    {
    }
  }
}
