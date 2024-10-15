// Decompiled with JetBrains decompiler
// Type: SRPG.DuelEnemyList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200231B")]
  [FlowNode.Pin(100, "対戦相手を選択した", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "表示更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "スクロール位置リセット", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(110, "対戦相手の詳細を開く", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("UI/Duel/DuelEnemyList")]
  public class DuelEnemyList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009CB1")]
    private const int PIN_INPUT_REFRESH = 10;
    [Token(Token = "0x4009CB2")]
    private const int PIN_INPUT_RESET_SCROLL_POS = 20;
    [Token(Token = "0x4009CB3")]
    private const int PIN_OUTPUT_ENEMY_SELECTED = 100;
    [Token(Token = "0x4009CB4")]
    private const int PIN_OUTPUT_ENEMY_DETAIL = 110;
    [Token(Token = "0x4009CB5")]
    private const string DUEL_SVB_KEY_PLAYER_NAME = "player_name";
    [Token(Token = "0x4009CB6")]
    private const string DUEL_SVB_KEY_PLAYER_LV = "player_lv";
    [Token(Token = "0x4009CB7")]
    private const string DUEL_SVB_KEY_RANKING = "ranking";
    [Token(Token = "0x4009CB8")]
    private const string DUEL_SVB_KEY_UNIT_ICON = "unit_icon";
    [Token(Token = "0x4009CB9")]
    private const string DUEL_SVB_KEY_RANK_OBJ = "rank_obj";
    [Token(Token = "0x4009CBA")]
    private const string DUEL_SVB_KEY_SCORE = "score";
    [Token(Token = "0x4009CBB")]
    private const string DUEL_SVB_KEY_RANK_OUT = "rank_out";
    [Token(Token = "0x4009CBC")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SRPG_ListBase EnemyPlayerList;
    [Token(Token = "0x4009CBD")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ListItemEvents EnemyPlayerItem;
    [Token(Token = "0x4009CBE")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollRect mScrollRect;

    [Token(Token = "0x600970D")]
    [Address(RVA = "0x597680", Offset = "0x596480", VA = "0x10597680", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600970E")]
    [Address(RVA = "0x598370", Offset = "0x597170", VA = "0x10598370")]
    private void ResetScrollPosition()
    {
    }

    [Token(Token = "0x600970F")]
    [Address(RVA = "0x597F40", Offset = "0x596D40", VA = "0x10597F40")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6009710")]
    [Address(RVA = "0x5979B0", Offset = "0x5967B0", VA = "0x105979B0")]
    private void RefreshSVB(GameObject icon_root, DuelPlayerData enemy_player, int party_unit_max)
    {
    }

    [Token(Token = "0x6009711")]
    [Address(RVA = "0x598420", Offset = "0x597220", VA = "0x10598420")]
    private void SetText(GameObject obj, string str)
    {
    }

    [Token(Token = "0x6009712")]
    [Address(RVA = "0x597870", Offset = "0x596670", VA = "0x10597870")]
    private void OnEnemySelect(GameObject go)
    {
    }

    [Token(Token = "0x6009713")]
    [Address(RVA = "0x597750", Offset = "0x596550", VA = "0x10597750")]
    private void OnEnemyDetailSelect(GameObject go)
    {
    }

    [Token(Token = "0x6009714")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelEnemyList()
    {
    }

    [Token(Token = "0x200231C")]
    private enum eBgIndex
    {
      [Token(Token = "0x4009CC0")] OVER,
      [Token(Token = "0x4009CC1")] EQUAL,
      [Token(Token = "0x4009CC2")] UNDER,
    }
  }
}
