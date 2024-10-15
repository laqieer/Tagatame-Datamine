// Decompiled with JetBrains decompiler
// Type: SRPG.PickBanView
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
  [Token(Token = "0x2002747")]
  [FlowNode.Pin(110, "BAN決定 終了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "BAN選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(20, "BAN決定", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(30, "次のLOCK演出開始", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(101, "Ban決定後の待機", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(40, "切断", FlowNode.PinTypes.Input, 40)]
  [AddComponentMenu("UI/Multi/Versus/Pick_Ban/PickBanView")]
  [FlowNode.Pin(100, "LOCK演出開始", FlowNode.PinTypes.Output, 100)]
  public class PickBanView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B954")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B955")]
    private const int PIN_IN_BAN_SELECT = 10;
    [Token(Token = "0x400B956")]
    private const int PIN_IN_BAN_CONFIRM = 20;
    [Token(Token = "0x400B957")]
    private const int PIN_IN_NEXT_LOCK_EFFECT = 30;
    [Token(Token = "0x400B958")]
    private const int PIN_IN_DISCONNECT = 40;
    [Token(Token = "0x400B959")]
    private const int PIN_OUT_LOCK_EFFECT = 100;
    [Token(Token = "0x400B95A")]
    private const int PIN_OUT_BAN_CONFIRM_WAIT = 101;
    [Token(Token = "0x400B95B")]
    private const int PIN_OUT_BAN_FINISH = 110;
    [Token(Token = "0x400B95C")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<ExhibitList> playerExhibitList;
    [Token(Token = "0x400B95D")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private List<ExhibitList> enemyExhibitList;
    [Token(Token = "0x400B95E")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text txtBanMessage;
    [Token(Token = "0x400B95F")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text txtTime;
    [Token(Token = "0x400B960")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button btnOK;
    [Token(Token = "0x400B961")]
    [FieldOffset(Offset = "0x20")]
    private PhotonManager photonManager;
    [Token(Token = "0x400B962")]
    [FieldOffset(Offset = "0x24")]
    private PhotonPlayerParameter photonPlayerParameter;
    [Token(Token = "0x400B963")]
    [FieldOffset(Offset = "0x28")]
    private PhotonPlayerParameter photonEnemyParameter;
    [Token(Token = "0x400B964")]
    [FieldOffset(Offset = "0x2C")]
    private List<PickBanUnitModel> playerModelList;
    [Token(Token = "0x400B965")]
    [FieldOffset(Offset = "0x30")]
    private List<PickBanUnitModel> enemyModelList;
    [Token(Token = "0x400B966")]
    [FieldOffset(Offset = "0x34")]
    private int mySeatID;
    [Token(Token = "0x400B967")]
    [FieldOffset(Offset = "0x38")]
    private List<int> banUnitListPlayer;
    [Token(Token = "0x400B968")]
    [FieldOffset(Offset = "0x3C")]
    private List<int> banUnitListEnemy;
    [Token(Token = "0x400B969")]
    [FieldOffset(Offset = "0x40")]
    private string baseSecMassage;
    [Token(Token = "0x400B96A")]
    [FieldOffset(Offset = "0x44")]
    private float mDraftSec;
    [Token(Token = "0x400B96B")]
    [FieldOffset(Offset = "0x48")]
    private float playerTimer;
    [Token(Token = "0x400B96C")]
    [FieldOffset(Offset = "0x4C")]
    private bool isUpdateTimer;
    [Token(Token = "0x400B96D")]
    [FieldOffset(Offset = "0x50")]
    private int maxBanCount;
    [Token(Token = "0x400B96E")]
    [FieldOffset(Offset = "0x54")]
    private bool isAudience;
    [Token(Token = "0x400B96F")]
    [FieldOffset(Offset = "0x55")]
    private bool isSingleUpdate;
    [Token(Token = "0x400B970")]
    [FieldOffset(Offset = "0x58")]
    private List<PhotonPlayerData> mAudiencePlayers;

    [Token(Token = "0x17001853")]
    public bool IsSelectActive
    {
      [Token(Token = "0x600B023"), Address(RVA = "0x74B5B0", Offset = "0x74A3B0", VA = "0x1074B5B0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600B024")]
    [Address(RVA = "0x749550", Offset = "0x748350", VA = "0x10749550", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B025")]
    [Address(RVA = "0x749790", Offset = "0x748590", VA = "0x10749790")]
    public void Awake()
    {
    }

    [Token(Token = "0x600B026")]
    [Address(RVA = "0x749EA0", Offset = "0x748CA0", VA = "0x10749EA0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600B027")]
    [Address(RVA = "0x74A600", Offset = "0x749400", VA = "0x1074A600")]
    private void Setup()
    {
    }

    [Token(Token = "0x600B028")]
    [Address(RVA = "0x74AFB0", Offset = "0x749DB0", VA = "0x1074AFB0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B029")]
    [Address(RVA = "0x74AE90", Offset = "0x749C90", VA = "0x1074AE90")]
    private void UpdateTimer()
    {
    }

    [Token(Token = "0x600B02A")]
    [Address(RVA = "0x74A290", Offset = "0x749090", VA = "0x1074A290")]
    private void SelectUnit()
    {
    }

    [Token(Token = "0x600B02B")]
    [Address(RVA = "0x749AF0", Offset = "0x7488F0", VA = "0x10749AF0")]
    private void ConfirmUnit()
    {
    }

    [Token(Token = "0x600B02C")]
    [Address(RVA = "0x749D20", Offset = "0x748B20", VA = "0x10749D20")]
    private void DecideUnitRandom()
    {
    }

    [Token(Token = "0x600B02D")]
    [Address(RVA = "0x749DB0", Offset = "0x748BB0", VA = "0x10749DB0")]
    private PickBanUnitModel GetRandomUnit(List<PickBanUnitModel> modelList)
    {
      return (PickBanUnitModel) null;
    }

    [Token(Token = "0x600B02E")]
    [Address(RVA = "0x7497E0", Offset = "0x7485E0", VA = "0x107497E0")]
    private void BanSelectFinish()
    {
    }

    [Token(Token = "0x600B02F")]
    [Address(RVA = "0x749850", Offset = "0x748650", VA = "0x10749850")]
    private void ConfirmUnitLock()
    {
    }

    [Token(Token = "0x600B030")]
    [Address(RVA = "0x74A0B0", Offset = "0x748EB0", VA = "0x1074A0B0")]
    private void NextLock()
    {
    }

    [Token(Token = "0x600B031")]
    [Address(RVA = "0x74A530", Offset = "0x749330", VA = "0x1074A530")]
    private void SendRoomMessage(PickBanPhotonData.VersusDraftBanMessageData mess, bool is_enemy = false)
    {
    }

    [Token(Token = "0x600B032")]
    [Address(RVA = "0x74AB40", Offset = "0x749940", VA = "0x1074AB40")]
    private void UpdatePhotonMessage()
    {
    }

    [Token(Token = "0x600B033")]
    [Address(RVA = "0x749650", Offset = "0x748450", VA = "0x10749650")]
    private void AudiencePhotonMessage()
    {
    }

    [Token(Token = "0x600B034")]
    [Address(RVA = "0x74AD30", Offset = "0x749B30", VA = "0x1074AD30")]
    private void UpdateSingleMode()
    {
    }

    [Token(Token = "0x600B035")]
    [Address(RVA = "0x74B430", Offset = "0x74A230", VA = "0x1074B430")]
    public PickBanView()
    {
    }
  }
}
