// Decompiled with JetBrains decompiler
// Type: SRPG.RuneContinueReinforcement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002977")]
  [FlowNode.Pin(101, "コスト変更", FlowNode.PinTypes.Output, 101)]
  public class RuneContinueReinforcement : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C7FC")]
    private const int OUTPUT_COST_CHANGE = 101;
    [Token(Token = "0x400C7FD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x400C7FE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ToggleGroup mEnhanceLevelButtonToggleGroup;
    [Token(Token = "0x400C7FF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mEnhanceLevelButtonParent;
    [Token(Token = "0x400C800")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mEnhanceLevelButtonBase;
    [Token(Token = "0x400C801")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ToggleGroup mEvoLevelButtonToggleGroup;
    [Token(Token = "0x400C802")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mEvoLevelButtonParent;
    [Token(Token = "0x400C803")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mEvoLevelButtonBase;
    [Token(Token = "0x400C804")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SystemSound mOnToggleSoundEffect;
    [Token(Token = "0x400C805")]
    [FieldOffset(Offset = "0x2C")]
    private RuneContinueReinforcementModel mModel;
    [Token(Token = "0x400C806")]
    [FieldOffset(Offset = "0x30")]
    private List<RuneEnhanceLevelButton> mEnhanceLevelButtonList;
    [Token(Token = "0x400C807")]
    [FieldOffset(Offset = "0x34")]
    private List<RuneEnhanceLevelButton> mEvoLevelButtonList;
    [Token(Token = "0x400C808")]
    [FieldOffset(Offset = "0x38")]
    private bool mIsCreateButton;

    [Token(Token = "0x1700197E")]
    public RuneContinueReinforcementModel Model
    {
      [Token(Token = "0x600BBBA"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (RuneContinueReinforcementModel) null;
      }
    }

    [Token(Token = "0x600BBBB")]
    [Address(RVA = "0x832630", Offset = "0x831430", VA = "0x10832630")]
    public void Initialize(BindRuneData rune, bool is_reset = false)
    {
    }

    [Token(Token = "0x600BBBC")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BBBD")]
    [Address(RVA = "0x8323E0", Offset = "0x8311E0", VA = "0x108323E0")]
    public bool InitializeLevelButtonList() => new bool();

    [Token(Token = "0x600BBBE")]
    [Address(RVA = "0x831FB0", Offset = "0x830DB0", VA = "0x10831FB0")]
    public void CreateButton(
      List<RuneEnhanceLevelButton> list,
      Transform parent,
      GameObject base_button,
      int button_num,
      int now_num)
    {
    }

    [Token(Token = "0x600BBBF")]
    [Address(RVA = "0x832F50", Offset = "0x831D50", VA = "0x10832F50")]
    public void SetLevelButtonEnable()
    {
    }

    [Token(Token = "0x600BBC0")]
    [Address(RVA = "0x832710", Offset = "0x831510", VA = "0x10832710")]
    public void OnEnhanceLevelButton(Toggle self)
    {
    }

    [Token(Token = "0x600BBC1")]
    [Address(RVA = "0x832990", Offset = "0x831790", VA = "0x10832990")]
    public void OnEvoLevelButton(Toggle self)
    {
    }

    [Token(Token = "0x600BBC2")]
    [Address(RVA = "0x833230", Offset = "0x832030", VA = "0x10833230")]
    public void SetVisible(bool visible)
    {
    }

    [Token(Token = "0x600BBC3")]
    [Address(RVA = "0x832E80", Offset = "0x831C80", VA = "0x10832E80")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BBC4")]
    [Address(RVA = "0x832CF0", Offset = "0x831AF0", VA = "0x10832CF0")]
    public void RefreshButton(List<RuneEnhanceLevelButton> buttons)
    {
    }

    [Token(Token = "0x600BBC5")]
    [Address(RVA = "0x833210", Offset = "0x832010", VA = "0x10833210")]
    public void SetMaterialList()
    {
    }

    [Token(Token = "0x600BBC6")]
    [Address(RVA = "0x832200", Offset = "0x831000", VA = "0x10832200")]
    public void EnhanceLevelButtonEnable()
    {
    }

    [Token(Token = "0x600BBC7")]
    [Address(RVA = "0x832340", Offset = "0x831140", VA = "0x10832340")]
    public void EvoLevelButtonEnable()
    {
    }

    [Token(Token = "0x600BBC8")]
    [Address(RVA = "0x833250", Offset = "0x832050", VA = "0x10833250")]
    public RuneContinueReinforcement()
    {
    }
  }
}
