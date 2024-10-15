// Decompiled with JetBrains decompiler
// Type: SRPG.DuelReady
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200232C")]
  [AddComponentMenu("UI/Duel/DuelReady")]
  [FlowNode.Pin(140, "ランキング集計中", FlowNode.PinTypes.Output, 140)]
  [FlowNode.Pin(120, "バトル開始OK", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(130, "バトル開始NG", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(100, "表示更新完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(20, "バトル開始チェック", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "表示更新(Assetﾀﾞｳﾝﾛｰﾄﾞ)", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(110, "DLをキャンセル", FlowNode.PinTypes.Output, 110)]
  public class DuelReady : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009D38")]
    private const int PIN_INPUT_REFRESH = 10;
    [Token(Token = "0x4009D39")]
    private const int PIN_INPUT_CHECK_START_BATTLE = 20;
    [Token(Token = "0x4009D3A")]
    private const int PIN_OUTPUT_REFRESH_END = 100;
    [Token(Token = "0x4009D3B")]
    private const int PIN_OUTPUT_CANCEL_DOWNLOAD_ASSETS = 110;
    [Token(Token = "0x4009D3C")]
    private const int PIN_OUTPUT_START_BATTLE_OK = 120;
    [Token(Token = "0x4009D3D")]
    private const int PIN_OUTPUT_START_BATTLE_NG = 130;
    [Token(Token = "0x4009D3E")]
    private const int PIN_OUTPUT_CALC_RANKING_NOW = 140;
    [Token(Token = "0x4009D3F")]
    [FieldOffset(Offset = "0xC")]
    [Space(10f)]
    [SerializeField]
    private GameObject mUnitImageTemplate_Player;
    [Token(Token = "0x4009D40")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mUnitImageTemplate_Enemy;
    [Token(Token = "0x4009D41")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mPartyInfo_Enemy;
    [Token(Token = "0x4009D42")]
    [FieldOffset(Offset = "0x18")]
    [Space(10f)]
    [SerializeField]
    private GameObject mMyRankInObj;
    [Token(Token = "0x4009D43")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mMyRankOutObj;
    [Token(Token = "0x4009D44")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mMyRank;
    [Token(Token = "0x4009D45")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mMyScore;
    [Token(Token = "0x4009D46")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mTotalCombatPowerText;
    [Token(Token = "0x4009D47")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mEnemyPlayerName;
    [Token(Token = "0x4009D48")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mEnemyPlayerLv;
    [Token(Token = "0x4009D49")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mEnemyPlayerRank;
    [Token(Token = "0x4009D4A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mEnemyRankObjRoot;
    [Token(Token = "0x4009D4B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mEnemyPlayerScore;
    [Token(Token = "0x4009D4C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mToDayDuelEnemy;
    [Token(Token = "0x4009D4D")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button mStartBattleBtn;
    [Token(Token = "0x4009D4E")]
    [FieldOffset(Offset = "0x48")]
    private List<GameObject> mCreatedUnitImages_Player;
    [Token(Token = "0x4009D4F")]
    [FieldOffset(Offset = "0x4C")]
    private List<GameObject> mCreatedUnitImages_Enemy;
    [Token(Token = "0x4009D50")]
    [FieldOffset(Offset = "0x50")]
    private bool mIsInitalized;

    [Token(Token = "0x600975C")]
    [Address(RVA = "0x59E170", Offset = "0x59CF70", VA = "0x1059E170", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600975D")]
    [Address(RVA = "0x59E920", Offset = "0x59D720", VA = "0x1059E920")]
    private void Init()
    {
    }

    [Token(Token = "0x600975E")]
    [Address(RVA = "0x59F230", Offset = "0x59E030", VA = "0x1059F230")]
    private void SetGlobalVars()
    {
    }

    [Token(Token = "0x600975F")]
    [Address(RVA = "0x59E950", Offset = "0x59D750", VA = "0x1059E950")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009760")]
    [Address(RVA = "0x59E220", Offset = "0x59D020", VA = "0x1059E220")]
    private void CheckStartBattle()
    {
    }

    [Token(Token = "0x6009761")]
    [Address(RVA = "0x59E690", Offset = "0x59D490", VA = "0x1059E690")]
    private IEnumerator DownloadAssetsAndRefresh() => (IEnumerator) null;

    [Token(Token = "0x6009762")]
    [Address(RVA = "0x59E700", Offset = "0x59D500", VA = "0x1059E700")]
    private List<UnitData> GetEnemyUnits() => (List<UnitData>) null;

    [Token(Token = "0x6009763")]
    [Address(RVA = "0x59E870", Offset = "0x59D670", VA = "0x1059E870")]
    private UnitData GetLeaderUnit(List<UnitData> units) => (UnitData) null;

    [Token(Token = "0x6009764")]
    [Address(RVA = "0x59F370", Offset = "0x59E170", VA = "0x1059F370")]
    public DuelReady()
    {
    }
  }
}
