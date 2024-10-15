// Decompiled with JetBrains decompiler
// Type: SRPG.TowerQuestInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B4D")]
  [FlowNode.Pin(0, "表示更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1200, "クエスト詳細ウィンドウ（開いた）", FlowNode.PinTypes.Output, 1200)]
  [FlowNode.Pin(210, "クエスト詳細ウィンドウ（閉じる）", FlowNode.PinTypes.Input, 210)]
  [FlowNode.Pin(200, "クエスト詳細ウィンドウ（開く）", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(10, "表示更新(強制)", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/TowerQuestInfo")]
  public class TowerQuestInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D3C0")]
    private const int INPUT_REFRESH_UI = 0;
    [Token(Token = "0x400D3C1")]
    private const int INPUT_FORCE_REFRESH_UI = 10;
    [Token(Token = "0x400D3C2")]
    private const int INPUT_QUEST_DETAIL_OPEN = 200;
    [Token(Token = "0x400D3C3")]
    private const int INPUT_QUEST_DETAIL_CLOSE = 210;
    [Token(Token = "0x400D3C4")]
    private const int OUTPUT_QUEST_DETAIL_OPENED = 1200;
    [Token(Token = "0x400D3C5")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼敵情報表示する用")]
    private GameObject EnemiesRoot;
    [Token(Token = "0x400D3C6")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject EnemyTemplate;
    [Token(Token = "0x400D3C7")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject EnemyTemplateUnKnown;
    [Token(Token = "0x400D3C8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [HeaderBar("▼報酬表示用")]
    private Text RewardText;
    [Token(Token = "0x400D3C9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text RecommendText;
    [Token(Token = "0x400D3CA")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ItemRoot;
    [Token(Token = "0x400D3CB")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject ArtifactRoot;
    [Token(Token = "0x400D3CC")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject CoinRoot;
    [Token(Token = "0x400D3CD")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [HeaderBar("▼敵情報が表示できない階層に表示される")]
    private GameObject UnkownIcon;
    [Token(Token = "0x400D3CE")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼クリア済みの階層に表示される")]
    [SerializeField]
    private GameObject ClearIcon;
    [Token(Token = "0x400D3CF")]
    [FieldOffset(Offset = "0x34")]
    [StringIsResourcePath(typeof (GameObject))]
    [HeaderBar("▼詳細表示用プレハブ")]
    [SerializeField]
    private string Path_TowerQuestDetail;
    [Token(Token = "0x400D3D0")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [HeaderBar("▼バトルリセットボタン")]
    private Button BattleResetButton;
    [Token(Token = "0x400D3D1")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    [HeaderBar("▼リセットに必要な幻晶石数")]
    private Text m_BattleResetCost;
    [Token(Token = "0x400D3D2")]
    [FieldOffset(Offset = "0x40")]
    private GameObject m_TowerQuestDetail;
    [Token(Token = "0x400D3D3")]
    [FieldOffset(Offset = "0x44")]
    private List<TowerEnemyListItem> EnemyList;
    [Token(Token = "0x400D3D4")]
    [FieldOffset(Offset = "0x48")]
    private List<TowerEnemyListItem> UnknownEnemyList;
    [Token(Token = "0x400D3D5")]
    [FieldOffset(Offset = "0x4C")]
    private string FloorID;
    [Token(Token = "0x400D3D6")]
    [FieldOffset(Offset = "0x50")]
    private Coroutine m_PrefabLoadRoutine;

    [Token(Token = "0x600C63E")]
    [Address(RVA = "0x8EC850", Offset = "0x8EB650", VA = "0x108EC850", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C63F")]
    [Address(RVA = "0x8ECA20", Offset = "0x8EB820", VA = "0x108ECA20")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C640")]
    [Address(RVA = "0x8ECF20", Offset = "0x8EBD20", VA = "0x108ECF20")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600C641")]
    [Address(RVA = "0x8EE180", Offset = "0x8ECF80", VA = "0x108EE180")]
    private void SetRecommendText(int lv, int joblv)
    {
    }

    [Token(Token = "0x600C642")]
    [Address(RVA = "0x8ECE20", Offset = "0x8EBC20", VA = "0x108ECE20")]
    private void HideAllEnemyIcon()
    {
    }

    [Token(Token = "0x600C643")]
    [Address(RVA = "0x8EDEA0", Offset = "0x8ECCA0", VA = "0x108EDEA0")]
    private void SetIcon(List<TowerQuestInfo.EnemyIconData> icon_datas)
    {
    }

    [Token(Token = "0x600C644")]
    [Address(RVA = "0x8EE310", Offset = "0x8ED110", VA = "0x108EE310")]
    private void SetRewards(TowerRewardParam rewardParam)
    {
    }

    [Token(Token = "0x600C645")]
    [Address(RVA = "0x8ED130", Offset = "0x8EBF30", VA = "0x108ED130")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C646")]
    [Address(RVA = "0x8ECFB0", Offset = "0x8EBDB0", VA = "0x108ECFB0")]
    public void OnQuestDetailOpen()
    {
    }

    [Token(Token = "0x600C647")]
    [Address(RVA = "0x8ECC00", Offset = "0x8EBA00", VA = "0x108ECC00")]
    private void CreateQuestDetailWindow(UnityEngine.Object template)
    {
    }

    [Token(Token = "0x600C648")]
    [Address(RVA = "0x8ED0B0", Offset = "0x8EBEB0", VA = "0x108ED0B0")]
    private IEnumerator PrefabLoadRoutine(string path, Action<UnityEngine.Object> onLoadComplete)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600C649")]
    [Address(RVA = "0x8ECAA0", Offset = "0x8EB8A0", VA = "0x108ECAA0")]
    private void CheckBattleResetButton()
    {
    }

    [Token(Token = "0x600C64A")]
    [Address(RVA = "0x8EE7F0", Offset = "0x8ED5F0", VA = "0x108EE7F0")]
    public TowerQuestInfo()
    {
    }

    [Token(Token = "0x2002B4E")]
    private class EnemyIconData
    {
      [Token(Token = "0x400D3D7")]
      [FieldOffset(Offset = "0x8")]
      public bool is_rand;
      [Token(Token = "0x400D3D8")]
      [FieldOffset(Offset = "0xC")]
      public JSON_MapEnemyUnit enemy;
      [Token(Token = "0x400D3D9")]
      [FieldOffset(Offset = "0x10")]
      public Unit unit;

      [Token(Token = "0x600C64B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public EnemyIconData()
      {
      }
    }
  }
}
