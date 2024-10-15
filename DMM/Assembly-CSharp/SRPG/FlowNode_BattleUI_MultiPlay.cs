// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_BattleUI_MultiPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023D2")]
  [FlowNode.Pin(4600, "対戦終了済み", FlowNode.PinTypes.Output, 150)]
  [FlowNode.Pin(4032, "他人切断通知強制終了", FlowNode.PinTypes.Output, 82)]
  [FlowNode.Pin(4031, "他人切断通知終了", FlowNode.PinTypes.Input, 81)]
  [FlowNode.Pin(4030, "他人切断通知開始", FlowNode.PinTypes.Output, 80)]
  [FlowNode.Pin(4000, "制限時間表示", FlowNode.PinTypes.Output, 60)]
  [FlowNode.Pin(4010, "思考中表示", FlowNode.PinTypes.Output, 70)]
  [FlowNode.Pin(4001, "制限時間隠す", FlowNode.PinTypes.Output, 61)]
  [FlowNode.Pin(4502, "強制勝利強制終了", FlowNode.PinTypes.Output, 142)]
  [FlowNode.Pin(4011, "思考中隠す", FlowNode.PinTypes.Output, 71)]
  [FlowNode.Pin(4501, "強制勝利ウィンドウ閉じ", FlowNode.PinTypes.Input, 141)]
  [FlowNode.Pin(4500, "強制勝利", FlowNode.PinTypes.Output, 140)]
  [FlowNode.Pin(4100, "スタンプWindow開始通知", FlowNode.PinTypes.Input, 100)]
  [FlowNode.Pin(4101, "スタンプWindow終了通知", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(4201, "操作時間延長表示", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(4300, "中断復帰開始通知", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(4301, "中断復帰終了通知", FlowNode.PinTypes.Input, 121)]
  [FlowNode.Pin(4302, "自身の復帰完了通知", FlowNode.PinTypes.Output, 122)]
  [FlowNode.Pin(4303, "中断復帰通知強制終了", FlowNode.PinTypes.Output, 123)]
  [FlowNode.Pin(1301, "マップ終了", FlowNode.PinTypes.Output, 51)]
  [FlowNode.Pin(4401, "同期待ち中終了", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(4050, "自分切断", FlowNode.PinTypes.Output, 90)]
  [FlowNode.Pin(1300, "マップ開始", FlowNode.PinTypes.Output, 50)]
  [FlowNode.Pin(4400, "同期待ち中開始", FlowNode.PinTypes.Output, 130)]
  [FlowNode.Pin(1201, "クエスト敗北", FlowNode.PinTypes.Output, 41)]
  [FlowNode.NodeType("Battle_MultiPlay/Events")]
  [FlowNode.Pin(1060, "自分ユニット行動開始", FlowNode.PinTypes.Output, 0)]
  [FlowNode.Pin(1061, "他人ユニット行動開始", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(1062, "敵ユニット行動開始", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1070, "自分ユニット行動終了", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1071, "他人ユニット行動終了", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1072, "敵ユニット行動終了", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(1101, "コンティニュー選択開始", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(1202, "クエスト中断", FlowNode.PinTypes.Output, 42)]
  [FlowNode.Pin(1120, "コンティニュー選択待ち開始", FlowNode.PinTypes.Output, 30)]
  [FlowNode.Pin(4304, "自身の復帰通知強制終了", FlowNode.PinTypes.Output, 124)]
  [AddComponentMenu("")]
  [FlowNode.Pin(4702, "観戦モード強制終了確認完了", FlowNode.PinTypes.Input, 162)]
  [FlowNode.Pin(4701, "観戦モード強制終了", FlowNode.PinTypes.Output, 161)]
  [FlowNode.Pin(4700, "観戦モード", FlowNode.PinTypes.Output, 160)]
  [FlowNode.Pin(4601, "対戦終了済み終了", FlowNode.PinTypes.Input, 151)]
  [FlowNode.Pin(1121, "コンティニュー選択待ち終了", FlowNode.PinTypes.Output, 31)]
  [FlowNode.Pin(1200, "クエスト勝利", FlowNode.PinTypes.Output, 40)]
  public class FlowNode_BattleUI_MultiPlay : FlowNodePersistent
  {
    [Token(Token = "0x400A215")]
    [FieldOffset(Offset = "0x18")]
    public float inputSec;
    [Token(Token = "0x400A216")]
    [FieldOffset(Offset = "0x1C")]
    public bool CheckRandCheat;

    [Token(Token = "0x6009BA2")]
    [Address(RVA = "0x5EDC20", Offset = "0x5ECA20", VA = "0x105EDC20")]
    public void OnMyUnitStart()
    {
    }

    [Token(Token = "0x6009BA3")]
    [Address(RVA = "0x5EDD20", Offset = "0x5ECB20", VA = "0x105EDD20")]
    public void OnOtherUnitStart()
    {
    }

    [Token(Token = "0x6009BA4")]
    [Address(RVA = "0x5EDAE0", Offset = "0x5EC8E0", VA = "0x105EDAE0")]
    public void OnEnemyUnitStart()
    {
    }

    [Token(Token = "0x6009BA5")]
    [Address(RVA = "0x5EDC00", Offset = "0x5ECA00", VA = "0x105EDC00")]
    public void OnMyUnitEnd()
    {
    }

    [Token(Token = "0x6009BA6")]
    [Address(RVA = "0x5EDD00", Offset = "0x5ECB00", VA = "0x105EDD00")]
    public void OnOtherUnitEnd()
    {
    }

    [Token(Token = "0x6009BA7")]
    [Address(RVA = "0x5EDAC0", Offset = "0x5EC8C0", VA = "0x105EDAC0")]
    public void OnEnemyUnitEnd()
    {
    }

    [Token(Token = "0x6009BA8")]
    [Address(RVA = "0x5EDE00", Offset = "0x5ECC00", VA = "0x105EDE00")]
    public void StartSelectContinue()
    {
    }

    [Token(Token = "0x6009BA9")]
    [Address(RVA = "0x5EDDE0", Offset = "0x5ECBE0", VA = "0x105EDDE0")]
    public void ShowWaitContinue()
    {
    }

    [Token(Token = "0x6009BAA")]
    [Address(RVA = "0x5ED740", Offset = "0x5EC540", VA = "0x105ED740")]
    public void HideWaitContinue()
    {
    }

    [Token(Token = "0x6009BAB")]
    [Address(RVA = "0x5EDD80", Offset = "0x5ECB80", VA = "0x105EDD80")]
    public void OnQuestWin()
    {
    }

    [Token(Token = "0x6009BAC")]
    [Address(RVA = "0x5EDD40", Offset = "0x5ECB40", VA = "0x105EDD40")]
    public void OnQuestLose()
    {
    }

    [Token(Token = "0x6009BAD")]
    [Address(RVA = "0x5EDD60", Offset = "0x5ECB60", VA = "0x105EDD60")]
    public void OnQuestRetreat()
    {
    }

    [Token(Token = "0x6009BAE")]
    [Address(RVA = "0x5EDB80", Offset = "0x5EC980", VA = "0x105EDB80")]
    public void OnMapStart()
    {
    }

    [Token(Token = "0x6009BAF")]
    [Address(RVA = "0x5EDB60", Offset = "0x5EC960", VA = "0x105EDB60")]
    public void OnMapEnd()
    {
    }

    [Token(Token = "0x6009BB0")]
    [Address(RVA = "0x5EDDA0", Offset = "0x5ECBA0", VA = "0x105EDDA0")]
    public void ShowInputTimeLimit()
    {
    }

    [Token(Token = "0x6009BB1")]
    [Address(RVA = "0x5ED700", Offset = "0x5EC500", VA = "0x105ED700")]
    public void HideInputTimeLimit()
    {
    }

    [Token(Token = "0x6009BB2")]
    [Address(RVA = "0x5EDDC0", Offset = "0x5ECBC0", VA = "0x105EDDC0")]
    public void ShowThinking()
    {
    }

    [Token(Token = "0x6009BB3")]
    [Address(RVA = "0x5ED720", Offset = "0x5EC520", VA = "0x105ED720")]
    public void HideThinking()
    {
    }

    [Token(Token = "0x6009BB4")]
    [Address(RVA = "0x5EDC60", Offset = "0x5ECA60", VA = "0x105EDC60")]
    public void OnOtherDisconnected()
    {
    }

    [Token(Token = "0x6009BB5")]
    [Address(RVA = "0x5EDC40", Offset = "0x5ECA40", VA = "0x105EDC40")]
    public void OnOtherDisconnectedForce()
    {
    }

    [Token(Token = "0x6009BB6")]
    [Address(RVA = "0x5EDBA0", Offset = "0x5EC9A0", VA = "0x105EDBA0")]
    public void OnMyDisconnected()
    {
    }

    [Token(Token = "0x6009BB7")]
    [Address(RVA = "0x5EDB00", Offset = "0x5EC900", VA = "0x105EDB00")]
    public void OnExtInput()
    {
    }

    [Token(Token = "0x6009BB8")]
    [Address(RVA = "0x5EDCA0", Offset = "0x5ECAA0", VA = "0x105EDCA0")]
    public void OnOtherPlayerResume()
    {
    }

    [Token(Token = "0x6009BB9")]
    [Address(RVA = "0x5EDC80", Offset = "0x5ECA80", VA = "0x105EDC80")]
    public void OnOtherPlayerResumeClose()
    {
    }

    [Token(Token = "0x6009BBA")]
    [Address(RVA = "0x5EDBE0", Offset = "0x5EC9E0", VA = "0x105EDBE0")]
    public void OnMyPlayerResume()
    {
    }

    [Token(Token = "0x6009BBB")]
    [Address(RVA = "0x5EDBC0", Offset = "0x5EC9C0", VA = "0x105EDBC0")]
    public void OnMyPlayerResumeClose()
    {
    }

    [Token(Token = "0x6009BBC")]
    [Address(RVA = "0x5EDCE0", Offset = "0x5ECAE0", VA = "0x105EDCE0")]
    public void OnOtherPlayerSyncStart()
    {
    }

    [Token(Token = "0x6009BBD")]
    [Address(RVA = "0x5EDCC0", Offset = "0x5ECAC0", VA = "0x105EDCC0")]
    public void OnOtherPlayerSyncEnd()
    {
    }

    [Token(Token = "0x6009BBE")]
    [Address(RVA = "0x5EDB40", Offset = "0x5EC940", VA = "0x105EDB40")]
    public void OnForceWin()
    {
    }

    [Token(Token = "0x6009BBF")]
    [Address(RVA = "0x5EDB20", Offset = "0x5EC920", VA = "0x105EDB20")]
    public void OnForceWinClose()
    {
    }

    [Token(Token = "0x6009BC0")]
    [Address(RVA = "0x5EDA60", Offset = "0x5EC860", VA = "0x105EDA60")]
    public void OnAlreadyFinish()
    {
    }

    [Token(Token = "0x6009BC1")]
    [Address(RVA = "0x5EDAA0", Offset = "0x5EC8A0", VA = "0x105EDAA0")]
    public void OnAudienceMode()
    {
    }

    [Token(Token = "0x6009BC2")]
    [Address(RVA = "0x5EDA80", Offset = "0x5EC880", VA = "0x105EDA80")]
    public void OnAudienceForceEnd()
    {
    }

    [Token(Token = "0x6009BC3")]
    [Address(RVA = "0x5ED760", Offset = "0x5EC560", VA = "0x105ED760", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x1700159D")]
    public bool StampWindowIsOpened
    {
      [Token(Token = "0x6009BC4"), Address(RVA = "0x5EDE50", Offset = "0x5ECC50", VA = "0x105EDE50")] get
      {
        return new bool();
      }
      [Token(Token = "0x6009BC5"), Address(RVA = "0x5EDEC0", Offset = "0x5ECCC0", VA = "0x105EDEC0")] set
      {
      }
    }

    [Token(Token = "0x1700159E")]
    public BattleStamp StampWindow
    {
      [Token(Token = "0x6009BC6"), Address(RVA = "0x5EDE60", Offset = "0x5ECC60", VA = "0x105EDE60")] get
      {
        return (BattleStamp) null;
      }
    }

    [Token(Token = "0x6009BC7")]
    [Address(RVA = "0x5EDE20", Offset = "0x5ECC20", VA = "0x105EDE20")]
    public FlowNode_BattleUI_MultiPlay()
    {
    }
  }
}
