// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideBoardBonusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029FF")]
  [FlowNode.Pin(5, "潜在能力解放ウィンドウが閉じられた", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(1, "表示更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(4, "潜在能力解放ウィンドウを生成後", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(102, "潜在能力解放ウィンドウデータ設定", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(2, "パネル選択", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "潜在能力解放ウィンドウを開く", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(3, "パネル選択解除", FlowNode.PinTypes.Input, 3)]
  public class RunePrideBoardBonusWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CC0D")]
    private const int PIN_INPUT_REFRESH = 1;
    [Token(Token = "0x400CC0E")]
    private const int PIN_INPUT_SELECT_PANEL = 2;
    [Token(Token = "0x400CC0F")]
    private const int PIN_INPUT_UNSELECT_PANEL = 3;
    [Token(Token = "0x400CC10")]
    private const int PIN_INPUT_CREATED_POTENTIAL_WINDOW = 4;
    [Token(Token = "0x400CC11")]
    private const int PIN_INPUT_CLOSE_POTENTIAL_WINDOW = 5;
    [Token(Token = "0x400CC12")]
    private const int PIN_OUTPUT_OPEN_POTENTIAL_WINDOW = 101;
    [Token(Token = "0x400CC13")]
    private const int PIN_OUTPUT_POTENTIAL_WINDOW_DATA = 102;
    [Token(Token = "0x400CC14")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CC15")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RunePrideParameterListView ParameterListView;
    [Token(Token = "0x400CC16")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform BoardBonusParent;
    [Token(Token = "0x400CC17")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RunePrideBoardBonusView BoardBonusTemplate;
    [Token(Token = "0x400CC18")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject BoardBonusMask;
    [Token(Token = "0x400CC19")]
    [FieldOffset(Offset = "0x20")]
    private UnitData mUnitData;
    [Token(Token = "0x400CC1A")]
    [FieldOffset(Offset = "0x24")]
    private RunePrideBoardBonusWindowModel mModel;
    [Token(Token = "0x400CC1B")]
    [FieldOffset(Offset = "0x28")]
    private List<RunePrideBoardBonusView> mBonusViewList;
    [Token(Token = "0x400CC1C")]
    [FieldOffset(Offset = "0x2C")]
    private bool mInitEnd;
    [Token(Token = "0x400CC1D")]
    [FieldOffset(Offset = "0x30")]
    private RunePrideBonusParam mSelectBonus;
    [Token(Token = "0x400CC1E")]
    [FieldOffset(Offset = "0x34")]
    private RunePrideBoardBonusView mSelectBonusView;
    [Token(Token = "0x400CC1F")]
    [FieldOffset(Offset = "0x38")]
    private bool mWindowCreated;

    [Token(Token = "0x600BF69")]
    [Address(RVA = "0x87D610", Offset = "0x87C410", VA = "0x1087D610", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BF6A")]
    [Address(RVA = "0x87D670", Offset = "0x87C470", VA = "0x1087D670", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600BF6B")]
    [Address(RVA = "0x87EBB0", Offset = "0x87D9B0", VA = "0x1087EBB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BF6C")]
    [Address(RVA = "0x87E440", Offset = "0x87D240", VA = "0x1087E440")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BF6D")]
    [Address(RVA = "0x87E720", Offset = "0x87D520", VA = "0x1087E720")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600BF6E")]
    [Address(RVA = "0x87DE60", Offset = "0x87CC60", VA = "0x1087DE60")]
    private void CreateBoardBonusList()
    {
    }

    [Token(Token = "0x600BF6F")]
    [Address(RVA = "0x87D690", Offset = "0x87C490", VA = "0x1087D690")]
    private void ChangeBoardBonusDisp(SerializeValueList _value_list)
    {
    }

    [Token(Token = "0x600BF70")]
    [Address(RVA = "0x87E630", Offset = "0x87D430", VA = "0x1087E630")]
    private void OnClickBoardBonus(RunePrideBonusParam _param, RunePrideBoardBonusView _view)
    {
    }

    [Token(Token = "0x600BF71")]
    [Address(RVA = "0x87DDA0", Offset = "0x87CBA0", VA = "0x1087DDA0")]
    private void ClearBoardBonusSelect()
    {
    }

    [Token(Token = "0x600BF72")]
    [Address(RVA = "0x87E9D0", Offset = "0x87D7D0", VA = "0x1087E9D0")]
    private void SetPotentialWindowData()
    {
    }

    [Token(Token = "0x600BF73")]
    [Address(RVA = "0x87E3C0", Offset = "0x87D1C0", VA = "0x1087E3C0")]
    private void Draw()
    {
    }

    [Token(Token = "0x600BF74")]
    [Address(RVA = "0x87EBF0", Offset = "0x87D9F0", VA = "0x1087EBF0")]
    public RunePrideBoardBonusWindow()
    {
    }
  }
}
