// Decompiled with JetBrains decompiler
// Type: SRPG.RoomPlayerList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200295E")]
  [FlowNode.Pin(312, "フレンドAIのキック完了", FlowNode.PinTypes.Output, 312)]
  [FlowNode.Pin(400, "オーナーがいない", FlowNode.PinTypes.Output, 400)]
  [FlowNode.Pin(10, "データソース更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(311, "フレンドAI選択ポップアップ開く", FlowNode.PinTypes.Output, 311)]
  [FlowNode.Pin(310, "フレンドAI選択ボタン押下", FlowNode.PinTypes.Input, 310)]
  [FlowNode.Pin(3, "階層更新完了", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(200, "チーム編成ボタンが押された", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(101, "情報を見る", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("Multi/部屋に参加中のプレイヤー一覧")]
  [FlowNode.Pin(0, "表示", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "表示更新", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "階層更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(300, "部屋のプレイヤーがキックされた", FlowNode.PinTypes.Input, 300)]
  public class RoomPlayerList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C75B")]
    private const int PIN_IN_VIEW = 0;
    [Token(Token = "0x400C75C")]
    private const int PIN_IN_UPDATE_FLOOR = 2;
    [Token(Token = "0x400C75D")]
    private const int PIN_IN_UPDATE_DATA_SOURCE = 10;
    [Token(Token = "0x400C75E")]
    private const int PIN_IN_ON_KICK_ROOM_MEMBER = 300;
    [Token(Token = "0x400C75F")]
    private const int PIN_IN_ON_SUPPORT_FRIEND = 310;
    [Token(Token = "0x400C760")]
    private const int PIN_OUT_OPEN_SUPPORT_FRIEND = 311;
    [Token(Token = "0x400C761")]
    private const int PIN_OUT_KICKED_SUPPORT = 312;
    [Token(Token = "0x400C762")]
    private const int PIN_OUT_UPDATE_VIEW = 1;
    [Token(Token = "0x400C763")]
    private const int PIN_OUT_UPDATE_FLOOR_COMPLETE = 3;
    [Token(Token = "0x400C764")]
    private const int PIN_OUT_SHOW_DETAIL = 101;
    [Token(Token = "0x400C765")]
    private const int PIN_OUT_ON_EDIT_TEAM = 200;
    [Token(Token = "0x400C766")]
    private const int PIN_OUT_OWNER_LEAVE = 400;
    [Token(Token = "0x400C767")]
    [FieldOffset(Offset = "0xC")]
    [Description("リストアイテムとして使用するゲームオブジェクト")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400C768")]
    [FieldOffset(Offset = "0x10")]
    [Description("リストアイテムとして使用するゲームオブジェクト(ペアマルチ)")]
    public GameObject ItemTemplatePair;
    [Token(Token = "0x400C769")]
    [FieldOffset(Offset = "0x14")]
    [Description("大本ゲームオブジェクト")]
    public GameObject Root;
    [Token(Token = "0x400C76A")]
    [FieldOffset(Offset = "0x18")]
    [Description("編成ランキングボタン")]
    public GameObject RankButton;
    [Token(Token = "0x400C76B")]
    [FieldOffset(Offset = "0x1C")]
    [Description("スキル名")]
    public GameObject SkillObj;
    [Token(Token = "0x400C76C")]
    [FieldOffset(Offset = "0x20")]
    [Description("スキル詳細用プレハブ")]
    public GameObject Prefab_LeaderSkillDetail;
    [Token(Token = "0x400C76D")]
    [FieldOffset(Offset = "0x24")]
    public ScrollRect ScrollRect;
    [Token(Token = "0x400C76E")]
    [FieldOffset(Offset = "0x28")]
    public List<GameObject> UIItemList;
    [Token(Token = "0x400C76F")]
    [FieldOffset(Offset = "0x2C")]
    public List<MultiSupportData> MultiSupportList;
    [Token(Token = "0x400C770")]
    [FieldOffset(Offset = "0x30")]
    public bool SupportRefresIsSkip;
    [Token(Token = "0x400C771")]
    [FieldOffset(Offset = "0x34")]
    private int mSupportAIIndex;
    [Token(Token = "0x400C772")]
    [FieldOffset(Offset = "0x38")]
    [Description("プレイヤーのパーティ情報表示用のゲームオブジェクト")]
    public GameObject PlayerInfo;
    [Token(Token = "0x400C773")]
    [FieldOffset(Offset = "0x3C")]
    private List<GameObject> PlayerInfoList;

    [Token(Token = "0x1700196C")]
    public static RoomPlayerList Instance
    {
      [Token(Token = "0x600BB18"), Address(RVA = "0x830180", Offset = "0x82EF80", VA = "0x10830180")] get
      {
        return (RoomPlayerList) null;
      }
      [Token(Token = "0x600BB19"), Address(RVA = "0x8301B0", Offset = "0x82EFB0", VA = "0x108301B0")] private set
      {
      }
    }

    [Token(Token = "0x600BB1A")]
    [Address(RVA = "0x82D6B0", Offset = "0x82C4B0", VA = "0x1082D6B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BB1B")]
    [Address(RVA = "0x82DA00", Offset = "0x82C800", VA = "0x1082DA00")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BB1C")]
    [Address(RVA = "0x82DE60", Offset = "0x82CC60", VA = "0x1082DE60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BB1D")]
    [Address(RVA = "0x830080", Offset = "0x82EE80", VA = "0x10830080")]
    private void Start()
    {
    }

    [Token(Token = "0x600BB1E")]
    [Address(RVA = "0x82FBE0", Offset = "0x82E9E0", VA = "0x1082FBE0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BB1F")]
    [Address(RVA = "0x82E390", Offset = "0x82D190", VA = "0x1082E390")]
    public void RefreshFloorQuest()
    {
    }

    [Token(Token = "0x600BB20")]
    [Address(RVA = "0x82E450", Offset = "0x82D250", VA = "0x1082E450")]
    private void RefreshItems()
    {
    }

    [Token(Token = "0x600BB21")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnSelectItem(GameObject go)
    {
    }

    [Token(Token = "0x600BB22")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnCloseItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600BB23")]
    [Address(RVA = "0x82DF50", Offset = "0x82CD50", VA = "0x1082DF50")]
    public void OnOpenItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600BB24")]
    [Address(RVA = "0x6DE8F0", Offset = "0x6DD6F0", VA = "0x106DE8F0")]
    public void OnEditTeam()
    {
    }

    [Token(Token = "0x600BB25")]
    [Address(RVA = "0x82DEA0", Offset = "0x82CCA0", VA = "0x1082DEA0")]
    public void OnEditTeamMultiTower(int index)
    {
    }

    [Token(Token = "0x600BB26")]
    [Address(RVA = "0x82E230", Offset = "0x82D030", VA = "0x1082E230")]
    public void OpenLeaderSkillDetail()
    {
    }

    [Token(Token = "0x600BB27")]
    [Address(RVA = "0x82DC80", Offset = "0x82CA80", VA = "0x1082DC80")]
    private void KickMember()
    {
    }

    [Token(Token = "0x1700196D")]
    public GameObject TargetItem
    {
      [Token(Token = "0x600BB28"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (GameObject) null;
      }
      [Token(Token = "0x600BB29"), Address(RVA = "0x36F630", Offset = "0x36E430", VA = "0x1036F630")] private set
      {
      }
    }

    [Token(Token = "0x600BB2A")]
    [Address(RVA = "0x82E160", Offset = "0x82CF60", VA = "0x1082E160")]
    private void OpenFriendPopup()
    {
    }

    [Token(Token = "0x600BB2B")]
    [Address(RVA = "0x82FD10", Offset = "0x82EB10", VA = "0x1082FD10")]
    public void SetFriend(MultiSupportData multiSupportData)
    {
    }

    [Token(Token = "0x600BB2C")]
    [Address(RVA = "0x830090", Offset = "0x82EE90", VA = "0x10830090")]
    public RoomPlayerList()
    {
    }
  }
}
