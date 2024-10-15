// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Condition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013AB")]
  [FlowNode.Pin(1, "Yes", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("SRPG/条件判定", 32741)]
  [FlowNode.Pin(2, "No", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(100, "Test", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_Condition : FlowNode
  {
    [Token(Token = "0x400489C")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_Condition.Conditions Condition;

    [Token(Token = "0x600525C")]
    [Address(RVA = "0x1270310", Offset = "0x126F110", VA = "0x11270310")]
    private SupportData GetSupportData() => (SupportData) null;

    [Token(Token = "0x600525D")]
    [Address(RVA = "0x1270290", Offset = "0x126F090", VA = "0x11270290")]
    private SkillParam GetLeaderSkill(PartyData party) => (SkillParam) null;

    [Token(Token = "0x600525E")]
    [Address(RVA = "0x1270390", Offset = "0x126F190", VA = "0x11270390", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600525F")]
    [Address(RVA = "0x12703D0", Offset = "0x126F1D0", VA = "0x112703D0")]
    private void SetResult(bool result)
    {
    }

    [Token(Token = "0x6005260")]
    [Address(RVA = "0x12703F0", Offset = "0x126F1F0", VA = "0x112703F0")]
    private bool Test() => new bool();

    [Token(Token = "0x6005261")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_Condition()
    {
    }

    [Token(Token = "0x20013AC")]
    private class Description : Attribute
    {
      [Token(Token = "0x6005262")]
      [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
      public Description(string text)
      {
      }

      [Token(Token = "0x6005263")]
      [Address(RVA = "0x10F04C0", Offset = "0x10EF2C0", VA = "0x110F04C0")]
      public Description(string text, string detail)
      {
      }
    }

    [Token(Token = "0x20013AD")]
    public enum Conditions
    {
      [Token(Token = "0x400489E"), FlowNode_Condition.Description("スタミナが足りているか", "クエストを開始するのに必要なスタミナがあるかどうか判定します。")] QUEST_HASENOUGHSTAMINA,
      [Token(Token = "0x400489F"), FlowNode_Condition.Description("フレンドであるか")] FRIEND_ISFRIEND,
      [Token(Token = "0x40048A0"), FlowNode_Condition.Description("パーティリーダーはリーダースキルを所持しているか?")] PARTY_LEADERSKILLAVAIL,
      [Token(Token = "0x40048A1"), FlowNode_Condition.Description("選択されたフレンドはフレンドスキルを所持しているか?")] FRIEND_LEADERSKILLAVAIL,
      [Token(Token = "0x40048A2"), FlowNode_Condition.Description("パーティのリーダーが設定されているか")] PARTY_LEADEREXIST,
      [Token(Token = "0x40048A3"), FlowNode_Condition.Description("バトルで現在ターゲットしているユニットに対してコマンドが有効であるか判定します。")] TARGET_COMMANDVALID,
      [Token(Token = "0x40048A4"), FlowNode_Condition.Description("クエストから欠片を入手できるか?")] QUEST_DROPSKAKERA,
      [Token(Token = "0x40048A5"), FlowNode_Condition.Description("クエスト最初のターンか?")] QUEST_FIRSTTURN,
      [Token(Token = "0x40048A6"), FlowNode_Condition.Description("サポートしてくれた人にフレンドリクエスト送るべき?")] QUEST_NEEDFRIENDREQUEST,
      [Token(Token = "0x40048A7"), FlowNode_Condition.Description("プレイヤーのレベルが変化した")] PLAYER_LEVELCHANGED,
      [Token(Token = "0x40048A8"), FlowNode_Condition.Description("ニューゲームが選択された")] NEWGAME,
      [Token(Token = "0x40048A9"), FlowNode_Condition.Description("再開用BTLIDが設定されている")] BTLIDSET,
      [Token(Token = "0x40048AA"), FlowNode_Condition.Description("マルチプレイ中?")] QUEST_ISMULTIPLAY,
      [Token(Token = "0x40048AB"), FlowNode_Condition.Description("アリーナプレイ中?")] QUEST_ISARENA,
      [Token(Token = "0x40048AC"), FlowNode_Condition.Description("勝てばアリーナでランクアップする。")] ARENA_RANKUP,
      [Token(Token = "0x40048AD")] QUEST_HASREWARD,
      [Token(Token = "0x40048AE")] TERMSOFUSE_AGREED,
      [Token(Token = "0x40048AF"), FlowNode_Condition.Description("フレンドは設定されているか？")] FRIEND_VALID,
      [Token(Token = "0x40048B0")] QUEST_ENDSILENT,
      [Token(Token = "0x40048B1"), FlowNode_Condition.Description("サポートユニットの契約金額が不足しているか？")] IS_NOT_ENOUGH_SUPPORT_COST,
      [Token(Token = "0x40048B2"), FlowNode_Condition.Description("マルチはアンロックされているか？")] MULTI_PLAY_IS_UNLOCKED,
      [Token(Token = "0x40048B3"), FlowNode_Condition.Description("オートバトル可能か？")] QUEST_IS_ENABLE_AUTOBATTLE,
      [Token(Token = "0x40048B4"), FlowNode_Condition.Description("オートバトル中か？")] QUEST_IS_AUTOBATTLE,
      [Token(Token = "0x40048B5")] DEBUGBUILD,
      [Token(Token = "0x40048B6"), FlowNode_Condition.Description("Begginer?")] IS_BEGINNER,
      [Token(Token = "0x40048B7"), FlowNode_Condition.Description("チュートリアルを最後まで行ったか？")] IS_END_TUTORIAL,
      [Token(Token = "0x40048B8"), FlowNode_Condition.Description("ユニットを所持しているか？")] IS_GET_UNIT,
      [Token(Token = "0x40048B9"), FlowNode_Condition.Description("対戦はアンロック済みか？")] VERSUS_UNLOCK,
      [Token(Token = "0x40048BA"), FlowNode_Condition.Description("レビューポップアップを表示するか？")] QUEST_IS_SHOW_REVIEW,
      [Token(Token = "0x40048BB"), FlowNode_Condition.Description("クエストは初回クリアか？")] QUEST_IS_FIRST_CLEAR,
      [Token(Token = "0x40048BC"), FlowNode_Condition.Description("クエストタイプがGPSクエストか？")] QUEST_IS_GPS,
      [Token(Token = "0x40048BD"), FlowNode_Condition.Description("選択中のチャプターがGPSヘッダか？")] QUEST_IS_GPSCHAPTER_HEAD,
      [Token(Token = "0x40048BE"), FlowNode_Condition.Description("選択中のチャプターがGPSクエストか？")] QUEST_IS_GPSCHAPTER_QUEST,
      [Token(Token = "0x40048BF"), FlowNode_Condition.Description("選択中のチャプターに有効なGPSクエストがあるか？")] QUEST_IS_GPSCHAPTER_QUEST_VALID,
      [Token(Token = "0x40048C0"), FlowNode_Condition.Description("GPSギフトが有効かどうか")] VALID_GPSGIFT,
      [Token(Token = "0x40048C1"), FlowNode_Condition.Description("シーン遷移中かどうか")] SCENE_CHANGING,
      [Token(Token = "0x40048C2"), FlowNode_Condition.Description("終了デモ再生条件を満たしているか？")] QUEST_IS_PLAY_LAST_DEMO,
      [Token(Token = "0x40048C3"), FlowNode_Condition.Description("ランキングクエストか？")] QUEST_IS_RANKINGQUEST,
      [Token(Token = "0x40048C4"), FlowNode_Condition.Description("ランキングクエストでハイスコア更新したか？")] QUEST_IS_RANKINGQUEST_NEWSCORE,
      [Token(Token = "0x40048C5"), FlowNode_Condition.Description("ランキングクエストで参加報酬をうけとれたか？")] QUEST_IS_RANKINGQUEST_JOIN_REWARD,
      [Token(Token = "0x40048C6"), FlowNode_Condition.Description("ランキングクエストのリザルトで有効なランクだったか？（集計中は無効なランクになる）")] QUEST_IS_RANKINGQUEST_RESULT_VALIDRANK,
      [Token(Token = "0x40048C7"), FlowNode_Condition.Description("前回起動したバージョンと違うか？")] DIFFERENT_VERSION,
      [Token(Token = "0x40048C8"), FlowNode_Condition.Description("選択しているクエストはマルチエリアクエストか？")] SELECTQUEST_IS_MULTIGPS,
      [Token(Token = "0x40048C9"), FlowNode_Condition.Description("LINEから招待されたクエストはマルチエリアクエストか？")] LINEQUEST_IS_MULTIGPS,
      [Token(Token = "0x40048CA"), FlowNode_Condition.Description("エリアクエストは有効なスケジュールか？")] GPSQUEST_IS_VALID,
      [Token(Token = "0x40048CB"), FlowNode_Condition.Description("マルチエリアクエストは有効なスケジュールか？")] MULTI_GPSQUEST_IS_VALID,
      [Token(Token = "0x40048CC"), FlowNode_Condition.Description("複数チームクエストか？")] QUEST_IS_ORDEAL,
      [Token(Token = "0x40048CD"), FlowNode_Condition.Description("クエストでユニットを獲得したか？")] QUEST_IS_GET_UNIT,
      [Token(Token = "0x40048CE"), FlowNode_Condition.Description("初回購入キャンペーンが有効かどうか")] VALID_FIRST_CHARGE_CAMPAIGN,
      [Token(Token = "0x40048CF"), FlowNode_Condition.Description("ゲリラショップが始まったか？")] GUERRILLASHOP_IS_STARTED,
      [Token(Token = "0x40048D0"), FlowNode_Condition.Description("バトルで獲得した真理念装はギフトへ送られた？")] QUEST_END_CARD_IS_SENDMAIL,
      [Token(Token = "0x40048D1"), FlowNode_Condition.Description("ミッションがあるタワークエストか？")] TOWER_QUEST_HAVE_MISSION,
      [Token(Token = "0x40048D2"), FlowNode_Condition.Description("初心者の館への遷移ポップアップを出すべきか？")] SHOW_BEGINNER_TOP_NOTIFY,
      [Token(Token = "0x40048D3"), FlowNode_Condition.Description("闘技場の報酬を取得すべきか？")] GET_ARENA_REWARD,
      [Token(Token = "0x40048D4"), FlowNode_Condition.Description("闘技場のランキング報酬を表示すべきか？")] SHOW_ARENA_REWARD_RANKING,
      [Token(Token = "0x40048D5"), FlowNode_Condition.Description("闘技場の防衛回数報酬を表示すべきか？")] SHOW_ARENA_REWARD_DEFENSE,
      [Token(Token = "0x40048D6"), FlowNode_Condition.Description("DLCのダウンロード前にサイズを表示するか？")] DLC_SHOWSIZEBEFOREDOWNLOADING,
      [Token(Token = "0x40048D7"), FlowNode_Condition.Description("DLCのダウンロード前にサイズを表示するか？(PlayerPrefsを参照しない)")] DLC_SHOWSIZEBEFOREDOWNLOADINGNOPREFS,
      [Token(Token = "0x40048D8"), FlowNode_Condition.Description("クエスト自動周回の計測中か？")] IS_AUTOREPEATQUEST_MEASURING,
      [Token(Token = "0x40048D9"), FlowNode_Condition.Description("創世編・新イベントのボスクエストか？")] QUEST_IS_GEN_ADV_BOSS,
      [Token(Token = "0x40048DA"), FlowNode_Condition.Description("該当するクエストにミッションが設定されているか？")] QUEST_IS_HAVE_MISSION,
      [Token(Token = "0x40048DB"), FlowNode_Condition.Description("創世編・新イベントの周回ボスクエストか？")] QUEST_IS_GEN_ADV_LAP_BOSS,
      [Token(Token = "0x40048DC"), FlowNode_Condition.Description("ルーン：倉庫を拡張可能か？")] RUNE_STORAGE_CANADD,
      [Token(Token = "0x40048DD"), FlowNode_Condition.Description("ルーン：倉庫が満タンか？")] RUNE_STORAGE_IS_FULL,
      [Token(Token = "0x40048DE"), FlowNode_Condition.Description("クエスト自動周回：Box拡張可能か？")] AUTO_REPEAT_QUEST_BOX_CAN_ADD,
      [Token(Token = "0x40048DF"), FlowNode_Condition.Description("プロダクションビルドか？")] PRODUCTIONBUILD,
      [Token(Token = "0x40048E0"), FlowNode_Condition.Description("新闘技場プレイ中?")] QUEST_ISDUEL,
      [Token(Token = "0x40048E1"), FlowNode_Condition.Description("真理の系譜、トップにバッジを表示するか？")] BOND_TOP_BADGE,
      [Token(Token = "0x40048E2"), FlowNode_Condition.Description("真理の系譜受け取れるミッションはあるか？")] BOND_MISSION_BADGE,
      [Token(Token = "0x40048E3"), FlowNode_Condition.Description("ポイントクエストか？")] POINT_QUEST_ENABLE,
      [Token(Token = "0x40048E4"), FlowNode_Condition.Description("傲慢刻印が開放されているか？")] RUNEPRIDE_OPEN,
      [Token(Token = "0x40048E5"), FlowNode_Condition.Description("イベントアーカイブボスバトル情報が情報渡しに保存されているか")] QUESTARCHIVE_BOSSBATTLE,
    }
  }
}
